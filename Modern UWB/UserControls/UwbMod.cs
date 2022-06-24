using Modern_UWB.UserControls.Mod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_UWB.UserControls
{
    public partial class UwbMod : UserControl
    {
        public UwbMod()
        {
            InitializeComponent();
            UavMod uav = new UavMod();
            AddControlsToPanel(uav);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelMod.Controls.Clear();
            panelMod.Controls.Add(c);
        }
        private void uav_click(object sender, EventArgs e)
        {
            UavMod uav = new UavMod();
            AddControlsToPanel(uav);
            this.UavBtn.Visible = false;
            this.UavBtnC.Visible = true;
            this.UavBtnC.Selected = true;
            //ugv不见
            this.UgvBtn.Visible = true;
            this.UgvBtnC.Visible = false;
            this.UgvBtn.Selected = false;
        }

        private void UgvBtn_Click(object sender, EventArgs e)
        {
            UgvMod uav = new UgvMod();
            AddControlsToPanel(uav);
            this.UgvBtn.Visible = false;
            this.UgvBtnC.Visible = true;
            this.UgvBtnC.Selected = true;
            //uav不见
            this.UavBtn.Visible = true;
            this.UavBtnC.Visible = false;
            this.UavBtn.Selected = false;
        }
    }
}
