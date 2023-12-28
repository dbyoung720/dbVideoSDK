
// VCDlg.cpp: 实现文件
//

#include "pch.h"
#include "framework.h"
#include "VC.h"
#include "VCDlg.h"
#include "dbVideo.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// 用于应用程序“关于”菜单项的 CAboutDlg 对话框

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// 对话框数据
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_ABOUTBOX };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV 支持
};

CAboutDlg::CAboutDlg() : CDialogEx(IDD_ABOUTBOX)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

// CVCDlg 对话框

CVCDlg::CVCDlg(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_VC_DIALOG, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CVCDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_COMBO_VIDEODEVICE, m_VideoList);
	DDX_Control(pDX, IDC_COMBO_VIDEOFORMAT, m_VideoFormatList);
	DDX_Control(pDX, IDC_BUTTONVIDEOPREVIEW, m_VideoPreview);
	DDX_Control(pDX, IDC_BUTTONVIDEOSTOP, m_VideoStop);
	DDX_Control(pDX, IDC_SPLIT1, m_SnapBmp);
	DDX_Control(pDX, IDC_BUTTON4, m_Attr);
	DDX_Control(pDX, IDC_BUTTON6, m_Scrawl);
	DDX_Control(pDX, IDC_BUTTON5, m_ClearScrawl);
	DDX_Control(pDX, IDC_COMBO3, m_DisplayEffect);
	DDX_Control(pDX, IDC_COMBO4, m_MP4HardAccelType);
	DDX_Control(pDX, IDC_CHECKMP4ENC, m_ChkMP4);
	DDX_Control(pDX, IDC_EDIT1, m_edtMP4);
	DDX_Control(pDX, IDC_CHECKRTMP, m_chkRTMP);
	DDX_Control(pDX, IDC_EDIT2, m_edtRTMP);
	DDX_Control(pDX, IDC_CHECKLOGO, m_chkLOGO);
	DDX_Control(pDX, IDC_BUTTON_VIDEO, m_hVideo);
	DDX_Control(pDX, IDC_BUTTON_SNAPBMP, m_DisplaySnapBmp);
	DDX_Control(pDX, IDC_CHECKFACE, m_chkFace);
	DDX_Control(pDX, IDC_COMBO5, m_DeNoiseStyle);
}

BEGIN_MESSAGE_MAP(CVCDlg, CDialogEx)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BUTTONVIDEOPREVIEW, &CVCDlg::OnBnClickedButtonVideoPreview)
	ON_BN_CLICKED(IDC_BUTTONVIDEOSTOP, &CVCDlg::OnBnClickedButtonVideoStop)
	ON_BN_CLICKED(IDC_SPLIT1, &CVCDlg::OnBnClickedSnap)
	ON_BN_CLICKED(IDC_BUTTON4, &CVCDlg::OnBnClickedAttr)
	ON_BN_CLICKED(IDC_BUTTON6, &CVCDlg::OnBnClickedScrawl)
	ON_BN_CLICKED(IDC_BUTTON5, &CVCDlg::OnBnClickedClearScrawl)
	ON_BN_CLICKED(IDC_CHECKMP4ENC, &CVCDlg::OnBnClickedCheckMP4Enc)
	ON_BN_CLICKED(IDC_CHECKRTMP, &CVCDlg::OnBnClickedCheckrtmp)
	ON_BN_CLICKED(IDC_CHECKLOGO, &CVCDlg::OnBnClickedChecklogo)
	ON_CBN_SELCHANGE(IDC_COMBO_VIDEODEVICE, &CVCDlg::OnSelChangeVideoDevice)
	ON_COMMAND(ID_SNAP_SNAP, &CVCDlg::OnMenuSnapBmp)
	ON_COMMAND(ID_SNAP_SNAPHD, &CVCDlg::OnMenuSnapBmpHD)
	ON_CBN_SELCHANGE(IDC_COMBO3, &CVCDlg::OnCbnSelchangeCombo3)
	ON_BN_CLICKED(IDC_CHECKFACE, &CVCDlg::OnBnClickedCheckface)
	ON_CBN_SELCHANGE(IDC_COMBO5, &CVCDlg::OnCbnSelchangeCombo5)
