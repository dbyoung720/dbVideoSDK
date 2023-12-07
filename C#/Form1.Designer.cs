namespace C_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbVideoInputDevice = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbVideoFormat = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.edtRTMPURL = new System.Windows.Forms.TextBox();
            this.edtMP4SaveFileName = new System.Windows.Forms.TextBox();
            this.chkFace = new System.Windows.Forms.CheckBox();
            this.chkLogo = new System.Windows.Forms.CheckBox();
            this.chkRTMP = new System.Windows.Forms.CheckBox();
            this.chkMP4Encode = new System.Windows.Forms.CheckBox();
            this.cbbMP4Encoder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbDeNoise = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbEffect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClearScrawl = new System.Windows.Forms.Button();
            this.btnScrawl = new System.Windows.Forms.Button();
            this.btnAttr = new System.Windows.Forms.Button();
            this.btnSnap = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbVideoInputDevice);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(342, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video input list:";
            // 
            // cbbVideoInputDevice
            // 
            this.cbbVideoInputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVideoInputDevice.FormattingEnabled = true;
            this.cbbVideoInputDevice.Location = new System.Drawing.Point(22, 20);
            this.cbbVideoInputDevice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbbVideoInputDevice.Name = "cbbVideoInputDevice";
            this.cbbVideoInputDevice.Size = new System.Drawing.Size(306, 21);
            this.cbbVideoInputDevice.TabIndex = 0;
            this.cbbVideoInputDevice.SelectedIndexChanged += new System.EventHandler(this.cbbVideoInputDevice_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cbbVideoFormat);
            this.groupBox2.Location = new System.Drawing.Point(371, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(808, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Video format list:";
            // 
            // cbbVideoFormat
            // 
            this.cbbVideoFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbVideoFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbVideoFormat.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbbVideoFormat.FormattingEnabled = true;
            this.cbbVideoFormat.Location = new System.Drawing.Point(22, 20);
            this.cbbVideoFormat.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbbVideoFormat.MaxDropDownItems = 20;
            this.cbbVideoFormat.Name = "cbbVideoFormat";
            this.cbbVideoFormat.Size = new System.Drawing.Size(763, 21);
            this.cbbVideoFormat.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.edtRTMPURL);
            this.groupBox3.Controls.Add(this.edtMP4SaveFileName);
            this.groupBox3.Controls.Add(this.chkFace);
            this.groupBox3.Controls.Add(this.chkLogo);
            this.groupBox3.Controls.Add(this.chkRTMP);
            this.groupBox3.Controls.Add(this.chkMP4Encode);
            this.groupBox3.Controls.Add(this.cbbMP4Encoder);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbbDeNoise);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbbEffect);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnClearScrawl);
            this.groupBox3.Controls.Add(this.btnScrawl);
            this.groupBox3.Controls.Add(this.btnAttr);
            this.groupBox3.Controls.Add(this.btnSnap);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Location = new System.Drawing.Point(15, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(342, 658);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Location = new System.Drawing.Point(19, 455);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(309, 197);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // edtRTMPURL
            // 
            this.edtRTMPURL.Enabled = false;
            this.edtRTMPURL.Location = new System.Drawing.Point(137, 377);
            this.edtRTMPURL.Name = "edtRTMPURL";
            this.edtRTMPURL.Size = new System.Drawing.Size(191, 22);
            this.edtRTMPURL.TabIndex = 17;
            // 
            // edtMP4SaveFileName
            // 
            this.edtMP4SaveFileName.Enabled = false;
            this.edtMP4SaveFileName.Location = new System.Drawing.Point(137, 344);
            this.edtMP4SaveFileName.Name = "edtMP4SaveFileName";
            this.edtMP4SaveFileName.Size = new System.Drawing.Size(191, 22);
            this.edtMP4SaveFileName.TabIndex = 16;
            // 
            // chkFace
            // 
            this.chkFace.AutoSize = true;
            this.chkFace.Enabled = false;
            this.chkFace.Location = new System.Drawing.Point(137, 413);
            this.chkFace.Name = "chkFace";
            this.chkFace.Size = new System.Drawing.Size(96, 17);
            this.chkFace.TabIndex = 15;
            this.chkFace.Text = "Check Face";
            this.chkFace.UseVisualStyleBackColor = true;
            this.chkFace.Click += new System.EventHandler(this.chkFace_Click);
            // 
            // chkLogo
            // 
            this.chkLogo.AutoSize = true;
            this.chkLogo.Enabled = false;
            this.chkLogo.Location = new System.Drawing.Point(19, 413);
            this.chkLogo.Name = "chkLogo";
            this.chkLogo.Size = new System.Drawing.Size(89, 17);
            this.chkLogo.TabIndex = 14;
            this.chkLogo.Text = "Show LOGO";
            this.chkLogo.UseVisualStyleBackColor = true;
            this.chkLogo.Click += new System.EventHandler(this.chkLogo_Click);
            // 
            // chkRTMP
            // 
            this.chkRTMP.AutoSize = true;
            this.chkRTMP.Enabled = false;
            this.chkRTMP.Location = new System.Drawing.Point(19, 379);
            this.chkRTMP.Name = "chkRTMP";
            this.chkRTMP.Size = new System.Drawing.Size(110, 17);
            this.chkRTMP.TabIndex = 13;
            this.chkRTMP.Text = "RTMP Stream:";
            this.chkRTMP.UseVisualStyleBackColor = true;
            this.chkRTMP.CheckedChanged += new System.EventHandler(this.chkRTMP_CheckedChanged);
            // 
            // chkMP4Encode
            // 
            this.chkMP4Encode.AutoSize = true;
            this.chkMP4Encode.Enabled = false;
            this.chkMP4Encode.Location = new System.Drawing.Point(19, 346);
            this.chkMP4Encode.Name = "chkMP4Encode";
            this.chkMP4Encode.Size = new System.Drawing.Size(103, 17);
            this.chkMP4Encode.TabIndex = 12;
            this.chkMP4Encode.Text = "MP4 Encode:";
            this.chkMP4Encode.UseVisualStyleBackColor = true;
            this.chkMP4Encode.CheckedChanged += new System.EventHandler(this.chkMP4Encode_CheckedChanged);
            // 
            // cbbMP4Encoder
            // 
            this.cbbMP4Encoder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMP4Encoder.Enabled = false;
            this.cbbMP4Encoder.FormattingEnabled = true;
            this.cbbMP4Encoder.Items.AddRange(new object[] {
            "None",
            "Intel Video card",
            "Nvidia Video card"});
            this.cbbMP4Encoder.Location = new System.Drawing.Point(21, 303);
            this.cbbMP4Encoder.Name = "cbbMP4Encoder";
            this.cbbMP4Encoder.Size = new System.Drawing.Size(307, 21);
            this.cbbMP4Encoder.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(19, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "MP4 Hardware accelerated encoding type:";
            // 
            // cbbDeNoise
            // 
            this.cbbDeNoise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDeNoise.Enabled = false;
            this.cbbDeNoise.FormattingEnabled = true;
            this.cbbDeNoise.Items.AddRange(new object[] {
            "None",
            "High definition low frame (no ghosting)",
            "High definition high frame (with ghosting)"});
            this.cbbDeNoise.Location = new System.Drawing.Point(19, 251);
            this.cbbDeNoise.Name = "cbbDeNoise";
            this.cbbDeNoise.Size = new System.Drawing.Size(309, 21);
            this.cbbDeNoise.TabIndex = 9;
            this.cbbDeNoise.SelectedIndexChanged += new System.EventHandler(this.cbbDeNoise_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(19, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Denoise style:";
            // 
            // cbbEffect
            // 
            this.cbbEffect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEffect.Enabled = false;
            this.cbbEffect.FormattingEnabled = true;
            this.cbbEffect.Items.AddRange(new object[] {
            "None",
            "Horizontal Mirror",
            "Vertically Mirror",
            "Transpose",
            "Gray"});
            this.cbbEffect.Location = new System.Drawing.Point(19, 199);
            this.cbbEffect.Name = "cbbEffect";
            this.cbbEffect.Size = new System.Drawing.Size(309, 21);
            this.cbbEffect.TabIndex = 7;
            this.cbbEffect.SelectedIndexChanged += new System.EventHandler(this.cbbEffect_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(19, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Display effect:";
            // 
            // btnClearScrawl
            // 
            this.btnClearScrawl.Enabled = false;
            this.btnClearScrawl.Location = new System.Drawing.Point(176, 123);
            this.btnClearScrawl.Name = "btnClearScrawl";
            this.btnClearScrawl.Size = new System.Drawing.Size(152, 36);
            this.btnClearScrawl.TabIndex = 5;
            this.btnClearScrawl.Text = "Clear Scrawl";
            this.btnClearScrawl.UseVisualStyleBackColor = true;
            this.btnClearScrawl.Click += new System.EventHandler(this.btnClearScrawl_Click);
            // 
            // btnScrawl
            // 
            this.btnScrawl.Enabled = false;
            this.btnScrawl.Location = new System.Drawing.Point(22, 123);
            this.btnScrawl.Name = "btnScrawl";
            this.btnScrawl.Size = new System.Drawing.Size(138, 36);
            this.btnScrawl.TabIndex = 4;
            this.btnScrawl.Text = "Start Scrawl";
            this.btnScrawl.UseVisualStyleBackColor = true;
            this.btnScrawl.Click += new System.EventHandler(this.btnScrawl_Click);
            // 
            // btnAttr
            // 
            this.btnAttr.Enabled = false;
            this.btnAttr.Location = new System.Drawing.Point(176, 73);
            this.btnAttr.Name = "btnAttr";
            this.btnAttr.Size = new System.Drawing.Size(152, 36);
            this.btnAttr.TabIndex = 3;
            this.btnAttr.Text = "Attibute";
            this.btnAttr.UseVisualStyleBackColor = true;
            this.btnAttr.Click += new System.EventHandler(this.btnAttr_Click);
            // 
            // btnSnap
            // 
            this.btnSnap.Enabled = false;
            this.btnSnap.Location = new System.Drawing.Point(22, 73);
            this.btnSnap.Name = "btnSnap";
            this.btnSnap.Size = new System.Drawing.Size(138, 36);
            this.btnSnap.TabIndex = 2;
            this.btnSnap.Text = "Snap bmp";
            this.btnSnap.UseVisualStyleBackColor = true;
            this.btnSnap.Click += new System.EventHandler(this.btnSnap_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(176, 21);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(152, 36);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Video Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(22, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 36);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Video Preview";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.panel1.Location = new System.Drawing.Point(371, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 650);
            this.panel1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("SimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dbVideoSDK v3.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbVideoInputDevice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbVideoFormat;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAttr;
        private System.Windows.Forms.Button btnSnap;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClearScrawl;
        private System.Windows.Forms.Button btnScrawl;
        private System.Windows.Forms.ComboBox cbbEffect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDeNoise;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbMP4Encoder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkLogo;
        private System.Windows.Forms.CheckBox chkRTMP;
        private System.Windows.Forms.CheckBox chkMP4Encode;
        private System.Windows.Forms.TextBox edtRTMPURL;
        private System.Windows.Forms.TextBox edtMP4SaveFileName;
        private System.Windows.Forms.CheckBox chkFace;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

