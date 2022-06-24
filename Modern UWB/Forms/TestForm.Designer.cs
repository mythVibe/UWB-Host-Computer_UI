
namespace UWB.Forms
{
    partial class Form_LeftBar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LeftBar));
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.btnUAV = new Guna.UI2.WinForms.Guna2Button();
            this.btnDataT = new Guna.UI2.WinForms.Guna2Button();
            this.btnLocate = new Guna.UI2.WinForms.Guna2Button();
            this.btnCom = new Guna.UI2.WinForms.Guna2Button();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelControls = new System.Windows.Forms.Panel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panelLeft.Controls.Add(this.btnclose);
            this.panelLeft.Controls.Add(this.label5);
            this.panelLeft.Controls.Add(this.labelTime);
            this.panelLeft.Controls.Add(this.btnUAV);
            this.panelLeft.Controls.Add(this.btnDataT);
            this.panelLeft.Controls.Add(this.btnLocate);
            this.panelLeft.Controls.Add(this.btnCom);
            this.panelLeft.Controls.Add(this.imgSlide);
            this.panelLeft.Controls.Add(this.label6);
            this.panelLeft.Controls.Add(this.panelHead);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(215, 759);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseDown);
            // 
            // btnclose
            // 
            this.btnclose.FlatAppearance.BorderSize = 0;
            this.btnclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(12, 719);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(36, 35);
            this.btnclose.TabIndex = 6;
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 168);
            this.label5.TabIndex = 1;
            this.label5.Text = "认\r\n知\r\n物\r\n联\r\n网\r\n实\r\n验\r\n室";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(59, 706);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(94, 21);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "时/分/秒";
            this.labelTime.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnUAV
            // 
            this.btnUAV.BackColor = System.Drawing.Color.Transparent;
            this.btnUAV.BorderColor = System.Drawing.Color.Transparent;
            this.btnUAV.BorderRadius = 22;
            this.btnUAV.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUAV.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUAV.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnUAV.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnUAV.CheckedState.Image")));
            this.btnUAV.CheckedState.Parent = this.btnUAV;
            this.btnUAV.CustomImages.Parent = this.btnUAV;
            this.btnUAV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnUAV.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold);
            this.btnUAV.ForeColor = System.Drawing.Color.White;
            this.btnUAV.HoverState.Parent = this.btnUAV;
            this.btnUAV.Image = ((System.Drawing.Image)(resources.GetObject("btnUAV.Image")));
            this.btnUAV.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUAV.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUAV.Location = new System.Drawing.Point(7, 316);
            this.btnUAV.Name = "btnUAV";
            this.btnUAV.ShadowDecoration.Parent = this.btnUAV;
            this.btnUAV.Size = new System.Drawing.Size(180, 45);
            this.btnUAV.TabIndex = 5;
            this.btnUAV.Text = "无人机遥控";
            this.btnUAV.TextOffset = new System.Drawing.Point(15, 3);
            this.btnUAV.UseTransparentBackground = true;
            this.btnUAV.CheckedChanged += new System.EventHandler(this.guna2Button4_CheckedChanged);
            this.btnUAV.Click += new System.EventHandler(this.btnUAV_Click);
            // 
            // btnDataT
            // 
            this.btnDataT.BackColor = System.Drawing.Color.Transparent;
            this.btnDataT.BorderColor = System.Drawing.Color.Transparent;
            this.btnDataT.BorderRadius = 22;
            this.btnDataT.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDataT.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnDataT.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnDataT.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnDataT.CheckedState.Image")));
            this.btnDataT.CheckedState.Parent = this.btnDataT;
            this.btnDataT.CustomImages.Parent = this.btnDataT;
            this.btnDataT.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnDataT.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold);
            this.btnDataT.ForeColor = System.Drawing.Color.White;
            this.btnDataT.HoverState.Parent = this.btnDataT;
            this.btnDataT.Image = ((System.Drawing.Image)(resources.GetObject("btnDataT.Image")));
            this.btnDataT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDataT.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDataT.Location = new System.Drawing.Point(7, 265);
            this.btnDataT.Name = "btnDataT";
            this.btnDataT.ShadowDecoration.Parent = this.btnDataT;
            this.btnDataT.Size = new System.Drawing.Size(180, 45);
            this.btnDataT.TabIndex = 5;
            this.btnDataT.Text = "数据传输";
            this.btnDataT.TextOffset = new System.Drawing.Point(5, 3);
            this.btnDataT.UseTransparentBackground = true;
            this.btnDataT.CheckedChanged += new System.EventHandler(this.guna2Button4_CheckedChanged);
            this.btnDataT.Click += new System.EventHandler(this.btnDataT_Click);
            // 
            // btnLocate
            // 
            this.btnLocate.BackColor = System.Drawing.Color.Transparent;
            this.btnLocate.BorderColor = System.Drawing.Color.Transparent;
            this.btnLocate.BorderRadius = 22;
            this.btnLocate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLocate.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnLocate.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnLocate.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnLocate.CheckedState.Image")));
            this.btnLocate.CheckedState.Parent = this.btnLocate;
            this.btnLocate.CustomImages.Parent = this.btnLocate;
            this.btnLocate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnLocate.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold);
            this.btnLocate.ForeColor = System.Drawing.Color.White;
            this.btnLocate.HoverState.Parent = this.btnLocate;
            this.btnLocate.Image = ((System.Drawing.Image)(resources.GetObject("btnLocate.Image")));
            this.btnLocate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLocate.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLocate.Location = new System.Drawing.Point(7, 214);
            this.btnLocate.Name = "btnLocate";
            this.btnLocate.ShadowDecoration.Parent = this.btnLocate;
            this.btnLocate.Size = new System.Drawing.Size(180, 45);
            this.btnLocate.TabIndex = 5;
            this.btnLocate.Text = "实时定位";
            this.btnLocate.TextOffset = new System.Drawing.Point(5, 3);
            this.btnLocate.UseTransparentBackground = true;
            this.btnLocate.CheckedChanged += new System.EventHandler(this.guna2Button4_CheckedChanged);
            this.btnLocate.Click += new System.EventHandler(this.btnLocate_Click);
            // 
            // btnCom
            // 
            this.btnCom.BackColor = System.Drawing.Color.Transparent;
            this.btnCom.BorderColor = System.Drawing.Color.Transparent;
            this.btnCom.BorderRadius = 22;
            this.btnCom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCom.Checked = true;
            this.btnCom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCom.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnCom.CheckedState.Image")));
            this.btnCom.CheckedState.Parent = this.btnCom;
            this.btnCom.CustomImages.Parent = this.btnCom;
            this.btnCom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCom.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold);
            this.btnCom.ForeColor = System.Drawing.Color.White;
            this.btnCom.HoverState.Parent = this.btnCom;
            this.btnCom.Image = ((System.Drawing.Image)(resources.GetObject("btnCom.Image")));
            this.btnCom.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCom.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCom.Location = new System.Drawing.Point(7, 163);
            this.btnCom.Name = "btnCom";
            this.btnCom.ShadowDecoration.Parent = this.btnCom;
            this.btnCom.Size = new System.Drawing.Size(180, 45);
            this.btnCom.TabIndex = 5;
            this.btnCom.Text = "基础设置";
            this.btnCom.TextOffset = new System.Drawing.Point(5, 3);
            this.btnCom.UseTransparentBackground = true;
            this.btnCom.CheckedChanged += new System.EventHandler(this.guna2Button4_CheckedChanged);
            this.btnCom.Click += new System.EventHandler(this.btnCom_Click);
            // 
            // imgSlide
            // 
            this.imgSlide.Image = ((System.Drawing.Image)(resources.GetObject("imgSlide.Image")));
            this.imgSlide.Location = new System.Drawing.Point(127, 135);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(89, 101);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 0;
            this.imgSlide.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(60, 736);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "室内定位";
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panelHead.Controls.Add(this.button6);
            this.panelHead.Controls.Add(this.label2);
            this.panelHead.Controls.Add(this.label1);
            this.panelHead.Controls.Add(this.pictureBox1);
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(215, 140);
            this.panelHead.TabIndex = 2;
            this.panelHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseDown);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(12, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(40, 42);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(58, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = " 功能栏";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = " 室内定位";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelControls
            // 
            this.panelControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panelControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControls.Location = new System.Drawing.Point(215, 0);
            this.panelControls.Name = "panelControls";
            this.panelControls.Padding = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.panelControls.Size = new System.Drawing.Size(1001, 759);
            this.panelControls.TabIndex = 3;
            this.panelControls.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControls_MouseDown);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Form_LeftBar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1216, 759);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("华文中宋", 10.8F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1216, 759);
            this.Name = "Form_LeftBar";
            this.Text = "Form_LeftBar";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_LeftBar_MouseDown);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelHand;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Timer timerTime;
        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnCom;
        private System.Windows.Forms.PictureBox imgSlide;
        private Guna.UI2.WinForms.Guna2Button btnUAV;
        private Guna.UI2.WinForms.Guna2Button btnDataT;
        private Guna.UI2.WinForms.Guna2Button btnLocate;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Button btnclose;
    }
}