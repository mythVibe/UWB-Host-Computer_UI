using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UWB.UserControls;
using UWB.Forms.location;
using System.Runtime.InteropServices;
using Guna.UI2.WinForms;

namespace UWB.Forms
{
    public partial class Form_LeftBar : Form
    {
        int PanelWidth;
        bool isCollapsed;
        
        public Form_LeftBar()
        {
            InitializeComponent();
            timerTime.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
            UC_Com uch = new UC_Com();
            AddControlsToPanel(uch);
            this.Text = String.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //拖动窗口
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] 
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void label2_Click(object sender, EventArgs e)
        {

        }
        /*列表功能，左侧功能栏*/
        private void button6_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 20;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else 
            {
                panelLeft.Width = panelLeft.Width - 20;
                if (panelLeft.Width <= 59) 
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();

                }
            }
        }
/*
        private void moveSidePanel(Control btn) 
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }
*/
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btnCom_Click(object sender, EventArgs e)
        {

            UC_Com uc = new UC_Com();
            AddControlsToPanel(uc);
            this.pictureBox2.Visible = true;
        }

        private void btnLocate_Click(object sender, EventArgs e)
        {

            UserControl1 uch = new UserControl1();
            AddControlsToPanel(uch);
        }

        private void btnDataT_Click(object sender, EventArgs e)
        {

        }

        private void btnUAV_Click(object sender, EventArgs e)
        {

        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void Form_LeftBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112,0xf012,0);

        }
        //标题panel实现拖动
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelHead_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelControls_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //窗体小控件实现最小化，最大化，关闭；

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imgSlide.Location = new Point(b.Location.X + 121, b.Location.Y - 28);
            imgSlide.SendToBack();
        }

        private void guna2Button4_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            this.uiSymbolButton2.Selected = true;
            this.uiSymbolButton1.Selected = false;
        }
    }
}
