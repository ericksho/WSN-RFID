using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Threading;
using Szaat.RFID.CSharpAPI;
using System.Runtime.InteropServices;

namespace CSharpRFIDDemo
{
    public partial class Home : Form
    {
        bool connected;

        #region parameter

        public string sReaderIP = "192.168.0.238";

        public int iReaderPoint = 7086;

        /// <summary>
        /// connect state
        /// </summary>
        public bool bConnState = false;

        /// <summary>
        /// Reader Handle
        /// </summary>
        public IntPtr pHandle = IntPtr.Zero;

        Thread readThread = null;

        /// <summary>
        /// Read start
        /// </summary>
        bool bReadCodeState = false;

        RevMsgBuffer revMsgLine = new RevMsgBuffer();

        int SAAT_CODE_TYPE = 0;

        byte sAntenna = 1;

        public bool bBeep = true;


        public static string[] sSysInfoBuf = new string[7];

        public static byte[] sSysInfoLen = new byte[] { 8, 6, 8, 4, 4, 4, 4 };

        #endregion

        public Home()
        {
            InitializeComponent();

            connected = false;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            readerIP.Text = sReaderIP;
            readerPort.Text = iReaderPoint.ToString();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (readThread.IsAlive) readThread.Abort();
            }
            catch { }

            System.Diagnostics.Process[] LocalPro = System.Diagnostics.Process.GetProcessesByName("ProcessName");
            if (LocalPro.Length > 0)
            {
                foreach (System.Diagnostics.Process a in LocalPro) { a.Kill(); }
            }
        }

        private void readerIP_TextChanged(object sender, EventArgs e)
        {
            string _ip = readerIP.Text;
            if (!IsCorrenctIP(_ip)) { ShowResult("Error de la dirección IP", Win32.BeepType.Failure); readerIP.Text = sReaderIP; return; }

            sReaderIP = readerIP.Text;
        }

