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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void Bai2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void PC02_969_txtArray_TextChanged(object sender, EventArgs e)
        {

        }
        M1C array;
        private void PC02_969_btnInputArray_Click(object sender, EventArgs e)
        {
            if (PC02_969_txtArray.Text.Trim().Length == 0)
                MessageBox.Show("Chưa nhập mảng","Lỗi");
            else
            {
                string[] s = PC02_969_txtArray.Text.Split(' ');
                int n = s.Length;
                int[] arr = new int[n];
                for(int i = 0;i < n;i++)
                {
                    arr[i] = int.Parse(s[i]);
                }
                array = new M1C(arr);
                PC02_969_txtArray.Text = "";
                PC02_969_kqArray.Text = array.showMang();
            }
        }

        private void PC02_969_txtArray_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void PC02_969_btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PC02_969_btnReset_Click(object sender, EventArgs e)
        {
            PC02_969_kqArray.Text = "";
            PC02_969_txtArray.Text = "";
        }

        private void PC02_969_btnSapXep_Click(object sender, EventArgs e)
        {
            if (array == null)
                MessageBox.Show("Chưa nhập mảng","Lỗi");
            else if (PC02_969_rdoSXTang.Checked == true)
                PC02_969_kqArray.Text = array.SXTang();
            else
                PC02_969_kqArray.Text = array.SXGiam();
        }

        

        private void PC02_969_rdoSearchValue_CheckedChanged(object sender, EventArgs e)
        {
            if (PC02_969_rdoSearchValue.Checked == true)
                PC02_969_txtSearchValue.Enabled = true;
            else
            {
                PC02_969_txtSearchValue.Enabled = false;
                PC02_969_txtSearchValue.Text = "";
            }
        }

        private void PC02_969_rdoSearchIndex_CheckedChanged(object sender, EventArgs e)
        {
            if (PC02_969_rdoSearchIndex.Checked == true)
                PC02_969_txtSearchIndex.Enabled = true;
            else
            {
                PC02_969_txtSearchIndex.Enabled = false;
                PC02_969_txtSearchIndex.Text = "";
            }
        }

        private void PC02_969_rdoSeach_Click(object sender, EventArgs e)
        {
            if (PC02_969_rdoSearchValue.Checked == true && PC02_969_txtSearchValue.Text.Trim().Length != 0)
            {
                if (array.timGiaTri(int.Parse(PC02_969_txtSearchValue.Text)) == true)
                    MessageBox.Show("Tồn tại", "Thông báo");
                else
                {
                    MessageBox.Show("Không tồn tại", "Thông báo");
                }
            }
            else if (PC02_969_rdoSearchIndex.Checked == true && PC02_969_txtSearchIndex.Text.Trim().Length != 0)
            {
                if (int.Parse(PC02_969_txtSearchIndex.Text) >= array.n())
                    MessageBox.Show("Vị trí không tồn tại", "Thông báo");
                else
                    PC02_969_kqSearch.Text = array.timViTri(int.Parse(PC02_969_txtSearchIndex.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Chưa chọn lựa chọn hoặc chưa điền giá trị", "Lỗi");
                PC02_969_kqSearch.Text = "";
            }
        }

        private void PC02_969_btnTong_Click(object sender, EventArgs e)
        {
            if (array == null)
                MessageBox.Show("Lỗi chưa nhập mảng", "Lỗi");
            else
            {
                PC02_969_kqTongMang.Text = array.TongMang().ToString();
                PC02_969_kqTongChan.Text = array.TongChan().ToString();
            }
        }
    }
}
