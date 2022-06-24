
namespace Modern_UWB.UserControls
{
    partial class UwbMod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UwbMod));
            this.UavBtn = new Sunny.UI.UISymbolButton();
            this.UgvBtn = new Sunny.UI.UISymbolButton();
            this.elipseControl1 = new ElipseToolDemo.ElipseControl();
            this.panelMod = new System.Windows.Forms.Panel();
            this.elipseControl2 = new ElipseToolDemo.ElipseControl();
            this.UgvBtnC = new Sunny.UI.UISymbolButton();
            this.UavBtnC = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // UavBtn
            // 
            this.UavBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UavBtn.FillColor = System.Drawing.Color.White;
            this.UavBtn.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UavBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UavBtn.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UavBtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UavBtn.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UavBtn.Image = ((System.Drawing.Image)(resources.GetObject("UavBtn.Image")));
            this.UavBtn.Location = new System.Drawing.Point(26, 37);
            this.UavBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.UavBtn.Name = "UavBtn";
            this.UavBtn.RectColor = System.Drawing.Color.Transparent;
            this.UavBtn.RectDisableColor = System.Drawing.Color.Transparent;
            this.UavBtn.RectHoverColor = System.Drawing.Color.Transparent;
            this.UavBtn.RectPressColor = System.Drawing.Color.Transparent;
            this.UavBtn.RectSelectedColor = System.Drawing.Color.Transparent;
            this.UavBtn.Size = new System.Drawing.Size(112, 46);
            this.UavBtn.Style = Sunny.UI.UIStyle.Custom;
            this.UavBtn.TabIndex = 0;
            this.UavBtn.Text = "无人机";
            this.UavBtn.Visible = false;
            this.UavBtn.Click += new System.EventHandler(this.uav_click);
            // 
            // UgvBtn
            // 
            this.UgvBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UgvBtn.FillColor = System.Drawing.Color.White;
            this.UgvBtn.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UgvBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UgvBtn.ForeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UgvBtn.ForePressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UgvBtn.ForeSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UgvBtn.Image = ((System.Drawing.Image)(resources.GetObject("UgvBtn.Image")));
            this.UgvBtn.Location = new System.Drawing.Point(169, 37);
            this.UgvBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.UgvBtn.Name = "UgvBtn";
            this.UgvBtn.RectColor = System.Drawing.Color.Transparent;
            this.UgvBtn.RectDisableColor = System.Drawing.Color.Transparent;
            this.UgvBtn.RectHoverColor = System.Drawing.Color.Transparent;
            this.UgvBtn.RectPressColor = System.Drawing.Color.Transparent;
            this.UgvBtn.RectSelectedColor = System.Drawing.Color.Transparent;
            this.UgvBtn.Size = new System.Drawing.Size(129, 46);
            this.UgvBtn.Style = Sunny.UI.UIStyle.Custom;
            this.UgvBtn.TabIndex = 1;
            this.UgvBtn.Text = "无人车";
            this.UgvBtn.Click += new System.EventHandler(this.UgvBtn_Click);
            // 
            // elipseControl1
            // 
            this.elipseControl1.CornerRadius = 30;
            this.elipseControl1.TargetControl = this;
            // 
            // panelMod
            // 
            this.panelMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.panelMod.Location = new System.Drawing.Point(14, 82);
            this.panelMod.Name = "panelMod";
            this.panelMod.Size = new System.Drawing.Size(973, 658);
            this.panelMod.TabIndex = 4;
            // 
            // elipseControl2
            // 
            this.elipseControl2.CornerRadius = 30;
            this.elipseControl2.TargetControl = this.panelMod;
            // 
            // UgvBtnC
            // 
            this.UgvBtnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UgvBtnC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UgvBtnC.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UgvBtnC.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UgvBtnC.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UgvBtnC.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UgvBtnC.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UgvBtnC.Image = ((System.Drawing.Image)(resources.GetObject("UgvBtnC.Image")));
            this.UgvBtnC.Location = new System.Drawing.Point(169, 37);
            this.UgvBtnC.MinimumSize = new System.Drawing.Size(1, 1);
            this.UgvBtnC.Name = "UgvBtnC";
            this.UgvBtnC.RectColor = System.Drawing.Color.Transparent;
            this.UgvBtnC.RectDisableColor = System.Drawing.Color.Transparent;
            this.UgvBtnC.RectHoverColor = System.Drawing.Color.Transparent;
            this.UgvBtnC.RectPressColor = System.Drawing.Color.Transparent;
            this.UgvBtnC.RectSelectedColor = System.Drawing.Color.Transparent;
            this.UgvBtnC.Size = new System.Drawing.Size(129, 46);
            this.UgvBtnC.Style = Sunny.UI.UIStyle.Custom;
            this.UgvBtnC.TabIndex = 6;
            this.UgvBtnC.Text = "无人车";
            this.UgvBtnC.Visible = false;
            // 
            // UavBtnC
            // 
            this.UavBtnC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UavBtnC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UavBtnC.FillDisableColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UavBtnC.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UavBtnC.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UavBtnC.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.UavBtnC.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UavBtnC.Image = ((System.Drawing.Image)(resources.GetObject("UavBtnC.Image")));
            this.UavBtnC.Location = new System.Drawing.Point(26, 37);
            this.UavBtnC.MinimumSize = new System.Drawing.Size(1, 1);
            this.UavBtnC.Name = "UavBtnC";
            this.UavBtnC.RectColor = System.Drawing.Color.Transparent;
            this.UavBtnC.RectDisableColor = System.Drawing.Color.Transparent;
            this.UavBtnC.RectHoverColor = System.Drawing.Color.Transparent;
            this.UavBtnC.RectPressColor = System.Drawing.Color.Transparent;
            this.UavBtnC.RectSelectedColor = System.Drawing.Color.Transparent;
            this.UavBtnC.Selected = true;
            this.UavBtnC.Size = new System.Drawing.Size(112, 46);
            this.UavBtnC.Style = Sunny.UI.UIStyle.Custom;
            this.UavBtnC.TabIndex = 5;
            this.UavBtnC.Text = "无人机";
            // 
            // UwbMod
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UgvBtnC);
            this.Controls.Add(this.UavBtnC);
            this.Controls.Add(this.panelMod);
            this.Controls.Add(this.UgvBtn);
            this.Controls.Add(this.UavBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "UwbMod";
            this.Size = new System.Drawing.Size(1001, 759);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton UavBtn;
        private Sunny.UI.UISymbolButton UgvBtn;
        private ElipseToolDemo.ElipseControl elipseControl1;
        private System.Windows.Forms.Panel panelMod;
        private ElipseToolDemo.ElipseControl elipseControl2;
        private Sunny.UI.UISymbolButton UgvBtnC;
        private Sunny.UI.UISymbolButton UavBtnC;
    }
}
