using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoSDKDemo;

namespace C_
{
    public partial class Form1 : Form
    {
        private dbVideoSDK vsdk;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vsdk = new dbVideoSDK();
            IntPtr pBuffer = vsdk.m_dbVideo_EnumVideoInputDevice();
            string stringDevice = Marshal.PtrToStringAnsi(pBuffer);
            string[] listdevice = stringDevice.Split(';');
            cbbVideoInputDevice.Items.AddRange(listdevice);
            if (cbbVideoInputDevice.Items.Count > 0)
            {
                cbbVideoInputDevice.SelectedIndex = 0;
            }
            cbbEffect.SelectedIndex     = 0;
            cbbDeNoise.SelectedIndex    = 0;
            cbbMP4Encoder.SelectedIndex = 0;
            edtMP4SaveFileName.Text     = "d:\\" + DateTime.Now.ToString("yyyyMMdd") + ".mp4";
            pBuffer = vsdk.m_dbVideo_GetNativeIP();
            edtRTMPURL.Text ="rtmp://" + Marshal.PtrToStringAnsi(pBuffer) + ":1935/live";
        }

        private void cbbVideoInputDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbVideoFormat.Items.Clear();
            IntPtr pBuffer = vsdk.m_dbVideo_EnumVideoFormat(cbbVideoInputDevice.SelectedIndex);
            string stringFormat = Marshal.PtrToStringAnsi(pBuffer);
            string[] listformat = stringFormat.Split(';');
            cbbVideoFormat.Items.AddRange(listformat);
            if (cbbVideoFormat.Items.Count > 0)
            {
                cbbVideoFormat.SelectedIndex = 0;
            }
        }

        private void EnableUI()
        {
            cbbVideoInputDevice.Enabled = btnStart.Enabled;
            cbbVideoFormat.Enabled      = btnStart.Enabled;
            btnStop.Enabled             = !btnStart.Enabled;
            btnSnap.Enabled             = !btnStart.Enabled;
            btnAttr.Enabled             = !btnStart.Enabled;
            btnScrawl.Enabled           = !btnStart.Enabled;
            btnClearScrawl.Enabled      = !btnStart.Enabled;
            cbbEffect.Enabled           = !btnStart.Enabled;
            cbbDeNoise.Enabled          = !btnStart.Enabled;
            cbbMP4Encoder.Enabled       = !btnStart.Enabled;
            chkMP4Encode.Enabled        = !btnStart.Enabled;
            chkRTMP.Enabled             = !btnStart.Enabled;
            chkLogo.Enabled             = !btnStart.Enabled;
            chkFace.Enabled             = !btnStart.Enabled;
            label1.Enabled              = !btnStart.Enabled;
            label2.Enabled              = !btnStart.Enabled;
            label3.Enabled              = !btnStart.Enabled;
            edtMP4SaveFileName.Enabled  = !btnStart.Enabled;
            edtRTMPURL.Enabled          = !btnStart.Enabled;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            vsdk.m_dbVideo_PreviewStart(cbbVideoInputDevice.SelectedIndex, cbbVideoFormat.SelectedIndex, panel1.Handle);
            EnableUI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;
            vsdk.m_dbVideo_PreviewStop();
            EnableUI();
            cbbEffect.SelectedIndex = 0;
            cbbDeNoise.SelectedIndex = 0;
            cbbMP4Encoder.SelectedIndex = 0;
            chkMP4Encode.Checked = false;
            chkRTMP.Checked = false;
            chkLogo.Checked = false;
            chkFace.Checked = false;
        }

        private void cbbEffect_SelectedIndexChanged(object sender, EventArgs e)
        {
            vsdk.m_dbVideo_ShowStyle(cbbEffect.SelectedIndex);
        }

        private void btnSnap_Click(object sender, EventArgs e)
        {
            vsdk.m_dbVideo_SnapBmp(panel1.Handle);
        }

        private void btnAttr_Click(object sender, EventArgs e)
        {
            vsdk.m_dbVideo_ShowAttr();
        }

        private void btnScrawl_Click(object sender, EventArgs e)
        {
            vsdk.m_dbVideo_TY();
        }

        private void btnClearScrawl_Click(object sender, EventArgs e)
        {
            vsdk.m_dbVideo_TY_Clear();
        }

        private void chkLogo_Click(object sender, EventArgs e)
        {
            vsdk.m_dbVideo_ShowLogo(chkLogo.Checked, "logo.png");
        }

        private void chkFace_Click(object sender, EventArgs e)
        {
            vsdk.m_dbVideo_FaceCheck(chkFace.Checked);
        }

        private void cbbDeNoise_SelectedIndexChanged(object sender, EventArgs e)
        {
            vsdk.m_dbVideo_DeNoiseStyle(cbbDeNoise.SelectedIndex);
        }

        private void chkRTMP_CheckedChanged(object sender, EventArgs e)
        {
            vsdk.m_dbVideo_LiveRTMP(chkRTMP.Checked, edtRTMPURL.Text, cbbMP4Encoder.SelectedIndex);
        }

        private void chkMP4Encode_CheckedChanged(object sender, EventArgs e)
        {
            vsdk.m_dbVideo_RecordMP4(chkMP4Encode.Checked, edtMP4SaveFileName.Text, cbbMP4Encoder.SelectedIndex);
        }
    }
}
