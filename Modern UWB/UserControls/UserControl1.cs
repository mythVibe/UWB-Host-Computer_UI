using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UWB.Forms.location
{
    public partial class UserControl1 : UserControl
    {
        int PanelWidth;
        bool isCollapsed;
        public UserControl1()
        {
            InitializeComponent();
            PanelWidth = panelRight.Width;
            isCollapsed = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown4_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void RightSlide_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelRight.Width = panelRight.Width + 20;
                if (panelRight.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelRight.Width = panelRight.Width - 20;
                if (panelRight.Width <= 100)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();

                }
            }
        }

        private void View_Open_Click(object sender, EventArgs e)
        {
            this.View_2D.Visible = false;
            this.View_3D.Visible = true;
        }
        private void View_Cls_Click(object sender, EventArgs e)
        {
            this.View_3D.Visible = false;
            this.View_2D.Visible = true;
        }
        private void Track_Open_Click(object sender, EventArgs e)
        {
            this.Track_Open.Visible = false;
            this.Track_Cls.Visible = true;
        }

        private void Track_Cls_Click(object sender, EventArgs e)
        {
            this.Track_Cls.Visible = false;
            this.Track_Open.Visible = true;
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uiDoubleUpDown1_ValueChanged(object sender, double value)
        {

        }
    }
}
