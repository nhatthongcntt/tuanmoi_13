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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void câu1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai1 f = new Bai1();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void câu2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bai2 f = new Bai2();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void câu3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PC02_969_Bai3 f = new PC02_969_Bai3();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
