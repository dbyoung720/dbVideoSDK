unit db.VideoSDK;
{
  ����(Func)��High speed video processing
  ����(Auth)��dbyoung@sina.com
  ʱ��(Time)��2020-10-01
  �汾(Vers): v2.0
}

interface

var
  dbVideo_Init                : procedure; stdcall;                                         { ��ʼ�� SDK }
  dbVideo_Free                : procedure; stdcall;                                         { ж�� SDK }
  dbVideo_EnumVideoInputDevice: function: PAnsiChar; stdcall;                               { ö����Ƶ�����豸�б������� ���ֺŸ��� }
  dbVideo_EnumVideoFormat     : function(const intVideoIndex: Integer): PAnsiChar; stdcall; { ö����Ƶ�����豸֧�ֵ���Ƶ��ʽ�б������� ���ֺŸ��� }
  {
    ��ƵԤ����ʼ
    ����˵����
    intVideoInputIndex  ����Ƶ�����豸������
    intVideoFormatIndex ����Ƶ�����ʽ������
    hVideo              ����Ƶ��ʾ��������
  }
  dbVideo_PreviewStart: function(const intVideoInputIndex: Integer; const intVideoFormatIndex: Integer; const hVideo: THandle): Boolean; stdcall;  { ��ƵԤ����ʼ }
  dbVideo_PreviewStop : function: Boolean; stdcall;                                                                                                { ��ƵԤ������ }
  dbVideo_SnapBmp     : procedure(hbmp: THandle; const bHD: Boolean = False); stdcall;                                                             { ��Ƶ��ͼ }
  dbVideo_ShowAttr    : procedure(); stdcall;                                                                                                      { ��Ƶ���� }
  dbVideo_TY          : procedure; stdcall;                                                                                                        { ��ƵͿѻ }
  dbVideo_TY_Clear    : procedure; stdcall;                                                                                                        { �����ƵͿѻ }
  dbVideo_GetNativeIP : function: PAnsiChar; stdcall;                                                                                              { ��ȡ����IP }
  dbVideo_RecordMP4   : function(const bRecord: Boolean; const strSaveFileName: PAnsiChar = nil; const iHwAccType: Integer = 0): Boolean; stdcall; { MP4 ¼�� }
  dbVideo_LiveRTMP    : function(const bLive: Boolean; const strUrl: PAnsiChar = nil; const iHwAccType: Integer = 0): Boolean; stdcall;            { RTMP ���� }
  dbVideo_ShowStyle   : procedure(const intStyle: Integer = 0); stdcall;                                                                           { ��Ƶ��ʾ��� }
  dbVideo_DeNoiseStyle: procedure(const intStyle: Integer = 0); stdcall;                                                                           { ��Ƶ�������� }
  dbVideo_ShowLogo    : procedure(const bShowLogo: Boolean; const strPngFileName: PAnsiChar = nil); stdcall;                                       { ��ʾ PNG LOGO }
  dbVideo_FaceCheck   : procedure(const bFaceCheck: Boolean); stdcall;                                                                             { ������� }

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
