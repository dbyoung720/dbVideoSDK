object frmVideo: TfrmVideo
  Left = 0
  Top = 0
  Caption = 'dbVideo 2.0'
  ClientHeight = 666
  ClientWidth = 1085
  Color = clBtnFace
  Font.Charset = GB2312_CHARSET
  Font.Color = clWindowText
  Font.Height = -12
  Font.Name = #23435#20307
  Font.Style = []
  OldCreateOrder = True
  Position = poScreenCenter
  OnCreate = FormCreate
  OnDestroy = FormDestroy
  DesignSize = (
    1085
    666)
  PixelsPerInch = 96
  TextHeight = 12
  object grpVideoList: TGroupBox
    Left = 8
    Top = 8
    Width = 285
    Height = 53
    Caption = #35270#39057#35774#22791#21015#34920#65306
    ParentShowHint = False
    ShowHint = False
    TabOrder = 0
    object cbbVideoList: TComboBox
      Left = 12
      Top = 20
      Width = 261
      Height = 20
      Style = csDropDownList
      TabOrder = 0
      OnChange = cbbVideoListChange
    end
  end
  object grpVideoFormat: TGroupBox
    Left = 299
    Top = 8
    Width = 778
    Height = 53
    Anchors = [akLeft, akTop, akRight]
    Caption = #35270#39057#26684#24335#21015#34920#65306
    ParentShowHint = False
    ShowHint = False
    TabOrder = 1
    DesignSize = (
      778
      53)
    object cbbVideoFormat: TComboBox
      Left = 12
      Top = 20
      Width = 754
      Height = 22
      Style = csDropDownList
      Anchors = [akLeft, akTop, akRight]
      DropDownCount = 40
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -14
      Font.Name = #23435#20307
      Font.Style = []
      ParentFont = False
      TabOrder = 0
    end
  end
  object pnlVideoPreview: TPanel
    Left = 299
    Top = 72
    Width = 778
    Height = 586
    Anchors = [akLeft, akTop, akRight, akBottom]
    BevelOuter = bvNone
    Caption = 'pnlVideoPreview'
    Color = clWhite
    Ctl3D = False
    DoubleBuffered = True
    ParentBackground = False
    ParentCtl3D = False
    ParentDoubleBuffered = False
    ShowCaption = False
    TabOrder = 2
  end
  object grpFunc: TGroupBox
    Left = 8
    Top = 72
    Width = 285
    Height = 586
    Anchors = [akLeft, akTop, akBottom]
    Ctl3D = True
    Font.Charset = GB2312_CHARSET
    Font.Color = clWindowText
    Font.Height = -12
    Font.Name = #23435#20307
    Font.Style = []
    ParentCtl3D = False
    ParentFont = False
    TabOrder = 3
    DesignSize = (
      285
      586)
    object lblHardAccel: TLabel
      Left = 12
      Top = 202
      Width = 132
      Height = 12
      Caption = 'MP4 '#30828#20214#21152#36895#32534#30721#31867#22411#65306
      Enabled = False
      ParentShowHint = False
      ShowHint = False
    end
    object lblDisplayStyle: TLabel
      Left = 12
      Top = 149
      Width = 60
      Height = 12
      Caption = #26174#31034#25928#26524#65306
      Enabled = False
      ParentShowHint = False
      ShowHint = False
    end
    object btnVideoPreviewStart: TButton
      Left = 12
      Top = 16
      Width = 116
      Height = 33
      Caption = #35270#39057#39044#35272
      ParentShowHint = False
      ShowHint = False
      TabOrder = 0
      OnClick = btnVideoPreviewStartClick
    end
    object btnVideoPreviewStop: TButton
      Left = 157
      Top = 16
      Width = 116
      Height = 33
      Caption = #39044#35272#20572#27490
      Enabled = False
      ParentShowHint = False
      ShowHint = False
      TabOrder = 1
      OnClick = btnVideoPreviewStopClick
    end
    object btnVideoSnap: TButton
      Left = 12
      Top = 60
      Width = 116
      Height = 33
      Caption = #35270#39057#25130#22270
      DropDownMenu = pmSnap
      Enabled = False
      ParentShowHint = False
      ShowHint = False
      Style = bsSplitButton
      TabOrder = 2
      OnClick = btnVideoSnapClick
    end
    object btnVideoTY: TButton
      Left = 12
      Top = 104
      Width = 116
      Height = 33
      Caption = #35270#39057#28034#40486
      Enabled = False
      ParentShowHint = False
      ShowHint = False
      TabOrder = 3
      OnClick = btnVideoTYClick
    end
    object pnlSnap: TPanel
      Left = 12
      Top = 368
      Width = 261
      Height = 209
      Anchors = [akLeft, akBottom]
      BevelKind = bkFlat
      BevelOuter = bvNone
      Caption = 'pnlSnap'
      Color = clWhite
      Ctl3D = False
      ParentBackground = False
      ParentCtl3D = False
      ShowCaption = False
      TabOrder = 4
    end
    object btnVideoAttr: TButton
      Left = 157
      Top = 60
      Width = 116
      Height = 33
      Caption = #22270#20687#23646#24615
      Enabled = False
      ParentShowHint = False
      ShowHint = False
      TabOrder = 5
      OnClick = btnVideoAttrClick
    end
    object chkMP4: TCheckBox
      Left = 12
      Top = 263
      Width = 82
      Height = 17
      Caption = 'MP4 '#32534#30721#65306
      Enabled = False
      Font.Charset = GB2312_CHARSET
      Font.Color = clWindowText
      Font.Height = -12
      Font.Name = #23435#20307
      Font.Style = []
      ParentFont = False
      ParentShowHint = False
      ShowHint = False
      TabOrder = 6
      OnClick = chkMP4Click
    end
    object chkRTMP: TCheckBox
      Left = 12
      Top = 293
      Width = 81
      Height = 17
      Caption = 'RTMP'#25512#27969#65306
      Enabled = False
      Font.Charset = GB2312_CHARSET
      Font.Color = clWindowText
      Font.Height = -12
      Font.Name = #23435#20307
      Font.Style = []
      ParentFont = False
      ParentShowHint = False
      ShowHint = False
      TabOrder = 7
      OnClick = chkRTMPClick
    end
    object srchbxMP4SavePath: TSearchBox
      Left = 88
      Top = 261
      Width = 185
      Height = 20
      Enabled = False
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -12
      Font.Name = #23435#20307
      Font.Style = []
      ParentFont = False
      ParentShowHint = False
      ShowHint = False
      TabOrder = 8
      OnInvokeSearch = srchbxMP4SavePathInvokeSearch
    end
    object edtRTMPAddress: TEdit
      Left = 88
      Top = 292
      Width = 185
      Height = 20
      Enabled = False
      Font.Charset = ANSI_CHARSET
      Font.Color = clWindowText
      Font.Height = -12
      Font.Name = #23435#20307
      Font.Style = []
      ParentFont = False
      TabOrder = 9
    end
    object cbbHardAccel: TComboBox
      Left = 12
      Top = 224
      Width = 261
      Height = 20
      Style = csDropDownList
      Enabled = False
      ItemIndex = 0
      ParentShowHint = False
      ShowHint = False
      TabOrder = 10
      Text = #26080#30828#20214#21152#36895' (None)'
      Items.Strings = (
        #26080#30828#20214#21152#36895' (None)'
        'Intel '#35270#39057#21345#30828#20214#21152#36895'  (Intel)'
        'Nvidia '#35270#39057#21345#30828#20214#21152#36895' (Nvidia)')
    end
    object chkLogo: TCheckBox
      Left = 12
      Top = 327
      Width = 69
      Height = 17
      Caption = #26174#31034'LOGO'
      Enabled = False
      Font.Charset = GB2312_CHARSET
      Font.Color = clWindowText
      Font.Height = -12
      Font.Name = #23435#20307
      Font.Style = []
      ParentFont = False
      ParentShowHint = False
      ShowHint = False
      TabOrder = 11
      OnClick = chkLogoClick
    end
    object cbbDisplayStyle: TComboBox
      Left = 12
      Top = 167
      Width = 261
      Height = 20
      Style = csDropDownList
      Enabled = False
      ItemIndex = 0
      ParentShowHint = False
      ShowHint = False
      TabOrder = 12
      Text = #26080
      OnChange = cbbDisplayStyleChange
      Items.Strings = (
        #26080
        #27700#24179#38236#20687
        #22402#30452#38236#20687
        #36716#32622
        #28784#24230#22270)
    end
    object btnClearTY: TButton
      Left = 157
      Top = 104
      Width = 116
      Height = 33
      Caption = #28165#38500#28034#40486
      Enabled = False
      ParentShowHint = False
      ShowHint = False
      TabOrder = 13
      OnClick = btnClearTYClick
    end
  end
  object pmSnap: TPopupMenu
    AutoHotkeys = maManual
    Left = 68
    Top = 480
    object N1: TMenuItem
      Caption = #35270#39057#25130#22270
      OnClick = btnVideoSnapClick
    end
    object mniHDSnap: TMenuItem
      Caption = #39640#28165#25130#22270
      OnClick = mniHDSnapClick
    end
  end
end
