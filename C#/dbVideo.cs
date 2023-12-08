using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using static VideoSDKDemo.dbVideoSDK;

namespace VideoSDKDemo
{
	public class dbVideoSDK
	{
		[DllImport("kernel32.dll")]
		private extern static IntPtr LoadLibrary(String path);

		[DllImport("kernel32.dll")]
		private extern static IntPtr GetProcAddress(IntPtr lib, String funcName);

		[DllImport("kernel32.dll")]
		private extern static bool FreeLibrary(IntPtr lib);

		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private extern static bool SetDllDirectory(string lpPathName);

		private readonly IntPtr hVideoSDKlib;

		// ������
		public dbVideoSDK()
		{
			SetDllDirectory(Environment.CurrentDirectory + "\\dbVideo");
			if (hVideoSDKlib == null || hVideoSDKlib == (IntPtr)0)
			{
				hVideoSDKlib = LoadLibrary("dbVideo.dll");
			}

			if (hVideoSDKlib != (IntPtr)0)
			{
				// ���� dbVideoSDK
				m_dbVideo_Init                 = Invoke<Type_dbVideo_Init>("dbVideo_Init");
				m_dbVideo_Free                 = Invoke<Type_dbVideo_Free>("dbVideo_Free");
				m_dbVideo_EnumVideoInputDevice = Invoke<Type_dbVideo_EnumVideoInputDevice>("dbVideo_EnumVideoInputDevice");
                m_dbVideo_EnumVideoFormat      = Invoke<Type_dbVideo_EnumVideoFormat>("dbVideo_EnumVideoFormat");
                m_dbVideo_PreviewStart         = Invoke<Type_dbVideo_PreviewStart>("dbVideo_PreviewStart");
                m_dbVideo_PreviewStop          = Invoke<Type_dbVideo_PreviewStop>("dbVideo_PreviewStop");
                m_dbVideo_ShowStyle            = Invoke<Type_dbVideo_ShowStyle>("dbVideo_ShowStyle");
                m_dbVideo_DeNoiseStyle         = Invoke<Type_dbVideo_DeNoiseStyle>("dbVideo_DeNoiseStyle");
                m_dbVideo_SnapBmp              = Invoke<Type_dbVideo_SnapBmp>("dbVideo_SnapBmp");
                m_dbVideo_ShowAttr             = Invoke<Type_dbVideo_ShowAttr>("dbVideo_ShowAttr");
                m_dbVideo_TY                   = Invoke<Type_dbVideo_TY>("dbVideo_TY");
                m_dbVideo_TY_Clear             = Invoke<Type_dbVideo_TY_Clear>("dbVideo_TY_Clear");
                m_dbVideo_GetNativeIP          = Invoke<Type_dbVideo_GetNativeIP>("dbVideo_GetNativeIP");
                m_dbVideo_ShowLogo             = Invoke<Type_dbVideo_ShowLogo>("dbVideo_ShowLogo");
                m_dbVideo_FaceCheck            = Invoke<Type_dbVideo_FaceCheck>("dbVideo_FaceCheck");
                m_dbVideo_RecordMP4            = Invoke<Type_dbVideo_RecordMP4>("dbVideo_RecordMP4");
                m_dbVideo_LiveRTMP             = Invoke<Type_dbVideo_LiveRTMP>("dbVideo_LiveRTMP");

                // ��ʼ�� dbVideoSDK
                m_dbVideo_Init();
			}
		}

		// ������
		~dbVideoSDK()
		{
			// �ͷ� dbVideoSDK
			m_dbVideo_Free();
			if (hVideoSDKlib != null) FreeLibrary(hVideoSDKlib);
		}

		// ������ת��Ϊί��
		public T Invoke<T>(String APIName)
		{
			IntPtr api = GetProcAddress(hVideoSDKlib, APIName);
			var de = Marshal.GetDelegateForFunctionPointer(api, typeof(T));
			return (T)Convert.ChangeType(de, typeof(T));
		}

		// ��ʼ�� VideoSDK
		public delegate void Type_dbVideo_Init();
		public Type_dbVideo_Init m_dbVideo_Init;

		// �ͷ� VideoSDK
		public delegate void Type_dbVideo_Free();
		public Type_dbVideo_Free m_dbVideo_Free;

		// ö����Ƶ�����豸�б�. ������ ���ֺŸ���
		public delegate IntPtr Type_dbVideo_EnumVideoInputDevice();
		public Type_dbVideo_EnumVideoInputDevice m_dbVideo_EnumVideoInputDevice;

		// ö����Ƶ�����豸֧�ֵ���Ƶ��ʽ�б�. ������ ���ֺŸ���
		public delegate IntPtr Type_dbVideo_EnumVideoFormat(int index);
		public Type_dbVideo_EnumVideoFormat m_dbVideo_EnumVideoFormat;

        // ��ƵԤ����ʼ
        public delegate bool Type_dbVideo_PreviewStart(int intVideoInputIndex, int intVideoFormatIndex, IntPtr hVideo);
		public Type_dbVideo_PreviewStart m_dbVideo_PreviewStart;

        // ��ƵԤ������
        public delegate bool Type_dbVideo_PreviewStop();
        public Type_dbVideo_PreviewStop m_dbVideo_PreviewStop;

        // ��Ƶ��ʾ���
        public delegate IntPtr Type_dbVideo_ShowStyle(int index);
        public Type_dbVideo_ShowStyle m_dbVideo_ShowStyle;

        // ��Ƶ������
        public delegate IntPtr Type_dbVideo_DeNoiseStyle(int index);
        public Type_dbVideo_DeNoiseStyle m_dbVideo_DeNoiseStyle;

        // ��Ƶ��ͼ
        public delegate bool Type_dbVideo_SnapBmp(IntPtr hbmp, bool bHD = false);
        public Type_dbVideo_SnapBmp m_dbVideo_SnapBmp;

        // ��Ƶ����
        public delegate void Type_dbVideo_ShowAttr();
        public Type_dbVideo_ShowAttr m_dbVideo_ShowAttr;

        // ��ƵͿѻ
        public delegate void Type_dbVideo_TY();
        public Type_dbVideo_TY m_dbVideo_TY;

        // �����ƵͿѻ
        public delegate void Type_dbVideo_TY_Clear();
        public Type_dbVideo_TY_Clear m_dbVideo_TY_Clear;

        // ��ȡ����IP
        public delegate IntPtr Type_dbVideo_GetNativeIP();
        public Type_dbVideo_GetNativeIP m_dbVideo_GetNativeIP;

        // ��ʾ PNG LOGO
        public delegate void Type_dbVideo_ShowLogo(bool bShowLogo, string pngfilename="");
        public Type_dbVideo_ShowLogo m_dbVideo_ShowLogo;

        // �������
        public delegate void Type_dbVideo_FaceCheck(bool bFaceCheck);
        public Type_dbVideo_FaceCheck m_dbVideo_FaceCheck;

        // MP4 ¼�� 
        public delegate bool Type_dbVideo_RecordMP4(bool bRecord, string pngfilename = "", int iHwAccType = 0);
        public Type_dbVideo_RecordMP4 m_dbVideo_RecordMP4;

        // RTMP ����
        public delegate bool Type_dbVideo_LiveRTMP(bool bRecord, string strUrl = "", int iHwAccType = 0);
        public Type_dbVideo_LiveRTMP m_dbVideo_LiveRTMP;
    }
}