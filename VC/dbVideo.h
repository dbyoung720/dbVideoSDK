/*
  功能(Func)：High speed video processing
  作者(Auth)：dbyoung@sina.com
  时间(Time)：2023-10-01
  版本(Vers): v3.0
*/
#ifndef _DLL_DBVIDEO_H_
#define _DLL_DBVIDEO_H_

#include <Windows.h>
#include <Psapi.h>
#include <atlstr.h>
#include "Shlwapi.h"
#include <string>
#include <iostream>

#ifdef __cplusplus
extern "C" {
#endif

#ifdef DBVIDEO_EXPORTS
#define DBVIDEO_API __declspec(dllexport)
#else
#define DBVIDEO_API __declspec(dllimport)
#endif

typedef void  (WINAPI* DBVIDEOINIT)(); DBVIDEOINIT dbVideo_Init;
typedef void  (WINAPI* DBVIDEOFREE)(); DBVIDEOFREE dbVideo_Free;
typedef char* (WINAPI* DBVIDEOENUMVIDEOINPUTDEVICE)(); DBVIDEOENUMVIDEOINPUTDEVICE dbVideo_EnumVideoInputDevice;
typedef char* (WINAPI* DBVIDEOENUMVIDEOFORMAT)(const int intVideoIndex); DBVIDEOENUMVIDEOFORMAT dbVideo_EnumVideoFormat;
typedef char* (WINAPI* DBVIDEOPREVIEWSTART)(const int intVideoIndex, const int intVideoFormatIndex, HANDLE hVideo); DBVIDEOPREVIEWSTART dbVideo_PreviewStart;
typedef bool  (WINAPI* DBVIDEOPREVIEWSTOP)(); DBVIDEOPREVIEWSTOP dbVideo_PreviewStop;
typedef void  (WINAPI* DBVIDEOSNAPBMP)(HANDLE hbmp, const bool bHD); DBVIDEOSNAPBMP dbVideo_SnapBmp;
typedef bool  (WINAPI* DBVIDEOSHOWATTR)(); DBVIDEOSHOWATTR dbVideo_ShowAttr;
typedef bool  (WINAPI* DBVIDEOTY)(); DBVIDEOTY dbVideo_TY;
typedef void  (WINAPI* DBVIDEOTYCLEAR)(); DBVIDEOTYCLEAR dbVideo_TY_Clear;
typedef char* (WINAPI* DBVIDEOGETNATIVEIP)(); DBVIDEOGETNATIVEIP dbVideo_GetNativeIP;
typedef bool  (WINAPI* DBVIDEORECORDMP4)(const bool bRecord, const char* cSaveFileName, const int intHwAccType); DBVIDEORECORDMP4 dbVideo_RecordMP4;
typedef bool  (WINAPI* DBVIDEOLIVERTMP) (const bool bLive,   const char* cRTMPLiveURL,  const int intHwAccType); DBVIDEOLIVERTMP  dbVideo_LiveRTMP;
typedef void  (WINAPI* DBVIDEOSHOWSTYLE)(const int iStyle); DBVIDEOSHOWSTYLE dbVideo_ShowStyle;
typedef void  (WINAPI* DBVIDEODENOISESTYLE)(const int iStyle); DBVIDEODENOISESTYLE dbVideo_DeNoiseStyle;
typedef void  (WINAPI* DBVIDEOSHOWLOGO)(const bool bShowLogo, const char* PngFileName); DBVIDEOSHOWLOGO dbVideo_ShowLogo;
typedef void  (WINAPI* DBVIDEOCheckFace)(const bool bCheck); DBVIDEOCheckFace dbVideo_CheckFace;
typedef void  (WINAPI* DBVIDEOCheckROI)(const bool bCheck); DBVIDEOCheckROI dbVideo_CheckROI;
typedef void  (WINAPI* DBVIDEOCheckXR)(const bool bCheck); DBVIDEOCheckXR dbVideo_CheckXR;


HINSTANCE m_hinstLib; 

void InitVideoSDK()
{
    TCHAR Buffer[MAX_PATH + 1];
    HANDLE hProcess = OpenProcess(PROCESS_QUERY_INFORMATION | PROCESS_VM_READ, false, GetCurrentProcessId());
    GetModuleFileNameEx(hProcess, 0, Buffer, MAX_PATH);
    CloseHandle(hProcess);

    int nPos;
    CString subPath = CString("\\dbVideo");
    CString strPath = CString(Buffer);
    nPos = strPath.ReverseFind('\\');
    strPath  = strPath.Left(nPos);
    strPath += subPath;
    SetDllDirectory(strPath);
    
    m_hinstLib = LoadLibrary(TEXT("dbVideo.dll")); 
    if (m_hinstLib != NULL) 
    {
      dbVideo_Init                 = (DBVIDEOINIT)                 GetProcAddress(m_hinstLib, "dbVideo_Init");
      dbVideo_Free                 = (DBVIDEOFREE)                 GetProcAddress(m_hinstLib, "dbVideo_Free");
      dbVideo_EnumVideoInputDevice = (DBVIDEOENUMVIDEOINPUTDEVICE) GetProcAddress(m_hinstLib, "dbVideo_EnumVideoInputDevice");
      dbVideo_EnumVideoFormat      = (DBVIDEOENUMVIDEOFORMAT)      GetProcAddress(m_hinstLib, "dbVideo_EnumVideoFormat");
      dbVideo_PreviewStart         = (DBVIDEOPREVIEWSTART)         GetProcAddress(m_hinstLib, "dbVideo_PreviewStart");
      dbVideo_PreviewStop          = (DBVIDEOPREVIEWSTOP)          GetProcAddress(m_hinstLib, "dbVideo_PreviewStop");
      dbVideo_SnapBmp              = (DBVIDEOSNAPBMP)              GetProcAddress(m_hinstLib, "dbVideo_SnapBmp");
      dbVideo_ShowAttr             = (DBVIDEOSHOWATTR)             GetProcAddress(m_hinstLib, "dbVideo_ShowAttr");
      dbVideo_TY                   = (DBVIDEOTY)                   GetProcAddress(m_hinstLib, "dbVideo_TY");
      dbVideo_TY_Clear             = (DBVIDEOTYCLEAR)              GetProcAddress(m_hinstLib, "dbVideo_TY_Clear");
      dbVideo_GetNativeIP          = (DBVIDEOGETNATIVEIP)          GetProcAddress(m_hinstLib, "dbVideo_GetNativeIP");
      dbVideo_RecordMP4            = (DBVIDEORECORDMP4)            GetProcAddress(m_hinstLib, "dbVideo_RecordMP4");
      dbVideo_LiveRTMP             = (DBVIDEOLIVERTMP)             GetProcAddress(m_hinstLib, "dbVideo_LiveRTMP");
      dbVideo_ShowStyle            = (DBVIDEOSHOWSTYLE)            GetProcAddress(m_hinstLib, "dbVideo_ShowStyle");
      dbVideo_DeNoiseStyle         = (DBVIDEODENOISESTYLE)         GetProcAddress(m_hinstLib, "dbVideo_DeNoiseStyle");
      dbVideo_ShowLogo             = (DBVIDEOSHOWLOGO)             GetProcAddress(m_hinstLib, "dbVideo_ShowLogo");
      dbVideo_CheckFace            = (DBVIDEOCheckFace)            GetProcAddress(m_hinstLib, "dbVideo_CheckFace");
      dbVideo_CheckROI             = (DBVIDEOCheckROI)             GetProcAddress(m_hinstLib, "dbVideo_CheckROI");
      dbVideo_CheckXR              = (DBVIDEOCheckXR)              GetProcAddress(m_hinstLib, "dbVideo_CheckXR");

      dbVideo_Init();
    }
}
 
void FreeVideoSDK()
{
    dbVideo_Free();
    FreeLibrary(m_hinstLib);
}

#ifdef __cplusplus
}
#endif

#endif
