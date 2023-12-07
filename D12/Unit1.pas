unit Unit1;

interface

uses
  Winapi.Windows, Winapi.Messages, System.SysUtils, System.StrUtils, System.Variants, System.Classes, System.DateUtils,
  Vcl.Graphics, Vcl.Controls, Vcl.Forms, Vcl.Dialogs, Vcl.StdCtrls, Vcl.ExtCtrls, Vcl.WinXCtrls, Vcl.Menus;

type
  TfrmVideo = class(TForm)
    grpVideoList: TGroupBox;
    cbbVideoList: TComboBox;
    grpVideoFormat: TGroupBox;
    cbbVideoFormat: TComboBox;
    pnlVideoPreview: TPanel;
    grpFunc: TGroupBox;
    lblHardAccel: TLabel;
    lblDisplayStyle: TLabel;
    btnVideoPreviewStart: TButton;
    btnVideoPreviewStop: TButton;
    btnVideoSnap: TButton;
    btnVideoTY: TButton;
    pnlSnap: TPanel;
    btnVideoAttr: TButton;
    chkMP4: TCheckBox;
    chkRTMP: TCheckBox;
    srchbxMP4SavePath: TSearchBox;
    edtRTMPAddress: TEdit;
    cbbHardAccel: TComboBox;
    chkLogo: TCheckBox;
    cbbDisplayStyle: TComboBox;
    btnClearTY: TButton;
    pmSnap: TPopupMenu;
    N1: TMenuItem;
    mniHDSnap: TMenuItem;
    chkFace: TCheckBox;
    procedure cbbVideoListChange(Sender: TObject);
    procedure FormCreate(Sender: TObject);
    procedure btnVideoPreviewStartClick(Sender: TObject);
    procedure btnVideoPreviewStopClick(Sender: TObject);
    procedure btnVideoSnapClick(Sender: TObject);
    procedure btnVideoAttrClick(Sender: TObject);
    procedure FormDestroy(Sender: TObject);
    procedure btnVideoTYClick(Sender: TObject);
    procedure chkMP4Click(Sender: TObject);
    procedure chkRTMPClick(Sender: TObject);
    procedure cbbDisplayStyleChange(Sender: TObject);
    procedure chkLogoClick(Sender: TObject);
    procedure srchbxMP4SavePathInvokeSearch(Sender: TObject);
    procedure btnClearTYClick(Sender: TObject);
    procedure mniHDSnapClick(Sender: TObject);
    procedure chkFaceClick(Sender: TObject);
  private
    procedure EnableUI;
  end;

var
  frmVideo: TfrmVideo;

implementation

uses db.VideoSDK;

{$R *.dfm}

procedure TfrmVideo.FormCreate(Sender: TObject);
var
  strName : String;
  strValue: TArray<string>;
begin
  strValue := String(AnsiString(dbVideo_EnumVideoInputDevice)).Split([';']);
  for strName In strValue do
    cbbVideoList.Items.Add(strName);

  if cbbVideoList.Items.Count > 0 then
  begin
    cbbVideoList.ItemIndex := 0;
    cbbVideoList.OnChange(nil);
  end;

  srchbxMP4SavePath.Text := Format('D:\%s.MP4', [FormatDateTime('yyyyMMddhhmm', Now)]);
  edtRTMPAddress.Text    := 'rtmp://' + dbVideo_GetNativeIP + ':1935/live';
end;

procedure TfrmVideo.FormDestroy(Sender: TObject);
begin
  dbVideo_PreviewStop;
end;

procedure TfrmVideo.srchbxMP4SavePathInvokeSearch(Sender: TObject);
begin
  //
end;

procedure TfrmVideo.cbbDisplayStyleChange(Sender: TObject);
begin
  dbVideo_ShowStyle(cbbDisplayStyle.ItemIndex);
end;

procedure TfrmVideo.cbbVideoListChange(Sender: TObject);
var
  strName : String;
  strValue: TArray<string>;
begin
  btnVideoPreviewStart.Enabled := False;
  try
    cbbVideoFormat.Clear;
    strValue := string(AnsiString(dbVideo_EnumVideoFormat(cbbVideoList.ItemIndex))).Split([';']);
    cbbVideoFormat.Items.BeginUpdate;
    for strName In strValue do
      cbbVideoFormat.Items.Add(strName);
    cbbVideoFormat.Items.EndUpdate;

    if cbbVideoFormat.Items.Count > 0 then
      cbbVideoFormat.ItemIndex := 0;
  finally
    btnVideoPreviewStart.Enabled := True;
  end;
end;

