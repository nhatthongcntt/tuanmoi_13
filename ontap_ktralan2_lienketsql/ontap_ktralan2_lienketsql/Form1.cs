using System.Linq.Expressions;

namespace ontap_ktralan2_lienketsql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        QL_DoanhThu quanly;
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = modify.Table("Select * From CLB");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            DeleleTextBoxes();
        }

        private void comboBox_Ten_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Ten.SelectedIndex == 0)
            {
                textBox_Giave.Text = "10";
                textBox_TenNuoc.Text = "ANH";
            }
            if (comboBox_Ten.SelectedIndex == 1)
            {
                textBox_Giave.Text = "12";
                textBox_TenNuoc.Text = "PHÁP";
            }
            if (comboBox_Ten.SelectedIndex == 2)
            {
                textBox_Giave.Text = "10";
                textBox_TenNuoc.Text = "ĐỨC";
            }
            if (comboBox_Ten.SelectedIndex == 3)
            {
                textBox_Giave.Text = "7";
                textBox_TenNuoc.Text = "Ý";
            }
            if (comboBox_Ten.SelectedIndex == 4)
            {
                textBox_Giave.Text = "12";
                textBox_TenNuoc.Text = "NHẬT BẢN";
            }
            if (comboBox_Ten.SelectedIndex == 5)
            {
                textBox_Giave.Text = "10";
                textBox_TenNuoc.Text = "MỸ";
            }
        }

        private void textBox_SoLuongVe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else { e.Handled = true; }
        }

        private void DeleleTextBoxes()
        {
            comboBox_Ten.SelectedIndex = -1;
            textBox_TenNuoc.Text = "";
            textBox_Giave.Text = "";
            textBox_SoLuongVe.Text = "";
        }
        private bool CheckTextBoxes()
        {
            if(comboBox_Ten.SelectedIndex==-1)
            { MessageBox.Show("Mời bạn chọn câu lạc bộ");
                return false;
            }
            if (textBox_SoLuongVe.Text== "")
            {
                MessageBox.Show("Mời bạn nhập số lượng vé");
                return false;
            }
            return true;
        }
        private void GetValuesTextBoxes()
        {
            string _tencaulacbo = comboBox_Ten.Text;
            string _tennuoc = textBox_TenNuoc.Text;
            int _soluongve = int.Parse(textBox_SoLuongVe.Text);
            double _giave= double.Parse(textBox_Giave.Text);
            quanly = new QL_DoanhThu(_tencaulacbo,_tennuoc,_soluongve,_giave) ;
        }
        private void button_Them_Click(object sender, EventArgs e)
        {
            if(CheckTextBoxes())
            {
                GetValuesTextBoxes();
                string query1 = "INSERT INTO CLB VALUES('"+quanly.Tencaulacbo +"','"+quanly.Tennuoc +"','"+ quanly.Giave+"','"+quanly.Soluongve +"','"+quanly.DoanhThu()+"')";
                try
                {if(MessageBox.Show("Bạn có muốn thêm không ?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                    modify.Command(query1);
                    MessageBox.Show("Thêm thành công");
                    Form1_Load(sender,e);   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("lỗi thêm vào"+ex.Message);
                }
            }
            
        }
    }
}