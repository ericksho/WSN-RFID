using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace Szaat.RFID.CSharpAPI
{
    public class RfidApi
    {
        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_Copyright")]
        public static extern bool SAAT_Copyright(out IntPtr pHandle, StringBuilder copyright);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_TCPInit")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_TCPInit(out IntPtr pHandle, string pHostName, int nsocketPort);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_COMInit")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_COMInit(out IntPtr pHandle, byte nBusAddr, string pComNum, int nBaud); 

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_Open")]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool SAAT_Open(IntPtr pHandle);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_Close")]
        public static extern bool SAAT_Close(IntPtr pHandle);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_SysInfSet")]
        public static extern bool SAAT_SysInfSet(IntPtr pHandle, byte nType, byte[] pParm, byte nLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_SysInfQuery")]
        public static extern bool SAAT_SysInfQuery(IntPtr pHandle, byte nType, IntPtr pPara, ref byte pLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_YPowerOff")]
        public static extern bool SAAT_YPowerOff(IntPtr pHandle);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_GetErrorMessage")]
        public static extern bool SAAT_GetErrorMessage(IntPtr pHandle, byte[] szMsg, int nLen);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_IOOperate")]
        public static extern bool SAAT_IOOperate(IntPtr pHandle, byte nPort, byte nState);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_IOStateQuery")]
        public static extern bool SAAT_IOStateQuery(IntPtr pHandle, ref byte pState);
        
        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_YMakeTagUpLoadIDCode")]
        public static extern bool SAAT_YMakeTagUpLoadIDCode(IntPtr pHandle, byte nOpType, byte nIDType);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_YRevIDMsgHex")]
        public static extern int SAAT_YRevIDMsgHex(IntPtr pHandle, byte[] pIDData, out byte nIDLen , out byte nBit);

        [DllImport("RFIDAPI.dll", EntryPoint = "SAAT_YRevIDMsgDec")]
        public static extern int SAAT_YRevIDMsgDec(IntPtr pHandle, out uint pId, out byte nBit);
        
    }
}