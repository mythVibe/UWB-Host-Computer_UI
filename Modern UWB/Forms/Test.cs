using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_UWB.Forms
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void CA_Click(object sender, EventArgs e)
        {
            this.BtnComA.Visible = false;
            this.BtnComB.Visible = true;
            this.BtnComB.Selected = true;
            //白色不见
            this.BtnLocateB.Visible = false;
            this.BtnDataB.Visible = false;
            this.BtnUavB.Visible = false;
            this.BtnUavB.Selected = false;
            this.BtnLocateB.Selected = false;
            this.BtnDataB.Selected = false;
            //蓝色显露
            this.BtnUavA.Visible = true;
            this.BtnLocateA.Visible = true;
            this.BtnDataA.Visible = true;
        }

        private void LA_Click(object sender, EventArgs e)
        {
            this.BtnLocateA.Visible = false;
            this.BtnLocateB.Visible = true;
            this.BtnDataB.Visible = false;
            this.BtnLocateB.Selected = true;
            //白色不见
            this.BtnComB.Visible = false;
            this.BtnDataB.Visible = false;
            this.BtnUavB.Visible = false;
            this.BtnUavB.Selected = false;
            this.BtnComB.Selected = false;
            this.BtnDataB.Selected = false;
            //蓝色显露
            this.BtnUavA.Visible = true;
            this.BtnComA.Visible = true;
            this.BtnDataA.Visible = true;
        }

        private void DA_Click(object sender, EventArgs e)
        {
            this.BtnDataA.Visible = false;
            this.BtnDataB.Visible = true;
            this.BtnDataB.Selected = true;
            //白色不见
            this.BtnComB.Visible = false;
            this.BtnLocateB.Visible = false;
            this.BtnUavB.Visible = false;
            this.BtnUavB.Selected = false;
            this.BtnLocateB.Selected = false;
            this.BtnComB.Selected = false;
            //蓝色显露
            this.BtnUavA.Visible = true;
            this.BtnComA.Visible = true;
            this.BtnLocateA.Visible = true;
        }

        private void UA_Click(object sender, EventArgs e)
        {
            this.BtnUavA.Visible = false;
            this.BtnUavB.Visible = true;
            this.BtnUavB.Selected = true;
            //白色不见
            this.BtnComB.Visible = false;
            this.BtnLocateB.Visible = false;
            this.BtnDataB.Visible = false;
            this.BtnComB.Selected = false;
            this.BtnLocateB.Selected = false;
            this.BtnDataB.Selected = false;
            //蓝色显露
            this.BtnDataA.Visible = true;
            this.BtnComA.Visible = true;
            this.BtnLocateA.Visible = true;
        }
    }
}