END_MESSAGE_MAP()


// CVCDlg 消息处理程序

void CVCDlg::EnumVideoFormatList(int intIndex)
{
	m_VideoFormatList.ResetContent();
	char* FormatList = dbVideo_EnumVideoFormat(intIndex);
	CString Temp = CString(FormatList);
	int nCurPos = 0;
	CString strSub = Temp.Tokenize(_T(";"), nCurPos);
	while (strSub != _T(""))
	{
		strSub.Trim();
		m_VideoFormatList.AddString(strSub.GetString());
		strSub = Temp.Tokenize(_T(";"), nCurPos);
	}
	if (m_VideoFormatList.GetCount() > 0)
	{
		m_VideoFormatList.SetCurSel(0);
	}
}

BOOL CVCDlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();

	// 将“关于...”菜单项添加到系统菜单中。

	// IDM_ABOUTBOX 必须在系统命令范围内。
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != nullptr)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// 设置此对话框的图标。  当应用程序主窗口不是对话框时，框架将自动
	//  执行此操作
	SetIcon(m_hIcon, TRUE);			// 设置大图标
	SetIcon(m_hIcon, FALSE);		// 设置小图标

	// TODO: 在此添加额外的初始化代码
	CTime tme = CTime::GetTickCount();
	m_SnapBmp.SetDropDownMenu(IDR_MENUSNAP, 0);
	m_DisplayEffect.SetCurSel(0);
	m_DeNoiseStyle.SetCurSel(0);
	m_MP4HardAccelType.SetCurSel(0);
	m_edtMP4.SetWindowText(tme.Format(_T("D:\\%Y%m%d%H%M.MP4")));
	InitVideoSDK();

	char*   cIP = dbVideo_GetNativeIP();
	CString sIP = CString(cIP);
	sIP.Append(L":1935\\live");
	CString hh = CString("http:\\\\");
	sIP = hh + sIP;
	m_edtRTMP.SetWindowText(sIP);

	// 获取设备列表
	char* DeviceList = dbVideo_EnumVideoInputDevice();
	CString Temp = CString(DeviceList);
	int nCurPos = 0;
	CString strSub = Temp.Tokenize(_T(";"), nCurPos);
	while (strSub != _T(""))
	{
		strSub.Trim();
		m_VideoList.AddString(strSub.GetString());
		strSub = Temp.Tokenize(_T(";"), nCurPos);
	}
	if (m_VideoList.GetCount() > 0)
	{
		m_VideoList.SetCurSel(0);
		EnumVideoFormatList(0);       // 获取视频格式列表
		EnableUI(false);
	}

	return TRUE;  // 除非将焦点设置到控件，否则返回 TRUE
}

void CVCDlg::OnSelChangeVideoDevice()
{
	int intIndex = m_VideoList.GetCurSel();
	EnumVideoFormatList(intIndex); // 获取视频格式列表
}

CVCDlg::~CVCDlg()
{
	dbVideo_PreviewStop();
	FreeVideoSDK();
}

void CVCDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialogEx::OnSysCommand(nID, lParam);
	}
}

// 如果向对话框添加最小化按钮，则需要下面的代码
//  来绘制该图标。  对于使用文档/视图模型的 MFC 应用程序，
//  这将由框架自动完成。

void CVCDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // 用于绘制的设备上下文

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// 使图标在工作区矩形中居中
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// 绘制图标
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialogEx::OnPaint();
	}
}

//当用户拖动最小化窗口时系统调用此函数取得光标
//显示。
HCURSOR CVCDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void CVCDlg::EnableUI(const bool Enabled)
{
	m_VideoList.EnableWindow(!Enabled);
	m_VideoFormatList.EnableWindow(!Enabled);
	m_VideoPreview.EnableWindow(!Enabled);
	m_VideoStop.EnableWindow(Enabled);
	m_SnapBmp.EnableWindow(Enabled);
	m_Attr.EnableWindow(Enabled);
	m_Scrawl.EnableWindow(Enabled);
	m_ClearScrawl.EnableWindow(Enabled);
	m_DisplayEffect.EnableWindow(Enabled);
	m_DeNoiseStyle.EnableWindow(Enabled);
	m_MP4HardAccelType.EnableWindow(Enabled);
	m_ChkMP4.EnableWindow(Enabled);
	m_chkRTMP.EnableWindow(Enabled);
	m_chkLOGO.EnableWindow(Enabled);
	m_chkFace.EnableWindow(Enabled);
	m_edtMP4.EnableWindow(Enabled);
	m_edtRTMP.EnableWindow(Enabled);
	m_hVideo.Invalidate();
	m_DisplaySnapBmp.Invalidate();
}

