unit db.VideoSDK;
{
  功能(Func)：High speed video processing
  作者(Auth)：dbyoung@sina.com
  时间(Time)：2020-10-01
  版本(Vers): v2.0
}

interface

var
  dbVideo_Init                : procedure; stdcall;                                         { 初始化 SDK }
  dbVideo_Free                : procedure; stdcall;                                         { 卸载 SDK }
  dbVideo_EnumVideoInputDevice: function: PAnsiChar; stdcall;                               { 枚举视频输入设备列表；名称以 ；分号隔开 }
  dbVideo_EnumVideoFormat     : function(const intVideoIndex: Integer): PAnsiChar; stdcall; { 枚举视频输入设备支持的视频格式列表；名称以 ；分号隔开 }
  {
    视频预览开始
    参数说明：
    intVideoInputIndex  ：视频输入设备索引；
    intVideoFormatIndex ：视频输入格式索引；
    hVideo              ：视频显示窗体句柄；
  }
  dbVideo_PreviewStart: function(const intVideoInputIndex: Integer; const intVideoFormatIndex: Integer; const hVideo: THandle): Boolean; stdcall;  { 视频预览开始 }
  dbVideo_PreviewStop : function: Boolean; stdcall;                                                                                                { 视频预览结束 }
  dbVideo_SnapBmp     : procedure(hbmp: THandle; const bHD: Boolean = False); stdcall;                                                             { 视频截图 }
  dbVideo_ShowAttr    : procedure(); stdcall;                                                                                                      { 视频属性 }
  dbVideo_TY          : procedure; stdcall;                                                                                                        { 视频涂鸦 }
  dbVideo_TY_Clear    : procedure; stdcall;                                                                                                        { 清除视频涂鸦 }
  dbVideo_GetNativeIP : function: PAnsiChar; stdcall;                                                                                              { 获取本机IP }
  dbVideo_RecordMP4   : function(const bRecord: Boolean; const strSaveFileName: PAnsiChar = nil; const iHwAccType: Integer = 0): Boolean; stdcall; { MP4 录制 }
  dbVideo_LiveRTMP    : function(const bLive: Boolean; const strUrl: PAnsiChar = nil; const iHwAccType: Integer = 0): Boolean; stdcall;            { RTMP 推流 }
  dbVideo_ShowStyle   : procedure(const intStyle: Integer = 0); stdcall;                                                                           { 视频显示风格 }
  dbVideo_DeNoiseStyle: procedure(const intStyle: Integer = 0); stdcall;                                                                           { 视频降噪类型 }
  dbVideo_ShowLogo    : procedure(const bShowLogo: Boolean; const strPngFileName: PAnsiChar = nil); stdcall;                                       { 显示 PNG LOGO }
  dbVideo_FaceCheck   : procedure(const bFaceCheck: Boolean); stdcall;                                                                             { 人脸检测 }

implementation

uses Winapi.Windows, System.SysUtils;

var
  FhDll: HMODULE;

procedure InitVideoSDK;
var
  strPath: String;
begin
  strPath := ExtractFilePath(Paramstr(0)) + 'dbVideo';
  SetDllDirectory(PChar(strPath));
  FhDll := LoadLibrary('dbVideo.dll');

  dbVideo_Init                 := GetProcAddress(FhDll, 'dbVideo_Init');
  dbVideo_Free                 := GetProcAddress(FhDll, 'dbVideo_Free');
  dbVideo_EnumVideoInputDevice := GetProcAddress(FhDll, 'dbVideo_EnumVideoInputDevice');
  dbVideo_EnumVideoFormat      := GetProcAddress(FhDll, 'dbVideo_EnumVideoFormat');
  dbVideo_PreviewStart         := GetProcAddress(FhDll, 'dbVideo_PreviewStart');
  dbVideo_PreviewStop          := GetProcAddress(FhDll, 'dbVideo_PreviewStop');
  dbVideo_SnapBmp              := GetProcAddress(FhDll, 'dbVideo_SnapBmp');
  dbVideo_ShowAttr             := GetProcAddress(FhDll, 'dbVideo_ShowAttr');
  dbVideo_TY                   := GetProcAddress(FhDll, 'dbVideo_TY');
  dbVideo_TY_Clear             := GetProcAddress(FhDll, 'dbVideo_TY_Clear');
  dbVideo_GetNativeIP          := GetProcAddress(FhDll, 'dbVideo_GetNativeIP');
  dbVideo_RecordMP4            := GetProcAddress(FhDll, 'dbVideo_RecordMP4');;
  dbVideo_LiveRTMP             := GetProcAddress(FhDll, 'dbVideo_LiveRTMP');;
  dbVideo_ShowStyle            := GetProcAddress(FhDll, 'dbVideo_ShowStyle');
  dbVideo_ShowLogo             := GetProcAddress(FhDll, 'dbVideo_ShowLogo');
  dbVideo_FaceCheck            := GetProcAddress(FhDll, 'dbVideo_FaceCheck');
  
  dbVideo_Init;
end;

procedure FreeVideoSDK;
begin
  dbVideo_Free;
  FreeLibrary(FhDll);
end;

initialization
  InitVideoSDK;

finalization
  FreeVideoSDK;

end.
