////////////////////////////////////////////////////////////////////////
// Module:  RFIDEXPORT.h
// Author:  cxm owen
// Modified: 
// Purpose: 
////////////////////////////////////////////////////////////////////////
#pragma once

#ifndef  _RFIDEXPORT_H
#define  _RFIDEXPORT_H
#define  STDCALL __stdcall

#ifdef RFIDAPI_EXPORTS
#define RFID_API __declspec( dllexport )
#else
#define RFID_API __declspec( dllimport )
#endif

#ifdef __cplusplus
extern "C" {
#endif


	
	bool RFID_API STDCALL SAAT_Copyright(void** pHandle, char* copyright);

	bool RFID_API STDCALL SAAT_TCPInit(void** pHandle,char *pHostName,int nsocketPort);

	bool RFID_API STDCALL SAAT_COMInit(void** pHandle,unsigned char nBusAddr,char *pComNum,int nBaud );

	bool RFID_API __stdcall SAAT_USBInit(void** pHandle,unsigned char nBusAddr,char * pUSBNum,int nBaud );

	bool RFID_API __stdcall SAAT_UDPInit(void** pHandle,char *pHostName,int nsocketPort);

	bool RFID_API  STDCALL SAAT_Open(void* pHandle);

	bool RFID_API  STDCALL SAAT_Close(void *pHandle);

	bool RFID_API  __stdcall SAAT_SetLanguageType (void* pHandle,char* szType);

	bool RFID_API  STDCALL SAAT_GetErrorMessage(void *pHandle,char *szMsg, int nLen);

	bool RFID_API  STDCALL SAAT_GetErrorCode(void *pHandle,int *pCode);

	bool RFID_API  __stdcall SAAT_Reconnect(void* pHandle);

	bool RFID_API  STDCALL SAAT_HeartSend (void* pHandle);


	bool RFID_API  STDCALL SAAT_SysInfSet (void* pHandle, unsigned char nType, unsigned char* pParm, int nLen);

	bool RFID_API  STDCALL SAAT_SysInfQuery (void* pHandle ,unsigned char nType, unsigned char *pPara, unsigned char *pLen);

	bool RFID_API  __stdcall SAAT_WorkModeSet (void* pHandle ,unsigned char nType);

	bool RFID_API  STDCALL SAAT_SysTest(void* pHandle ,
		unsigned char nType,
		unsigned char nAntenna, 
		unsigned char *pTestParm, 
		unsigned char nLen);

	bool RFID_API  STDCALL SAAT_ParmOp (void* pHandle ,
		unsigned char nType, 
		unsigned char nStartAddrr, 
		unsigned char nLen,  
		unsigned char *pData, 
		unsigned char *pDataLen);

	bool RFID_API  STDCALL SAAT_CommunicatParaSet (void* pHandle ,
		unsigned char nType, 
		unsigned char* pPara, 
		unsigned char nLen);

	bool RFID_API  STDCALL SAAT_CommunicatParaQuery (void* pHandle ,
		unsigned char nType, 
		unsigned char* pPara,
		unsigned char *pLen);

	bool RFID_API  STDCALL SAAT_NetParaSet (void* pHandle ,
		unsigned char nType, 
		unsigned char* pPara, 
		unsigned char nLen);

	bool RFID_API  STDCALL SAAT_NetParaQuery (void* pHandle ,
		int nType, 
		unsigned char* pPara,
		unsigned char *pLen);

	bool RFID_API  STDCALL SAAT_TagOpParaSet(void* pHandle ,
		unsigned char nType, 
		unsigned char *pPara,
		unsigned char nLen);

	bool RFID_API STDCALL SAAT_TagOpParaQuery(void* pHandle ,
		unsigned char nType, unsigned char* pPara, unsigned char *pLen);

	bool RFID_API  STDCALL SAAT_TotalAntennaParmQuery (void* pHandle,unsigned char *szAntennaPara,unsigned char *pLen);

	bool RFID_API  STDCALL SAAT_PowerOff(void *pHandle);

	bool RFID_API  STDCALL SAAT_YPowerOff(void *pHandle);

	bool RFID_API  STDCALL SAAT_IOOperate(void* pHandle,unsigned char nPort,unsigned char nState);

	bool RFID_API  STDCALL SAAT_IOStateQuery(void* pHandle,unsigned char *pState);

	bool RFID_API  STDCALL SAAT_YReadIDCode ( void *pHandle,
		unsigned char nOpType,
		unsigned char nIDType,
		unsigned int nTagCount);

	bool RFID_API  STDCALL SAAT_YMakeTagUpLoadIDCode ( void *pHandle,
		unsigned char nOpType,
		unsigned char nIDType);

	bool  RFID_API  STDCALL SAAT_YEASRegSet (void *pHandle, 
		unsigned char nOpType, 
		unsigned char nIDType, 
		unsigned char *pCodeID,
		unsigned char *pTagPwd,
		unsigned char nSetMode,
		unsigned char nFlagBit);

	bool  RFID_API  STDCALL SAAT_YEASRegQuery (void *pHandle, 
		unsigned char nOpType, 
		unsigned char nIDType, 
		unsigned char *pIDCode,
		unsigned char *pTagPwd,
		unsigned char *pIDType,
		unsigned char *pEASIDCode,
		unsigned char *pFlagBit);

	bool  RFID_API  STDCALL SAAT_YEASMonitorEnable (void *pHandle,
		unsigned char nOpType, 
		unsigned char nIDType,
		unsigned char nEasBit);

	int  RFID_API  STDCALL SAAT_YRevEASIDMsg (void *pHandle, unsigned char* pIDData,
		unsigned char* pIDLen,
		unsigned char* pBit);

	bool RFID_API  STDCALL SAAT_YAntennaPowerSet (void* pHandle,unsigned char nPower );

	bool RFID_API  STDCALL SAAT_YAntennaPowerQuery (void* pHandle,unsigned char* pPower);

	bool RFID_API  STDCALL  SAAT_YWriteEIDCode ( void* pHandle, 
		unsigned char nOpMode,
		unsigned char* pIDCode,
		unsigned char *pAccessPWD, 
		unsigned char *pWriteEIDData);

	bool RFID_API  __stdcall SAAT_YReadUserData ( void* pHandle, 
		unsigned char nOpMode, 
		unsigned char nIDCodeType,
		unsigned char *pIDCode,
		unsigned char *pTagPwd,
		unsigned char nBank,
		unsigned char nStartAddr,
		unsigned char *pReadData,
		int *pReadLen,
		unsigned int nWaitTime = 1000);

	bool RFID_API  __stdcall SAAT_YWriteUserData ( void* pHandle, 
		unsigned char nOpMode, 
		unsigned char nIDCodeType,
		unsigned char *pIDCode,
		unsigned char *pTagPwd,
		unsigned char nBank,
		unsigned char nStartAddr,
		unsigned char *pWriteData,
		int nWriteLen,
		unsigned int nWaitTime = 1000);

	bool RFID_API  STDCALL SAAT_YAccessPWDSet (void *pHandle,
		unsigned char nOpMode, 
		unsigned char nIDType,
		unsigned char *pIDCode,
		unsigned char *pOrgPWD, 
		unsigned char *pNewPWD);

	bool RFID_API  STDCALL SAAT_YCFGPWDSet (void *pHandle,
		unsigned char nOpMode, 
		unsigned char nIDType,
		unsigned char *pIDCode,
		unsigned char *pOrgPWD, 
		unsigned char *pNewPWD);

	bool RFID_API  STDCALL SAAT_YTagOp(void *pHandle,
		unsigned char nOpMode, 
		unsigned char nIDType,
		unsigned char *pIDCode,
		unsigned char *pTagPWD, 
		unsigned char nTagOpType,
		unsigned short nStartAddr,
		unsigned char nDataLen);

	bool  RFID_API  STDCALL SAAT_YTagParmSet (void *pHandle, 
		unsigned char nOpType, 
		unsigned char nIDType, 
		unsigned char *pIDCode,
		unsigned char *pTagPwd,
		unsigned char nAntennaPower,
		unsigned char nAntennaFrequency,
		unsigned char nHoppingMode);

	bool  RFID_API  STDCALL SAAT_YTagParmQuery (void *pHandle, 
		unsigned char nOpType, 
		unsigned char nIDType, 
		unsigned char *pIDCode,
		unsigned char *nTagPwd,
		unsigned char *pAntennaPower,
		unsigned char *pAntennaFrequency,
		unsigned char *pHoppingMode);

	bool  RFID_API  STDCALL SAAT_YTagWorkModeSet (void *pHandle, 
		unsigned char nOpType, 
		unsigned char nIDType, 
		unsigned char *pIDCode,
		unsigned char *pTagPwd,
		unsigned char nWorkMode,
		unsigned char nUpLoadIDType,
		unsigned short nSleepTime,
		unsigned char nSleepInterval);

	bool  RFID_API  STDCALL SAAT_YTagWorkModeQuery (void *pHandle, 
		unsigned char nOpType, 
		unsigned char nIDType, 
		unsigned char *pIDCode,
		unsigned char *pTagPwd,
		unsigned char *pWorkMode,
		unsigned char *pUpLoadIDType,
		unsigned short *pSleepTime,
		unsigned char *pSleepInterval,
		unsigned char *pBatteryVoltage,
		unsigned char *pRemainingCapacity);

	bool  RFID_API  STDCALL SAAT_YTagFatorySet (void *pHandle, 
		unsigned char nOpType, 
		unsigned char nIDType, 
		unsigned char *pIDCode,
		unsigned char *pTagPwd,
		unsigned char nTagType,
		unsigned char nHardWareVersion,
		unsigned char nSoftWareVersion,
		unsigned char nBatteryConfiguration,
		unsigned char nNominalCapacity);

	bool  RFID_API  STDCALL SAAT_YTagFatoryQuery (void *pHandle, 
		unsigned char nOpType, 
		unsigned char nIDType, 
		unsigned char *pIDCode,
		unsigned char *pTagPwd,
		unsigned char *pTagType,
		unsigned char *pHardWareVersion,
		unsigned char *pSoftWareVersion,
		unsigned char *pBatteryConfiguration,
		unsigned char *pNominalCapacity);

	bool  RFID_API  STDCALL SAAT_YTagResetToFatory (void *pHandle, 
		unsigned char nOpType, 
		unsigned char nIDType, 
		unsigned char *pIDCode,
		unsigned char *nTagPwd);

	bool RFID_API  STDCALL SAAT_YAntennaParmSet(void* pHandle ,unsigned char *pPara,unsigned char nLen );

	bool RFID_API  STDCALL SAAT_YAntennaParmQuery(void* pHandle,
		unsigned char *pPowerRecvPlus,
		unsigned char *p2401FreqSendPwr,
		unsigned char *pAttenuatorPower);

	bool RFID_API  STDCALL SAAT_YRFParaSet (void* pHandle ,
		unsigned char nType, 
		unsigned char nPara);

	bool RFID_API  STDCALL SAAT_YRFParaQuery (void* pHandle ,
		unsigned char nType,
		unsigned char* pPara);

	bool RFID_API  STDCALL SAAT_YCarrierWaveOp(void* pHandle ,unsigned char nType);

	bool RFID_API  STDCALL SAAT_YBuzzerSet (void* pHandle , unsigned char nPara);

	bool RFID_API  STDCALL SAAT_YBuzzerQuery (void* pHandle ,	unsigned char* pPara);

	int RFID_API  STDCALL SAAT_YRevIDMsgDec(void *pHandle, unsigned int* pId, unsigned char* nBit);

	int RFID_API  STDCALL SAAT_YRevIDMsgHex(void *pHandle, 
		unsigned char* pIDData,
		unsigned char* nIDLen, 
		unsigned char* nBit);

	bool RFID_API STDCALL SAAT_SetLangId(void *pHandle, unsigned char nLangId);

	bool RFID_API  STDCALL SAAT_RawSendData(void* pHandle , unsigned char *pSendData, unsigned char nLen); 

	bool RFID_API  STDCALL SAAT_RawRevData(void* pHandle , unsigned char *pRecvData, unsigned char* pLen,int nWaitTime); 

	bool RFID_API  STDCALL SAAT_RawSendAndRevData(void* pHandle , 
		unsigned char *pSendData,
		unsigned char nLen,
		unsigned char *pRecvData,
		unsigned char *pLen,
		unsigned char nWaitTime); 

	bool RFID_API  STDCALL SAAT_SetReaderTime (void* pHandle ,unsigned char* pPara,unsigned char nLen);

	bool RFID_API  STDCALL SAAT_ReaderTimeQuery (void* pHandle, unsigned char* pPara, unsigned char *pLen);

	bool RFID_API  STDCALL SAAT_FlashTotalCountQuery (void* pHandle ,
		unsigned char* pPara,
		unsigned char *pLen);

	bool RFID_API  STDCALL SAAT_FlashDataQuery (void* pHandle ,
		unsigned char nOpType,
		unsigned char* pPara,
		unsigned char *pLen);

	bool RFID_API STDCALL SAAT_ClearFlash (void* pHandle );

	bool RFID_API STDCALL SAAT_WCommunicatParaSet (void* pHandle ,unsigned char nType, unsigned char* pPara, unsigned char nLen);

	bool RFID_API STDCALL SAAT_WCommunicatParaQuery (void* pHandle ,unsigned char nType, unsigned char* pPara,unsigned char *pLen);

	bool RFID_API STDCALL SAAT_Reboot(void* pHandle ,unsigned char nType);

	bool RFID_API  __stdcall SAAT_YTagSelect ( void *pHandle, unsigned char nOpEnable, unsigned char nMatchType, unsigned char *MatchData, unsigned char nLenth);

	bool RFID_API STDCALL SAAT_EnterTrans(void* pHandle ,unsigned char nType);

	bool RFID_API STDCALL SAAT_ResetWifiBaund(void* pHandle);

	int RFID_API STDCALL SAAT_YRevIDMsgDecExpand(void *pHandle,unsigned char* nTagType,unsigned int* pId,unsigned char* pBit, unsigned char* nParam1, unsigned char* nParam2);

	int RFID_API  STDCALL SAAT_YRevIDMsgHexExpand(void *pHandle, unsigned char* nTagType, unsigned char* pIDData, unsigned char* nIDLen, unsigned char* nBit, unsigned char* nParam1, unsigned char* nParam2);

	bool RFID_API STDCALL SAAT_GCommunicatParaSet (void* pHandle ,unsigned char nType, unsigned char* pPara, unsigned char nLen);

	bool RFID_API STDCALL SAAT_GCommunicatParaQuery (void* pHandle ,unsigned char nType, unsigned char* pPara,unsigned char *pLen);

	bool RFID_API STDCALL SAAT_SendTrans(void* pHandle,unsigned char nType,unsigned char* pData,unsigned char nLen);

	bool RFID_API STDCALL SAAT_RecvTrans(void* pHandle,unsigned char nType,unsigned char *pData,unsigned char* pLen);

	bool RFID_API STDCALL SAAT_ModuleReboot(void* pHandle ,unsigned char nType);


#ifdef __cplusplus
}
#endif


#endif