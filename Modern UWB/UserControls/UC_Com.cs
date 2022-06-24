using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace UWB.UserControls
{
    public partial class UC_Com : UserControl
    {
        public UC_Com()
        {
            InitializeComponent();
        }
        //拖动窗口
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void UC_Com_Load(object sender, EventArgs e)
        {
            Int16 i, j;
            this.dataGridView_TAG.Rows.Add(); //添加行
            for (j = 0; j < 12; j++)
            {
                this.dataGridView_TAG.Rows[0].Cells[j].Value = 0;
            }
            //设置为只读
            dataGridView_TAG.Columns[0].ReadOnly = true;
            //设置标题头为不可排序
            for (int cN = 0; cN < this.dataGridView_TAG.Columns.Count; cN++)

            {
                this.dataGridView_TAG.Columns[cN].SortMode = DataGridViewColumnSortMode.NotSortable;

            }
            for (i = 0; i < 8; i++)
            {
                this.dataGridView_BS_SET.Rows.Add();  //添加行
            }

            this.dataGridView_BS_SET.Rows[0].Cells[0].Value = "    A基站";
            this.dataGridView_BS_SET.Rows[1].Cells[0].Value = "    B基站";
            this.dataGridView_BS_SET.Rows[2].Cells[0].Value = "    C基站";
            this.dataGridView_BS_SET.Rows[3].Cells[0].Value = "    D基站";
            this.dataGridView_BS_SET.Rows[4].Cells[0].Value = "    E基站";
            this.dataGridView_BS_SET.Rows[5].Cells[0].Value = "    F基站";
            this.dataGridView_BS_SET.Rows[6].Cells[0].Value = "    G基站";
            this.dataGridView_BS_SET.Rows[7].Cells[0].Value = "    H基站";
            //设置为只读
            dataGridView_BS_SET.Columns[0].ReadOnly = true;
            //设置标题头为不可排序
            for (int cN = 0; cN < this.dataGridView_BS_SET.Columns.Count; cN++)

            {
                this.dataGridView_BS_SET.Columns[cN].SortMode = DataGridViewColumnSortMode.NotSortable;

            }

        }

        private void setcomBtN_Click(object sender, EventArgs e)
        {
            using (ComSet uf = new ComSet())
            {
                uf.ShowDialog();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_BS_SET_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //拖动窗口
    }
}
