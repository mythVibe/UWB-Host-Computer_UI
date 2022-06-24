
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
            this.label3 = new System.Windows.Forms.Label();
            this.BtnUavA = new Sunny.UI.UISymbolButton();
            this.BtnUavB = new Sunny.UI.UISymbolButton();
            this.BtnDataA = new Sunny.UI.UISymbolButton();
            this.btnclose = new System.Windows.Forms.Button();
            this.BtnLocateA = new Sunny.UI.UISymbolButton();
            this.BtnDataB = new Sunny.UI.UISymbolButton();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnComA = new Sunny.UI.UISymbolButton();
            this.BtnLocateB = new Sunny.UI.UISymbolButton();
            this.labelTime = new System.Windows.Forms.Label();
            this.BtnComB = new Sunny.UI.UISymbolButton();
            this.panelHead = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelControls = new System.Windows.Forms.Panel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.panelLeft.SuspendLayout();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.BtnUavA);
            this.panelLeft.Controls.Add(this.BtnUavB);
            this.panelLeft.Controls.Add(this.BtnDataA);
            this.panelLeft.Controls.Add(this.btnclose);
            this.panelLeft.Controls.Add(this.BtnLocateA);
            this.panelLeft.Controls.Add(this.BtnDataB);
            this.panelLeft.Controls.Add(this.label5);
            this.panelLeft.Controls.Add(this.BtnComA);
            this.panelLeft.Controls.Add(this.BtnLocateB);
            this.panelLeft.Controls.Add(this.labelTime);
            this.panelLeft.Controls.Add(this.BtnComB);
            this.panelLeft.Controls.Add(this.panelHead);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(215, 759);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLeft_MouseDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(61, 731);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "CIT-Lab";
            // 
            // BtnUavA
            // 
            this.BtnUavA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUavA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.BtnUavA.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold);
            this.BtnUavA.Image = ((System.Drawing.Image)(resources.GetObject("BtnUavA.Image")));
            this.BtnUavA.ImageInterval = 18;
            this.BtnUavA.Location = new System.Drawing.Point(16, 441);
            this.BtnUavA.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnUavA.Name = "BtnUavA";
            this.BtnUavA.Radius = 30;
            this.BtnUavA.RectColor = System.Drawing.Color.Transparent;
            this.BtnUavA.Size = new System.Drawing.Size(165, 43);
            this.BtnUavA.Style = Sunny.UI.UIStyle.Custom;
            this.BtnUavA.TabIndex = 5;
            this.BtnUavA.Text = "遥控模块";
            this.BtnUavA.Click += new System.EventHandler(this.BtnUavA_Click);
            // 
            // BtnUavB
            // 
            this.BtnUavB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUavB.FillColor = System.Drawing.Color.White;
            this.BtnUavB.FillSelectedColor = System.Drawing.Color.White;
            this.BtnUavB.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold);
            this.BtnUavB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.BtnUavB.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.BtnUavB.Image = ((System.Drawing.Image)(resources.GetObject("BtnUavB.Image")));
            this.BtnUavB.Location = new System.Drawing.Point(16, 441);
            this.BtnUavB.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnUavB.Name = "BtnUavB";
            this.BtnUavB.Radius = 30;
            this.BtnUavB.RectColor = System.Drawing.Color.Transparent;
            this.BtnUavB.RectSelectedColor = System.Drawing.Color.Transparent;
            this.BtnUavB.Size = new System.Drawing.Size(165, 43);
            this.BtnUavB.Style = Sunny.UI.UIStyle.Custom;
            this.BtnUavB.TabIndex = 1;
            this.BtnUavB.Text = "遥控模块";
            this.BtnUavB.Visible = false;
            // 
            // BtnDataA
            // 
            this.BtnDataA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDataA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.BtnDataA.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold);
            this.BtnDataA.Image = ((System.Drawing.Image)(resources.GetObject("BtnDataA.Image")));
            this.BtnDataA.ImageInterval = 18;
            this.BtnDataA.Location = new System.Drawing.Point(16, 367);
            this.BtnDataA.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnDataA.Name = "BtnDataA";
            this.BtnDataA.Radius = 30;
            this.BtnDataA.RectColor = System.Drawing.Color.Transparent;
            this.BtnDataA.Size = new System.Drawing.Size(165, 43);
            this.BtnDataA.Style = Sunny.UI.UIStyle.Custom;
            this.BtnDataA.TabIndex = 6;
            this.BtnDataA.Text = "数据传输";
            this.BtnDataA.Click += new System.EventHandler(this.BtnDataA_Click);
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
            // BtnLocateA
            // 
            this.BtnLocateA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLocateA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.BtnLocateA.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold);
            this.BtnLocateA.Image = ((System.Drawing.Image)(resources.GetObject("BtnLocateA.Image")));
            this.BtnLocateA.ImageInterval = 18;
            this.BtnLocateA.Location = new System.Drawing.Point(16, 285);
            this.BtnLocateA.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnLocateA.Name = "BtnLocateA";
            this.BtnLocateA.Radius = 30;
            this.BtnLocateA.RectColor = System.Drawing.Color.Transparent;
            this.BtnLocateA.Size = new System.Drawing.Size(165, 43);
            this.BtnLocateA.Style = Sunny.UI.UIStyle.Custom;
            this.BtnLocateA.TabIndex = 7;
            this.BtnLocateA.Text = "实时定位";
            this.BtnLocateA.Click += new System.EventHandler(this.BtnLocateA_Click);
            // 
            // BtnDataB
            // 
            this.BtnDataB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDataB.FillColor = System.Drawing.Color.White;
            this.BtnDataB.FillSelectedColor = System.Drawing.Color.White;
            this.BtnDataB.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold);
            this.BtnDataB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.BtnDataB.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.BtnDataB.Image = ((System.Drawing.Image)(resources.GetObject("BtnDataB.Image")));
            this.BtnDataB.Location = new System.Drawing.Point(16, 367);
            this.BtnDataB.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnDataB.Name = "BtnDataB";
            this.BtnDataB.Radius = 30;
            this.BtnDataB.RectColor = System.Drawing.Color.Transparent;
            this.BtnDataB.RectSelectedColor = System.Drawing.Color.Transparent;
            this.BtnDataB.Size = new System.Drawing.Size(165, 43);
            this.BtnDataB.Style = Sunny.UI.UIStyle.Custom;
            this.BtnDataB.TabIndex = 2;
            this.BtnDataB.Text = "数据传输";
            this.BtnDataB.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 189);
            this.label5.TabIndex = 1;
            this.label5.Text = "认\r\n知\r\n物\r\n联\r\n技\r\n术\r\n实\r\n验\r\n室";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BtnComA
            // 
            this.BtnComA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnComA.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.BtnComA.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold);
            this.BtnComA.Image = ((System.Drawing.Image)(resources.GetObject("BtnComA.Image")));
            this.BtnComA.ImageInterval = 18;
            this.BtnComA.Location = new System.Drawing.Point(16, 200);
            this.BtnComA.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnComA.Name = "BtnComA";
            this.BtnComA.Radius = 30;
            this.BtnComA.RectColor = System.Drawing.Color.Transparent;
            this.BtnComA.Size = new System.Drawing.Size(165, 43);
            this.BtnComA.Style = Sunny.UI.UIStyle.Custom;
            this.BtnComA.TabIndex = 8;
            this.BtnComA.Text = "基础设置";
            this.BtnComA.Visible = false;
            this.BtnComA.Click += new System.EventHandler(this.BtnComA_Click);
            // 
            // BtnLocateB
            // 
            this.BtnLocateB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLocateB.FillColor = System.Drawing.Color.White;
            this.BtnLocateB.FillSelectedColor = System.Drawing.Color.White;
            this.BtnLocateB.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold);
            this.BtnLocateB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.BtnLocateB.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.BtnLocateB.Image = ((System.Drawing.Image)(resources.GetObject("BtnLocateB.Image")));
            this.BtnLocateB.Location = new System.Drawing.Point(16, 285);
            this.BtnLocateB.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnLocateB.Name = "BtnLocateB";
            this.BtnLocateB.Radius = 30;
            this.BtnLocateB.RectColor = System.Drawing.Color.Transparent;
            this.BtnLocateB.RectSelectedColor = System.Drawing.Color.Transparent;
            this.BtnLocateB.Size = new System.Drawing.Size(165, 43);
            this.BtnLocateB.Style = Sunny.UI.UIStyle.Custom;
            this.BtnLocateB.TabIndex = 3;
            this.BtnLocateB.Text = "实时定位";
            this.BtnLocateB.Visible = false;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("华文中宋", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.Location = new System.Drawing.Point(62, 703);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(94, 21);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "时/分/秒";
            this.labelTime.Click += new System.EventHandler(this.label6_Click);
            // 
            // BtnComB
            // 
            this.BtnComB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnComB.FillColor = System.Drawing.Color.White;
            this.BtnComB.FillHoverColor = System.Drawing.Color.White;
            this.BtnComB.FillSelectedColor = System.Drawing.Color.White;
            this.BtnComB.Font = new System.Drawing.Font("华文中宋", 15F, System.Drawing.FontStyle.Bold);
            this.BtnComB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.BtnComB.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.BtnComB.Image = ((System.Drawing.Image)(resources.GetObject("BtnComB.Image")));
            this.BtnComB.Location = new System.Drawing.Point(16, 200);
            this.BtnComB.MinimumSize = new System.Drawing.Size(1, 1);
            this.BtnComB.Name = "BtnComB";
            this.BtnComB.Radius = 30;
            this.BtnComB.RectColor = System.Drawing.Color.Transparent;
            this.BtnComB.RectSelectedColor = System.Drawing.Color.Transparent;
            this.BtnComB.Selected = true;
            this.BtnComB.Size = new System.Drawing.Size(165, 43);
            this.BtnComB.Style = Sunny.UI.UIStyle.Custom;
            this.BtnComB.TabIndex = 4;
            this.BtnComB.Text = "基础设置";
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
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 20;
            this.elipseControl1.TargetControl = this;
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
        private System.Windows.Forms.Button btnclose;
        private Sunny.UI.UISymbolButton BtnUavB;
        private Sunny.UI.UISymbolButton BtnDataB;
        private Sunny.UI.UISymbolButton BtnLocateB;
        private Sunny.UI.UISymbolButton BtnComB;
        private Sunny.UI.UISymbolButton BtnUavA;
        private Sunny.UI.UISymbolButton BtnDataA;
        private Sunny.UI.UISymbolButton BtnLocateA;
        private Sunny.UI.UISymbolButton BtnComA;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Label label3;
    }
}