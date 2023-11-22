using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_2001215969_LeHoaiNam
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void PC02_969_rdoBac2_CheckedChanged(object sender, EventArgs e)
        {
            PC02_969_txtC.Enabled = true;
            PC02_969_lbC.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PC02_969_rdoBac1_CheckedChanged(object sender, EventArgs e)
        {
            PC02_969_txtC.Enabled = false;
            PC02_969_lbC.Enabled = false;
            PC02_969_txtC.Text = "";
        }

        private void PC02_969_btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PC02_969_txtA_TextChanged(object sender, EventArgs e)
        {
            if(PC02_969_rdoBac1.Checked == true)
            {
                if (PC02_969_txtB.Text != "")
                    PC02_969_btnGiai.Enabled = true;
            }
            else
            {
                if (PC02_969_txtC.Text != "" && PC02_969_txtB.Text != "")
                    PC02_969_btnGiai.Enabled = true;
            }
            
        }

        private void PC02_969_txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }

        private void PC02_969_txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }

        private void PC02_969_txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '-')
                e.Handled = true;
        }

        private void PC02_969_txtB_TextChanged(object sender, EventArgs e)
        {
            if (PC02_969_rdoBac1.Checked == true)
            {
                if (PC02_969_txtA.Text != "")
                    PC02_969_btnGiai.Enabled = true;
            }
            else
            {
                if (PC02_969_txtC.Text != "" && PC02_969_txtA.Text != "")
                    PC02_969_btnGiai.Enabled = true;
            }
        }

        private void PC02_969_txtC_TextChanged(object sender, EventArgs e)
        {
            if (PC02_969_txtA.Text != "" && PC02_969_txtB.Text != "")
                PC02_969_btnGiai.Enabled = true;
        }

        private void PC02_969_btnGiai_Click(object sender, EventArgs e)
        {
            if(PC02_969_rdoBac1.Checked == true)
            {
                
                PC02_969_result.Text = "Phương trình có nghiệm x = " + (-int.Parse(PC02_969_txtB.Text)/int.Parse(PC02_969_txtA.Text)).ToString();
            }
            else
            {
                PhuongTrinhBacHai pt2 = new PhuongTrinhBacHai(int.Parse(PC02_969_txtA.Text), int.Parse(PC02_969_txtB.Text), int.Parse(PC02_969_txtC.Text));
                PC02_969_result.Text = pt2.KQ();
            }
        }
    }
    //PC02_969_
}