void CVCDlg::OnBnClickedButtonVideoPreview()
{
	int intVideoIndex = m_VideoList.GetCurSel();
	int intVideoFormatIndex = m_VideoFormatList.GetCurSel();
	dbVideo_PreviewStart(intVideoIndex, intVideoFormatIndex, m_hVideo.m_hWnd);
	EnableUI(true);
}

void CVCDlg::OnBnClickedButtonVideoStop()
{
	dbVideo_PreviewStop();
	m_DisplayEffect.SetCurSel(0);
	m_DeNoiseStyle.SetCurSel(0);
	m_MP4HardAccelType.SetCurSel(0);
	m_ChkMP4.SetCheck(0);
	m_chkRTMP.SetCheck(0);
	m_chkLOGO.SetCheck(0);
	m_chkFace.SetCheck(0);
	EnableUI(false);
}

void CVCDlg::OnBnClickedSnap()
{
	dbVideo_SnapBmp(m_DisplaySnapBmp.m_hWnd, false);
}

void CVCDlg::OnMenuSnapBmp()
{
	dbVideo_SnapBmp(m_DisplaySnapBmp.m_hWnd, false);
}

void CVCDlg::OnMenuSnapBmpHD()
{
	dbVideo_SnapBmp(m_DisplaySnapBmp.m_hWnd, true);
}

void CVCDlg::OnBnClickedAttr()
{
	dbVideo_ShowAttr();
}

void CVCDlg::OnBnClickedScrawl()
{
	dbVideo_TY();
}


void CVCDlg::OnBnClickedClearScrawl()
{
	dbVideo_TY_Clear();
}

void CVCDlg::OnCbnSelchangeCombo3()
{
	int iIndex = m_DisplayEffect.GetCurSel();
	dbVideo_ShowStyle(iIndex);
}

void CVCDlg::OnCbnSelchangeCombo5()
{
	int iIndex = m_DeNoiseStyle.GetCurSel();
	dbVideo_DeNoiseStyle(iIndex);
}

char* TCHARToChar(TCHAR* pTchar)
{
	char* pChar = nullptr;
	int nLen = (int)wcslen(pTchar) + 1;
	pChar = new char[nLen * 2];
	WideCharToMultiByte(CP_ACP, 0, pTchar, nLen, pChar, 2 * nLen, NULL, NULL);
	return pChar;
}

void CVCDlg::OnBnClickedCheckMP4Enc()
{
	TCHAR cFileName[MAX_PATH + 1];
	int bRecord = m_ChkMP4.GetCheck();
	int iIndex  = m_MP4HardAccelType.GetCurSel();
	m_edtMP4.GetWindowText(cFileName, MAX_PATH);
	dbVideo_RecordMP4((bool)bRecord, TCHARToChar(cFileName), iIndex);
}

void CVCDlg::OnBnClickedCheckrtmp()
{
	TCHAR cURL[MAX_PATH + 1];
	int bLive  = m_chkRTMP.GetCheck();
	int iIndex = m_MP4HardAccelType.GetCurSel();
	m_edtRTMP.GetWindowText(cURL, MAX_PATH);
	dbVideo_LiveRTMP((bool)bLive, TCHARToChar(cURL), iIndex);
}

void CVCDlg::OnBnClickedChecklogo()
{
	int bCheck = m_chkLOGO.GetCheck();
	dbVideo_ShowLogo((bool)bCheck, NULL);
}

void CVCDlg::OnBnClickedCheckface()
{
	int bCheck = m_chkFace.GetCheck();
	dbVideo_CheckFace((bool)bCheck);
}

