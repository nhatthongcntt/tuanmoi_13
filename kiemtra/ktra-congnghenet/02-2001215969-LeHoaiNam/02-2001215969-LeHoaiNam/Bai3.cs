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
    public partial class PC02_969_Bai3 : Form
    {
        public PC02_969_Bai3()
        {
            InitializeComponent();
        }
        private bool kiemTraTrungPB(string s)
        {
            if (PC02_969_cboPB.FindString(s) == -1)
                return false;
            else
                return true;
        }
        private void PC02_969_Bai3_Load(object sender, EventArgs e)
        {
            string[] s = { "Giám Đốc", "Tổ Chức Hành Chính", "Kế Hoạch", "Kế Toán" };
            foreach (string i in s)
            {
                PC02_969_cboPB.Items.Add(i);
                PC02_969_trvPB.Nodes.Add(i);
            }
            PC02_969_cboPB.SelectedIndex = 0;    
        }

        private void PC02_969_btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PC02_969_btnThemPB_Click(object sender, EventArgs e)
        {
            if (PC02_969_txtPB.Text.Trim().Length == 0)
                MessageBox.Show("Chưa nhập", "Lỗi");
            else if (kiemTraTrungPB(PC02_969_txtPB.Text) == true)
                MessageBox.Show("Phòng ban đã tồn tại", "Lỗi");
            
            else
            {
                PC02_969_cboPB.Items.Add(PC02_969_txtPB.Text);
                PC02_969_trvPB.Nodes.Add(PC02_969_txtPB.Text);
                MessageBox.Show("Thêm thành công", "Thông báo");
            }
        }

        private void PC02_969_btnXoaPB_Click(object sender, EventArgs e)
        {
            
        }
    }
}