        public bool IsCorrenctIP(string ip)
        {
            string pattrn = @"(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])\.(\d{1,2}|1\d\d|2[0-4]\d|25[0-5])";
            if (System.Text.RegularExpressions.Regex.IsMatch(ip, pattrn))
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        private void ShowResult(string _msg, Win32.BeepType _beepType)
        {
            lstResult.Items.Add(_msg);
            lstResult.SelectedIndex = lstResult.Items.Count - 1;

            ShowResult(_beepType);
        }
        private void ShowResult(Win32.BeepType _beepType)
        {
            if (bBeep) { Win32.Beep(_beepType); }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            // Connect to the reader
            if (!connected)
            {
                //Connect
                bool bInit = false;

                bInit = RfidApi.SAAT_TCPInit(out pHandle, sReaderIP, iReaderPoint);
                
                if (!bInit)
                {
                    ShowResult("Error", Win32.BeepType.Failure);
                    return;
                }

                bConnState = RfidApi.SAAT_Open(pHandle);
                if (!bConnState)
                {
                    ShowResult("Error de conexión", Win32.BeepType.Failure);
                    return;
                }

                ShowResult("Conectado", Win32.BeepType.Success);
                connected = true;

                //Get reader info
                btnLoadSysInfo_Click(sender, e);

                //Start Reading
                if (readThread != null)
                {
                    if (readThread.IsAlive)
                    {
                        readThread.Abort();
                        readThread.Join();
                    }
                }

                if (!CReadCode())
                {
                    ShowResult("Error!", Win32.BeepType.Success);
                    return;
                }

                bReadCodeState = true;
                timerUpdateListView.Enabled = true;
                revMsgLine.ClearMsg();

                ShowResult("Lectura comenzada", Win32.BeepType.Success);

                readThread = new Thread(new ThreadStart(RevCodeMsgThread));
                readThread.Start();
            }

            // Disconnect from the reader
            else
            {
                //Stop reading
                timerUpdateListView.Enabled = false;

                if (readThread.IsAlive)
                {
                    readThread.Abort();
                    readThread.Join();
                }

                if (RfidApi.SAAT_YPowerOff(pHandle))
                {
                    ShowResult("Lectura terminada", Win32.BeepType.Success);
                }
                else
                {
                    ShowResult("Error" + CGetErrorMessage(), Win32.BeepType.Failure);
                }

                bReadCodeState = false;

                //Close connection
                bConnState = !CloseConn();
                if (bConnState)
                {
                    ShowResult("Error al desconectar", Win32.BeepType.Failure);
                    return;
                }

                ShowResult("Desconectado", Win32.BeepType.Success);
                connected = false;

                CSPicture.Image = Image.FromFile("../imgs/connectionNo.png");
                CSLabel.Text = "Sin conexión al lector";
                CSLabel.Location = new Point(30, 116);

                connectButton.Text = "Conectar";
                connectButton.Size = new System.Drawing.Size(75, 23);
                connectButton.Location = new Point(45, 150);

                readerNameLabel.Text = "Nombre: ";
                readerModelLabel.Text = "Modelo: ";
                readerIPLabel.Text = "IP: ";
                readerName.Text = "";
                readerModel.Text = "";
                readerSerial.Text = "";

                
            }
        }

        private void btnLoadSysInfo_Click(object sender, EventArgs e)
        {

            string sCallback = "";

            for (byte i = 0; i <= 6; i++)
            {
                if (!GetSysInfo(i, ref sCallback, sSysInfoLen[i]))
                {
                    ShowResult("Error", Win32.BeepType.Failure);
                    return;
                }
                sSysInfoBuf[i] = sCallback;
            }

            ShowResult("Ok", Win32.BeepType.Success);

            readerName.Text = sSysInfoBuf[0];
            readerModel.Text = sSysInfoBuf[1];
            readerSerial.Text = sSysInfoBuf[2];

            readerNameLabel.Text = "Nombre: " + sSysInfoBuf[0];
            readerModelLabel.Text = "Modelo: " + sSysInfoBuf[1];
            readerIPLabel.Text = "IP: " + sReaderIP;

            CSPicture.Image = Image.FromFile("../imgs/connectionOk.png");
            CSLabel.Text = "Conexión exitosa con el lector";
            CSLabel.Location = new Point(13, 116);

            connectButton.Text = "Desconectar";
            connectButton.Size = new System.Drawing.Size(87, 23);
            connectButton.Location = new Point(40, 150);
        }

        public bool GetSysInfo(byte nType, ref string sCallback, byte iLenght)
        {
            if (CSysQuery(nType, ref sCallback))
            {
                if (sCallback.Length > iLenght)
                    sCallback = sCallback.Substring(0, iLenght);
                else
                    sCallback = sCallback.ToString();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CSysQuery(byte nType, ref string pPara)
        {
            pPara = "";
            IntPtr ptr = Marshal.AllocHGlobal(255);
            byte sLength = 255;
            bool bResult = RfidApi.SAAT_SysInfQuery(pHandle, nType, ptr, ref sLength);
            if (bResult)
                pPara = Marshal.PtrToStringAnsi(ptr, sLength);
            Marshal.FreeHGlobal(ptr);
            return bResult;
        }

        private bool CloseConn()
        {
            if (pHandle == IntPtr.Zero)
            {
                return true;
            }

            bReadCodeState = false;
            bool bRet = RfidApi.SAAT_Close(pHandle);
            if (bRet)
            {
                pHandle = IntPtr.Zero;
            }
            return bRet;
        }

        void Reconnect()
        {
            while (true)
            {

                CloseConn();    // close
                
                bool bInit = false;
                bInit = RfidApi.SAAT_TCPInit(out pHandle, sReaderIP, iReaderPoint);

                if (!bInit)
                {
                    continue;
                }

                bConnState = RfidApi.SAAT_Open(pHandle);
                if (!bConnState)
                {
                    continue;
                }

                bReadCodeState = true;
                if (!CReadCode())
                {
                    continue;
                }

                break;
            }
        }

        private void RevCodeMsgThread()
        {
            int nRevMsgResult = 0;

            RevMsgStruct revMsg = new RevMsgStruct();
            int dwStart = System.Environment.TickCount;
            bool bConnectIsOK = false;
            while (bReadCodeState)
            {
                nRevMsgResult = CRevCodeMsg(ref revMsg);
                if (nRevMsgResult == 1)
                {
                    bConnectIsOK = true;
                    revMsgLine.RevMsgAdd(revMsg);
                    ShowResult(Win32.BeepType.Success);
                }
                else if (nRevMsgResult == 2)
                {
                    bConnectIsOK = true;
                }

                if (System.Environment.TickCount - dwStart > 4000)
                {
                    if (!bConnectIsOK)
                    {
                        //LabelDisTig.Text = "Reconnect......";
                        Reconnect();
                        //LabelDisTig.Text = "";
                    }

                    bConnectIsOK = false;
                    dwStart = System.Environment.TickCount;
                }
            }
        }

        public bool CReadCode()
        {
            bool bResult = RfidApi.SAAT_YMakeTagUpLoadIDCode(pHandle, 0x01, 0x01);
            return bResult;
        }

        public int CRevCodeMsg(ref RevMsgStruct revMsg)
        {
            byte sLength = 255;     // 
            byte nBit = 0x00;
            string sData = "";
            //byte[] btData = new byte[255];
            uint btData = 0;
            int bResult = 0;

            try
            {
                //bResult = RfidApi.SAAT_YRevIDMsgHex(pHandle, btData, out sLength, out nBit);
                bResult = RfidApi.SAAT_YRevIDMsgDec(pHandle, out btData, out nBit);
            }
            catch
            {
            }

            if (bResult == 1) //&& sLength != 255)
            {
                //revMsg.nAntenna = (int)sAntenna;
                //for (byte bytei = 0; bytei < sLength; bytei++)
                //    sData += btData[bytei].ToString("X2");
                revMsg.sCodeData = btData.ToString();
                revMsg.nRepeatTime = 1;
                revMsg.tBeginTime = System.DateTime.Now;
                revMsg.tLastTime = System.DateTime.Now;
            }
            return bResult;
        }

        private void timerUpdateListView_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < revMsgLine.TagCount; i++)
            {

                listViewCard.Items.Clear();
                
                listViewCard.Items.Add(revMsgLine.Get(i).sCodeData.ToString());
                listViewCard.Items[i].SubItems.Add(revMsgLine.Get(i).tLastTime.ToString("dd/MM/yy HH:mm:ss"));
            }
        }

        public string CGetErrorMessage()
        {
            byte[] btErrorMsg = new byte[255];
            string sErrorMsg = "";
            if (pHandle == IntPtr.Zero)
                sErrorMsg = "Error";
            else
            {
                RfidApi.SAAT_GetErrorMessage(pHandle, btErrorMsg, 255);
                sErrorMsg = Encoding.Default.GetString(btErrorMsg);
            }
            return "Error: " + sErrorMsg;
        }


    }
}
