
namespace UWB.Forms.location
{
    partial class UserControl1
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.View_2D = new Sunny.UI.UISymbolButton();
            this.View_3D = new Sunny.UI.UISymbolButton();
            this.Track_Open = new Sunny.UI.UISymbolButton();
            this.Track_Cls = new Sunny.UI.UISymbolButton();
            this.LocateBtn = new Sunny.UI.UISymbolButton();
            this.panelRight = new System.Windows.Forms.Panel();
            this.RightSlide = new Sunny.UI.UIImageButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.HelpBtn = new Sunny.UI.UIImageButton();
            this.uiCheckBox1 = new Sunny.UI.UICheckBox();
            this.uiCheckBox2 = new Sunny.UI.UICheckBox();
            this.uiCheckBox3 = new Sunny.UI.UICheckBox();
            this.uiCheckBox4 = new Sunny.UI.UICheckBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiDoubleUpDown1 = new Sunny.UI.UIDoubleUpDown();
            this.uiIntegerUpDown1 = new Sunny.UI.UIIntegerUpDown();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiIntegerUpDown2 = new Sunny.UI.UIIntegerUpDown();
            this.uiIntegerUpDown3 = new Sunny.UI.UIIntegerUpDown();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RightSlide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // View_2D
            // 
            this.View_2D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.View_2D.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.View_2D.FillHoverColor = System.Drawing.Color.Transparent;
            this.View_2D.FillPressColor = System.Drawing.Color.Transparent;
            this.View_2D.FillSelectedColor = System.Drawing.Color.Transparent;
            this.View_2D.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.View_2D.Image = ((System.Drawing.Image)(resources.GetObject("View_2D.Image")));
            this.View_2D.Location = new System.Drawing.Point(19, 25);
            this.View_2D.MinimumSize = new System.Drawing.Size(1, 1);
            this.View_2D.Name = "View_2D";
            this.View_2D.RectColor = System.Drawing.Color.Transparent;
            this.View_2D.RectHoverColor = System.Drawing.Color.Transparent;
            this.View_2D.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.View_2D.Size = new System.Drawing.Size(104, 68);
            this.View_2D.Style = Sunny.UI.UIStyle.Custom;
            this.View_2D.TabIndex = 19;
            this.View_2D.Text = "  2D";
            this.View_2D.Click += new System.EventHandler(this.View_Open_Click);
            // 
            // View_3D
            // 
            this.View_3D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.View_3D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.View_3D.FillColor = System.Drawing.Color.White;
            this.View_3D.FillHoverColor = System.Drawing.Color.White;
            this.View_3D.FillPressColor = System.Drawing.Color.White;
            this.View_3D.FillSelectedColor = System.Drawing.Color.White;
            this.View_3D.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.View_3D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.View_3D.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.View_3D.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.View_3D.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.View_3D.Image = ((System.Drawing.Image)(resources.GetObject("View_3D.Image")));
            this.View_3D.Location = new System.Drawing.Point(19, 25);
            this.View_3D.MinimumSize = new System.Drawing.Size(1, 1);
            this.View_3D.Name = "View_3D";
            this.View_3D.RectColor = System.Drawing.Color.White;
            this.View_3D.RectDisableColor = System.Drawing.Color.White;
            this.View_3D.RectHoverColor = System.Drawing.Color.White;
            this.View_3D.RectPressColor = System.Drawing.Color.White;
            this.View_3D.RectSelectedColor = System.Drawing.Color.White;
            this.View_3D.Size = new System.Drawing.Size(104, 68);
            this.View_3D.Style = Sunny.UI.UIStyle.Custom;
            this.View_3D.TabIndex = 19;
            this.View_3D.Text = "  3D";
            this.View_3D.Visible = false;
            this.View_3D.Click += new System.EventHandler(this.View_Cls_Click);
            // 
            // Track_Open
            // 
            this.Track_Open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Track_Open.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Track_Open.FillHoverColor = System.Drawing.Color.Transparent;
            this.Track_Open.FillPressColor = System.Drawing.Color.Transparent;
            this.Track_Open.FillSelectedColor = System.Drawing.Color.Transparent;
            this.Track_Open.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Track_Open.Image = ((System.Drawing.Image)(resources.GetObject("Track_Open.Image")));
            this.Track_Open.Location = new System.Drawing.Point(18, 118);
            this.Track_Open.MinimumSize = new System.Drawing.Size(1, 1);
            this.Track_Open.Name = "Track_Open";
            this.Track_Open.RectColor = System.Drawing.Color.Transparent;
            this.Track_Open.RectHoverColor = System.Drawing.Color.Transparent;
            this.Track_Open.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Track_Open.Size = new System.Drawing.Size(129, 68);
            this.Track_Open.Style = Sunny.UI.UIStyle.Custom;
            this.Track_Open.TabIndex = 19;
            this.Track_Open.Text = "轨迹";
            this.Track_Open.Visible = false;
            this.Track_Open.Click += new System.EventHandler(this.Track_Open_Click);
            // 
            // Track_Cls
            // 
            this.Track_Cls.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Track_Cls.FillColor = System.Drawing.Color.White;
            this.Track_Cls.FillHoverColor = System.Drawing.Color.White;
            this.Track_Cls.FillPressColor = System.Drawing.Color.White;
            this.Track_Cls.FillSelectedColor = System.Drawing.Color.White;
            this.Track_Cls.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Track_Cls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Track_Cls.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Track_Cls.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Track_Cls.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.Track_Cls.Image = ((System.Drawing.Image)(resources.GetObject("Track_Cls.Image")));
            this.Track_Cls.Location = new System.Drawing.Point(18, 118);
            this.Track_Cls.MinimumSize = new System.Drawing.Size(1, 1);
            this.Track_Cls.Name = "Track_Cls";
            this.Track_Cls.RectColor = System.Drawing.Color.White;
            this.Track_Cls.RectDisableColor = System.Drawing.Color.White;
            this.Track_Cls.RectHoverColor = System.Drawing.Color.White;
            this.Track_Cls.RectPressColor = System.Drawing.Color.White;
            this.Track_Cls.RectSelectedColor = System.Drawing.Color.White;
            this.Track_Cls.Size = new System.Drawing.Size(129, 68);
            this.Track_Cls.Style = Sunny.UI.UIStyle.Custom;
            this.Track_Cls.TabIndex = 19;
            this.Track_Cls.Text = "轨迹";
            this.Track_Cls.Click += new System.EventHandler(this.Track_Cls_Click);
            // 
            // LocateBtn
            // 
            this.LocateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LocateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.LocateBtn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.LocateBtn.Image = ((System.Drawing.Image)(resources.GetObject("LocateBtn.Image")));
            this.LocateBtn.Location = new System.Drawing.Point(24, 541);
            this.LocateBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.LocateBtn.Name = "LocateBtn";
            this.LocateBtn.RectColor = System.Drawing.Color.Transparent;
            this.LocateBtn.Size = new System.Drawing.Size(109, 68);
            this.LocateBtn.Style = Sunny.UI.UIStyle.Custom;
            this.LocateBtn.TabIndex = 19;
            this.LocateBtn.Text = "定位";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panelRight.Controls.Add(this.uiIntegerUpDown3);
            this.panelRight.Controls.Add(this.uiIntegerUpDown2);
            this.panelRight.Controls.Add(this.uiIntegerUpDown1);
            this.panelRight.Controls.Add(this.uiLabel4);
            this.panelRight.Controls.Add(this.uiLabel3);
            this.panelRight.Controls.Add(this.uiLabel2);
            this.panelRight.Controls.Add(this.uiLabel1);
            this.panelRight.Controls.Add(this.uiDoubleUpDown1);
            this.panelRight.Controls.Add(this.uiCheckBox4);
            this.panelRight.Controls.Add(this.uiCheckBox3);
            this.panelRight.Controls.Add(this.uiCheckBox2);
            this.panelRight.Controls.Add(this.uiCheckBox1);
            this.panelRight.Controls.Add(this.HelpBtn);
            this.panelRight.Controls.Add(this.RightSlide);
            this.panelRight.Controls.Add(this.Track_Open);
            this.panelRight.Controls.Add(this.LocateBtn);
            this.panelRight.Controls.Add(this.Track_Cls);
            this.panelRight.Controls.Add(this.View_2D);
            this.panelRight.Controls.Add(this.View_3D);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(850, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(151, 759);
            this.panelRight.TabIndex = 20;
            this.panelRight.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRight_Paint);
            // 
            // RightSlide
            // 
            this.RightSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.RightSlide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RightSlide.Dock = System.Windows.Forms.DockStyle.Left;
            this.RightSlide.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.RightSlide.Image = ((System.Drawing.Image)(resources.GetObject("RightSlide.Image")));
            this.RightSlide.ImageOffset = new System.Drawing.Point(0, 372);
            this.RightSlide.Location = new System.Drawing.Point(0, 0);
            this.RightSlide.Name = "RightSlide";
            this.RightSlide.Size = new System.Drawing.Size(13, 759);
            this.RightSlide.TabIndex = 21;
            this.RightSlide.TabStop = false;
            this.RightSlide.Click += new System.EventHandler(this.RightSlide_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 20;
            this.elipseControl1.TargetControl = this;
            // 
            // HelpBtn
            // 
            this.HelpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpBtn.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.HelpBtn.Image = ((System.Drawing.Image)(resources.GetObject("HelpBtn.Image")));
            this.HelpBtn.Location = new System.Drawing.Point(117, 696);
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.Size = new System.Drawing.Size(34, 32);
            this.HelpBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HelpBtn.TabIndex = 21;
            this.HelpBtn.TabStop = false;
            // 
            // uiCheckBox1
            // 
            this.uiCheckBox1.CheckBoxColor = System.Drawing.Color.White;
            this.uiCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox1.ForeColor = System.Drawing.Color.White;
            this.uiCheckBox1.Location = new System.Drawing.Point(19, 200);
            this.uiCheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox1.Name = "uiCheckBox1";
            this.uiCheckBox1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox1.Size = new System.Drawing.Size(132, 29);
            this.uiCheckBox1.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox1.TabIndex = 21;
            this.uiCheckBox1.Text = "设备名称显示";
            // 
            // uiCheckBox2
            // 
            this.uiCheckBox2.CheckBoxColor = System.Drawing.Color.White;
            this.uiCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox2.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox2.ForeColor = System.Drawing.Color.White;
            this.uiCheckBox2.Location = new System.Drawing.Point(19, 225);
            this.uiCheckBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox2.Name = "uiCheckBox2";
            this.uiCheckBox2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox2.Size = new System.Drawing.Size(132, 29);
            this.uiCheckBox2.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox2.TabIndex = 21;
            this.uiCheckBox2.Text = "坐标轴显示";
            // 
            // uiCheckBox3
            // 
            this.uiCheckBox3.CheckBoxColor = System.Drawing.Color.White;
            this.uiCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox3.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox3.ForeColor = System.Drawing.Color.White;
            this.uiCheckBox3.Location = new System.Drawing.Point(19, 250);
            this.uiCheckBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox3.Name = "uiCheckBox3";
            this.uiCheckBox3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox3.Size = new System.Drawing.Size(132, 29);
            this.uiCheckBox3.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox3.TabIndex = 21;
            this.uiCheckBox3.Text = "标签坐标显示";
            // 
            // uiCheckBox4
            // 
            this.uiCheckBox4.CheckBoxColor = System.Drawing.Color.White;
            this.uiCheckBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox4.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiCheckBox4.ForeColor = System.Drawing.Color.White;
            this.uiCheckBox4.Location = new System.Drawing.Point(19, 278);
            this.uiCheckBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox4.Name = "uiCheckBox4";
            this.uiCheckBox4.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox4.Size = new System.Drawing.Size(132, 29);
            this.uiCheckBox4.Style = Sunny.UI.UIStyle.Custom;
            this.uiCheckBox4.TabIndex = 21;
            this.uiCheckBox4.Text = "测距圆显示";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold);
            this.uiLabel1.ForeColor = System.Drawing.Color.White;
            this.uiLabel1.Location = new System.Drawing.Point(19, 310);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(100, 23);
            this.uiLabel1.TabIndex = 21;
            this.uiLabel1.Text = "原点坐标X";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiDoubleUpDown1
            // 
            this.uiDoubleUpDown1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiDoubleUpDown1.Location = new System.Drawing.Point(20, 509);
            this.uiDoubleUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDoubleUpDown1.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiDoubleUpDown1.Name = "uiDoubleUpDown1";
            this.uiDoubleUpDown1.Size = new System.Drawing.Size(100, 24);
            this.uiDoubleUpDown1.TabIndex = 21;
            this.uiDoubleUpDown1.Text = "uiDoubleUpDown1";
            this.uiDoubleUpDown1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiDoubleUpDown1.Value = 3D;
            this.uiDoubleUpDown1.ValueChanged += new Sunny.UI.UIDoubleUpDown.OnValueChanged(this.uiDoubleUpDown1_ValueChanged);
            // 
            // uiIntegerUpDown1
            // 
            this.uiIntegerUpDown1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiIntegerUpDown1.Location = new System.Drawing.Point(20, 339);
            this.uiIntegerUpDown1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiIntegerUpDown1.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiIntegerUpDown1.Name = "uiIntegerUpDown1";
            this.uiIntegerUpDown1.Size = new System.Drawing.Size(100, 24);
            this.uiIntegerUpDown1.TabIndex = 22;
            this.uiIntegerUpDown1.Text = "uiIntegerUpDown1";
            this.uiIntegerUpDown1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiIntegerUpDown1.Value = 50;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold);
            this.uiLabel2.ForeColor = System.Drawing.Color.White;
            this.uiLabel2.Location = new System.Drawing.Point(20, 367);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(100, 23);
            this.uiLabel2.TabIndex = 21;
            this.uiLabel2.Text = "原点坐标Y";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold);
            this.uiLabel3.ForeColor = System.Drawing.Color.White;
            this.uiLabel3.Location = new System.Drawing.Point(19, 424);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 21;
            this.uiLabel3.Text = "原点坐标Z";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Bold);
            this.uiLabel4.ForeColor = System.Drawing.Color.White;
            this.uiLabel4.Location = new System.Drawing.Point(19, 481);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(113, 23);
            this.uiLabel4.TabIndex = 21;
            this.uiLabel4.Text = "地图缩放比例";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiIntegerUpDown2
            // 
            this.uiIntegerUpDown2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiIntegerUpDown2.Location = new System.Drawing.Point(20, 395);
            this.uiIntegerUpDown2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiIntegerUpDown2.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiIntegerUpDown2.Name = "uiIntegerUpDown2";
            this.uiIntegerUpDown2.Size = new System.Drawing.Size(100, 24);
            this.uiIntegerUpDown2.TabIndex = 22;
            this.uiIntegerUpDown2.Text = "uiIntegerUpDown1";
            this.uiIntegerUpDown2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiIntegerUpDown2.Value = 50;
            // 
            // uiIntegerUpDown3
            // 
            this.uiIntegerUpDown3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiIntegerUpDown3.Location = new System.Drawing.Point(20, 452);
            this.uiIntegerUpDown3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiIntegerUpDown3.MinimumSize = new System.Drawing.Size(100, 0);
            this.uiIntegerUpDown3.Name = "uiIntegerUpDown3";
            this.uiIntegerUpDown3.Size = new System.Drawing.Size(100, 24);
            this.uiIntegerUpDown3.TabIndex = 22;
            this.uiIntegerUpDown3.Text = "uiIntegerUpDown1";
            this.uiIntegerUpDown3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiIntegerUpDown3.Value = 50;
            // 
            // UserControl1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelRight);
            this.Font = new System.Drawing.Font("Century", 12F);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1001, 759);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RightSlide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton View_2D;
        private Sunny.UI.UISymbolButton View_3D;
        private Sunny.UI.UISymbolButton Track_Open;
        private Sunny.UI.UISymbolButton Track_Cls;
        private Sunny.UI.UISymbolButton LocateBtn;
        private System.Windows.Forms.Panel panelRight;
        private Sunny.UI.UIImageButton RightSlide;
        private System.Windows.Forms.Timer timer1;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private Sunny.UI.UICheckBox uiCheckBox1;
        private Sunny.UI.UIImageButton HelpBtn;
        private Sunny.UI.UIIntegerUpDown uiIntegerUpDown1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIDoubleUpDown uiDoubleUpDown1;
        private Sunny.UI.UICheckBox uiCheckBox4;
        private Sunny.UI.UICheckBox uiCheckBox3;
        private Sunny.UI.UICheckBox uiCheckBox2;
        private Sunny.UI.UIIntegerUpDown uiIntegerUpDown3;
        private Sunny.UI.UIIntegerUpDown uiIntegerUpDown2;
    }
}