procedure TfrmVideo.chkFaceClick(Sender: TObject);
begin
  dbVideo_FaceCheck(chkFace.Checked);
end;

procedure TfrmVideo.chkLogoClick(Sender: TObject);
begin
  dbVideo_ShowLogo(chkLogo.Checked, PAnsiChar(AnsiString(ExtractFilePath(ParamStr(0)) + 'logo.png')));
end;

procedure TfrmVideo.chkMP4Click(Sender: TObject);
begin
  if Trim(srchbxMP4SavePath.Text) = '' then
    Exit;

  srchbxMP4SavePath.Enabled := not chkMP4.Checked;
  dbVideo_RecordMP4(chkMP4.Checked, PAnsiChar(AnsiString(srchbxMP4SavePath.Text)), cbbHardAccel.ItemIndex);
end;

procedure TfrmVideo.chkRTMPClick(Sender: TObject);
begin
  if Trim(edtRTMPAddress.Text) = '' then
    Exit;

  edtRTMPAddress.Enabled := not chkRTMP.Checked;
  dbVideo_LiveRTMP(chkRTMP.Checked, PAnsiChar(AnsiString(edtRTMPAddress.Text)), cbbHardAccel.ItemIndex);
end;

procedure TfrmVideo.EnableUI;
begin
  cbbVideoList.Enabled      := btnVideoPreviewStart.Enabled;
  cbbVideoFormat.Enabled    := btnVideoPreviewStart.Enabled;
  cbbDisplayStyle.Enabled   := not btnVideoPreviewStart.Enabled;
  lblDisplayStyle.Enabled   := not btnVideoPreviewStart.Enabled;
  lblHardAccel.Enabled      := not btnVideoPreviewStart.Enabled;
  cbbHardAccel.Enabled      := not btnVideoPreviewStart.Enabled;
  chkMP4.Enabled            := not btnVideoPreviewStart.Enabled;
  chkRTMP.Enabled           := not btnVideoPreviewStart.Enabled;
  edtRTMPAddress.Enabled    := not btnVideoPreviewStart.Enabled;
  btnVideoSnap.Enabled      := not btnVideoPreviewStart.Enabled;
  btnVideoTY.Enabled        := not btnVideoPreviewStart.Enabled;
  btnClearTY.Enabled        := not btnVideoPreviewStart.Enabled;
  btnVideoAttr.Enabled      := not btnVideoPreviewStart.Enabled;
  srchbxMP4SavePath.Enabled := not btnVideoPreviewStart.Enabled;
  chkLogo.Enabled           := not btnVideoPreviewStart.Enabled;
  chkFace.Enabled           := not btnVideoPreviewStart.Enabled;
end;

procedure TfrmVideo.btnVideoPreviewStartClick(Sender: TObject);
begin
  btnVideoPreviewStart.Enabled := False;
  Application.ProcessMessages;

  btnVideoPreviewStart.Enabled := not dbVideo_PreviewStart(cbbVideoList.ItemIndex, cbbVideoFormat.ItemIndex, pnlVideoPreview.Handle);
  btnVideoPreviewStop.Enabled  := not btnVideoPreviewStart.Enabled;
  EnableUI;
end;

procedure TfrmVideo.btnVideoPreviewStopClick(Sender: TObject);
begin
  btnVideoPreviewStop.Enabled := False;
  Application.ProcessMessages;

  btnVideoPreviewStop.Enabled  := not dbVideo_PreviewStop;
  btnVideoPreviewStart.Enabled := not btnVideoPreviewStop.Enabled;
  EnableUI;
  cbbDisplayStyle.ItemIndex := 0;
  cbbHardAccel.ItemIndex    := 0;
  chkMP4.Checked            := False;
  chkRTMP.Checked           := False;
  chkLogo.Checked           := False;
  chkFace.Checked           := False;
  pnlVideoPreview.Invalidate;
  pnlSnap.Invalidate;
end;

procedure TfrmVideo.btnVideoSnapClick(Sender: TObject);
begin
  dbVideo_SnapBmp(pnlSnap.Handle);
end;

procedure TfrmVideo.mniHDSnapClick(Sender: TObject);
begin
  dbVideo_SnapBmp(pnlSnap.Handle, True);
end;

procedure TfrmVideo.btnVideoTYClick(Sender: TObject);
begin
  dbVideo_TY;
end;

procedure TfrmVideo.btnClearTYClick(Sender: TObject);
begin
  dbVideo_TY_Clear;
end;

procedure TfrmVideo.btnVideoAttrClick(Sender: TObject);
begin
  dbVideo_ShowAttr();
end;

end.
