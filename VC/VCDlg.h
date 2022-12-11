
// VCDlg.h: 头文件
//

#pragma once


// CVCDlg 对话框
class CVCDlg : public CDialogEx
{
// 构造
public:
	CVCDlg(CWnd* pParent = nullptr);	// 标准构造函数
	~CVCDlg();

// 对话框数据
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_VC_DIALOG };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV 支持


// 实现
protected:
	HICON m_hIcon;

	// 生成的消息映射函数
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	CComboBox m_VideoList;
	CComboBox m_VideoFormatList;
	CButton m_VideoPreview;
	CButton m_VideoStop;
	CSplitButton m_SnapBmp;
	CButton m_Attr;
	CButton m_Scrawl;
	CButton m_ClearScrawl;
	CComboBox m_DisplayEffect;
	CComboBox m_MP4HardAccelType;
	CButton m_ChkMP4;
	CEdit m_edtMP4;
	CButton m_chkRTMP;
	CEdit m_edtRTMP;
	CButton m_chkLOGO;
	CButton m_hVideo;
	CButton m_DisplaySnapBmp;
	CButton m_chkFace;
	afx_msg void OnBnClickedButtonVideoPreview();
	afx_msg void OnBnClickedButtonVideoStop();
	afx_msg void OnBnClickedScrawl();
	afx_msg void OnBnClickedClearScrawl();
	afx_msg void OnBnClickedAttr();
	afx_msg void OnBnClickedSnap();
	afx_msg void OnBnClickedCheckMP4Enc();
	afx_msg void OnBnClickedCheckrtmp();
	afx_msg void OnBnClickedChecklogo();
	afx_msg void OnSelChangeVideoDevice();
	afx_msg void OnMenuSnapBmp();
	afx_msg void OnMenuSnapBmpHD();
	afx_msg void OnCbnSelchangeCombo3();
private:
	void EnumVideoFormatList(int intIndex);
	void EnableUI(const bool Enabled);
public:
	afx_msg void OnBnClickedCheckface();
};
