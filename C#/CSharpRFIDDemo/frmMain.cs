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
    public partial class frmMain : Form
    {

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

        #region function
        public frmMain()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            txtIP.Text = sReaderIP;
            txtPoint.Text = iReaderPoint.ToString();
            cbxBeep.Checked = bBeep;
            rbnTCP.Checked = true;

            upButtonEnabled();
        }

        private void cbxBeep_CheckedChanged(object sender, EventArgs e)
        {
            bBeep = cbxBeep.Checked;
        }

        private void txtIP_TextChanged(object sender, EventArgs e)
        {
            string _ip = txtIP.Text;
            if (!IsCorrenctIP(_ip)) { ShowResult("IP address error", Win32.BeepType.Failure); txtIP.Text = sReaderIP; return; }

            sReaderIP = txtIP.Text;
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

        private void txtPoint_TextChanged(object sender, EventArgs e)
        {
            int _point;
            try
            {
                _point = int.Parse(txtPoint.Text);
                if (_point > 65535) { throw new Exception(); }
                iReaderPoint = _point;
            }
            catch { ShowResult("port error", Win32.BeepType.Failure); txtPoint.Text = iReaderPoint.ToString(); return; }
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

        private void upButtonEnabled()
        {

            btnOpenConn.Enabled = !bConnState;
            rbnTCP.Enabled = !bConnState;
            txtIP.Enabled = !bConnState;
            txtPoint.Enabled = !bConnState;

            btnCloseConn.Enabled = bConnState;

            btnReadCards.Enabled = !bReadCodeState && bConnState;
            btnStopReadCards.Enabled = bReadCodeState && bConnState;

            btnLoadSysInfo.Enabled = !bReadCodeState && bConnState;
            btnSetReaderName.Enabled = !bReadCodeState && bConnState;
            btnShowCopyright.Enabled = !bReadCodeState && bConnState;
        }

        private void btnListViewCard_Click(object sender, EventArgs e)
        {
            revMsgLine.ClearMsg();
            listViewCard.Items.Clear();
        }

        private void btnClearResult_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();
        }

        #endregion


        #region Initialization, connect

        private void btnOpenConn_Click(object sender, EventArgs e)
        {

            bool bInit = false;

            if (rbnTCP.Checked)
            {

                bInit = RfidApi.SAAT_TCPInit(out pHandle, sReaderIP, iReaderPoint);
            }
            else
            {
                if (cbxCom.SelectedIndex < 0)
                {
                    ShowResult("please select a COM", Win32.BeepType.Failure);
                    return;
                }

                bInit = RfidApi.SAAT_COMInit(out pHandle, 0x00, cbxCom.SelectedItem.ToString(), 19200);
            }

            if (!bInit)
            {
                ShowResult("error", Win32.BeepType.Failure);
                return;
            }

            bConnState = RfidApi.SAAT_Open(pHandle);
            if (!bConnState)
            {
                ShowResult("open failure", Win32.BeepType.Failure);
                return;
            }

            ShowResult("connect success", Win32.BeepType.Success);
            upButtonEnabled();
            btnLoadSysInfo_Click(sender, e);
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

        private void btnCloseConn_Click(object sender, EventArgs e)
        {
            bConnState = !CloseConn();
            if (bConnState)
            {
                ShowResult("close failure!", Win32.BeepType.Failure);
                return;
            }

            ShowResult("close success!", Win32.BeepType.Success);
            upButtonEnabled();
        }

        #endregion


        #region function

        private void btnReadCards_Click(object sender, EventArgs e)
        {
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
                ShowResult("error!", Win32.BeepType.Success);
                return;
            }

            bReadCodeState = true;
            timerUpdateListView.Enabled = true;
            revMsgLine.ClearMsg();

            ShowResult("start!", Win32.BeepType.Success);
            upButtonEnabled();

            readThread = new Thread(new ThreadStart(RevCodeMsgThread));
            readThread.Start();
        }

        void Reconnect()
        {
            while (true)
            {

                CloseConn();    // close
                bool bInit = false;
                if (rbnTCP.Checked)
                {
                    bInit = RfidApi.SAAT_TCPInit(out pHandle, sReaderIP, iReaderPoint);
                }
                else
                {
                    bInit = RfidApi.SAAT_COMInit(out pHandle, 0x00, cbxCom.SelectedItem.ToString(), 19200);
                }

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
                        LabelDisTig.Text = "Reconnect......";
                        Reconnect();
                        LabelDisTig.Text = "";
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
                if (i < listViewCard.Items.Count)
                {
                    listViewCard.Items[i].SubItems[2].Text = revMsgLine.Get(i).nRepeatTime.ToString();
                    listViewCard.Items[i].SubItems[4].Text = revMsgLine.Get(i).tLastTime.ToString("HH:mm:ss");
                }
                else
                {
                    listViewCard.Items.Add(i.ToString());
                    listViewCard.Items[i].SubItems.Add(revMsgLine.Get(i).sCodeData.ToString());
                    listViewCard.Items[i].SubItems.Add(revMsgLine.Get(i).nRepeatTime.ToString());
                    listViewCard.Items[i].SubItems.Add(revMsgLine.Get(i).tBeginTime.ToString("HH:mm:ss"));
                    listViewCard.Items[i].SubItems.Add(revMsgLine.Get(i).tLastTime.ToString("HH:mm:ss"));
                }
            }
        }


        private void btnStopReadCards_Click(object sender, EventArgs e)
        {
            timerUpdateListView.Enabled = false;

            if (readThread.IsAlive)
            {
                readThread.Abort();
                readThread.Join();
            }

            if (RfidApi.SAAT_YPowerOff(pHandle))
            {
                ShowResult("Ok!", Win32.BeepType.Success);
            }
            else
            {
                ShowResult("failure!" + CGetErrorMessage(), Win32.BeepType.Failure);
            }

            bReadCodeState = false;
            upButtonEnabled();
        }

        public string CGetErrorMessage()
        {
            byte[] btErrorMsg = new byte[255];
            string sErrorMsg = "";
            if (pHandle == IntPtr.Zero)
                sErrorMsg = "error";
            else
            {
                RfidApi.SAAT_GetErrorMessage(pHandle, btErrorMsg, 255);
                sErrorMsg = Encoding.Default.GetString(btErrorMsg);
            }
            return "error: " + sErrorMsg;
        }
        #endregion


        #region Exit 
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
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
            Application.Exit();
        }

        #endregion


        #region System Infomation
        private void btnLoadSysInfo_Click(object sender, EventArgs e)
        {

            string sCallback = "";

            for (byte i = 0; i <= 6; i++)
            {
                if (!GetSysInfo(i, ref sCallback, sSysInfoLen[i]))
                {
                    ShowResult("error", Win32.BeepType.Failure);
                    return;
                }
                sSysInfoBuf[i] = sCallback;
            }

            ShowResult("Ok", Win32.BeepType.Success);

            txtReaderName.Text = sSysInfoBuf[0];
            txtReaderType.Text = sSysInfoBuf[1];
            txtReaderSerial.Text = sSysInfoBuf[2];
            txtProcessVersion.Text = sSysInfoBuf[3];
            txtBaseHardVersion.Text = sSysInfoBuf[5];
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

        public void CSysSet(byte nType, string sValue)
        {
            byte[] btValue = Encoding.GetEncoding("gb2312").GetBytes(sValue.Trim());

            if (RfidApi.SAAT_SysInfSet(pHandle, nType, btValue, (byte)(btValue.Length)))
            {
                ShowResult("Ok", Win32.BeepType.Success);
            }
            else
            {
                ShowResult(CGetErrorMessage(), Win32.BeepType.Failure);
            }
        }

        private void btnSetReaderName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtReaderName.Text.Trim()))
            {
                ShowResult("error", Win32.BeepType.Failure);
                return;
            }
            CSysSet(0x0, txtReaderName.Text);
        }

        #endregion

        private void btnShowCopyright_Click(object sender, EventArgs e)
        {
            StringBuilder bCopyright = new StringBuilder();
            RfidApi.SAAT_Copyright(out pHandle, bCopyright);
            ShowResult(bCopyright.ToString(), Win32.BeepType.Success);
        }

        private void btnIOOperate_Click(object sender, EventArgs e)
        {
            if (cbxPort.SelectedIndex < 0) { ShowResult("select a IO port", Win32.BeepType.Failure); return; }
            if (cbxState.SelectedIndex < 0) { ShowResult("Please select the output state value", Win32.BeepType.Failure); return; }

            string sResult = RfidApi.SAAT_IOOperate(pHandle, (byte)cbxPort.SelectedIndex, (byte)cbxState.SelectedIndex) ? "success" : "failure";
            ShowResult(sResult, Win32.BeepType.Success);

        }



    }
}