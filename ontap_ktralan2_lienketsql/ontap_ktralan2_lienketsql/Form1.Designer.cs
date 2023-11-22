namespace ontap_ktralan2_lienketsql
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textBox_TimKiemTen = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            textBox_SoLuongVe = new TextBox();
            textBox_TenNuoc = new TextBox();
            textBox_Giave = new TextBox();
            Button_Xoa = new Button();
            button_Sua = new Button();
            button_Them = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            comboBox_Ten = new ComboBox();
            label2 = new Label();
            button_ThongKe = new Button();
            button_Thoat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(202, 12);
            label1.Name = "label1";
            label1.Size = new Size(319, 32);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ DOANH THU";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 167);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(743, 402);
            dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox_TimKiemTen);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(23, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 99);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // textBox_TimKiemTen
            // 
            textBox_TimKiemTen.Location = new Point(103, 35);
            textBox_TimKiemTen.Name = "textBox_TimKiemTen";
            textBox_TimKiemTen.Size = new Size(172, 27);
            textBox_TimKiemTen.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(27, 35);
            label6.Name = "label6";
            label6.Size = new Size(42, 23);
            label6.TabIndex = 3;
            label6.Text = "Tên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox_SoLuongVe);
            groupBox2.Controls.Add(textBox_TenNuoc);
            groupBox2.Controls.Add(textBox_Giave);
            groupBox2.Controls.Add(Button_Xoa);
            groupBox2.Controls.Add(button_Sua);
            groupBox2.Controls.Add(button_Them);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(comboBox_Ten);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(772, 62);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(393, 507);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông Tin";
            // 
            // textBox_SoLuongVe
            // 
            textBox_SoLuongVe.Location = new Point(141, 291);
            textBox_SoLuongVe.Name = "textBox_SoLuongVe";
            textBox_SoLuongVe.Size = new Size(172, 27);
            textBox_SoLuongVe.TabIndex = 11;
            textBox_SoLuongVe.KeyPress += textBox_SoLuongVe_KeyPress;
            // 
            // textBox_TenNuoc
            // 
            textBox_TenNuoc.Location = new Point(141, 211);
            textBox_TenNuoc.Name = "textBox_TenNuoc";
            textBox_TenNuoc.ReadOnly = true;
            textBox_TenNuoc.Size = new Size(172, 27);
            textBox_TenNuoc.TabIndex = 10;
            // 
            // textBox_Giave
            // 
            textBox_Giave.Location = new Point(141, 120);
            textBox_Giave.Name = "textBox_Giave";
            textBox_Giave.ReadOnly = true;
            textBox_Giave.Size = new Size(172, 27);
            textBox_Giave.TabIndex = 9;
            // 
            // Button_Xoa
            // 
            Button_Xoa.AutoSize = true;
            Button_Xoa.BackColor = Color.FromArgb(192, 0, 192);
            Button_Xoa.Location = new Point(293, 446);
            Button_Xoa.Name = "Button_Xoa";
            Button_Xoa.Size = new Size(94, 30);
            Button_Xoa.TabIndex = 8;
            Button_Xoa.Text = "Xóa";
            Button_Xoa.UseVisualStyleBackColor = false;
            // 
            // button_Sua
            // 
            button_Sua.AutoSize = true;
            button_Sua.BackColor = Color.Red;
            button_Sua.Location = new Point(160, 446);
            button_Sua.Name = "button_Sua";
            button_Sua.Size = new Size(94, 30);
            button_Sua.TabIndex = 7;
            button_Sua.Text = "Sửa";
            button_Sua.UseVisualStyleBackColor = false;
            // 
            // button_Them
            // 
            button_Them.AutoSize = true;
            button_Them.BackColor = SystemColors.ActiveCaption;
            button_Them.Location = new Point(15, 446);
            button_Them.Name = "button_Them";
            button_Them.Size = new Size(94, 30);
            button_Them.TabIndex = 6;
            button_Them.Text = "Thêm";
            button_Them.UseVisualStyleBackColor = false;
            button_Them.Click += button_Them_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Control;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(0, 0, 192);
            label5.Location = new Point(15, 295);
            label5.Name = "label5";
            label5.Size = new Size(120, 23);
            label5.TabIndex = 5;
            label5.Text = "Số Lượng Vé";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Control;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(16, 211);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 4;
            label4.Text = "Tên Nước";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Control;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 192);
            label3.Location = new Point(16, 124);
            label3.Name = "label3";
            label3.Size = new Size(69, 23);
            label3.TabIndex = 3;
            label3.Text = "Giá Vé";
            // 
            // comboBox_Ten
            // 
            comboBox_Ten.FormattingEnabled = true;
            comboBox_Ten.Items.AddRange(new object[] { "CAULACBOA", "CAULACBOB", "CAULACBOC", "CAULACBOD", "CAULACBOE", "CAULACBOF" });
            comboBox_Ten.Location = new Point(141, 39);
            comboBox_Ten.Name = "comboBox_Ten";
            comboBox_Ten.Size = new Size(172, 28);
            comboBox_Ten.TabIndex = 2;
            comboBox_Ten.SelectedIndexChanged += comboBox_Ten_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(15, 39);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 0;
            label2.Text = "Tên";
            // 
            // button_ThongKe
            // 
            button_ThongKe.AutoSize = true;
            button_ThongKe.Location = new Point(932, 12);
            button_ThongKe.Name = "button_ThongKe";
            button_ThongKe.Size = new Size(94, 30);
            button_ThongKe.TabIndex = 12;
            button_ThongKe.Text = "Thống Kê";
            button_ThongKe.UseVisualStyleBackColor = true;
            // 
            // button_Thoat
            // 
            button_Thoat.AutoSize = true;
            button_Thoat.Location = new Point(1065, 12);
            button_Thoat.Name = "button_Thoat";
            button_Thoat.Size = new Size(94, 30);
            button_Thoat.TabIndex = 12;
            button_Thoat.Text = "Thoát";
            button_Thoat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 581);
            Controls.Add(button_Thoat);
            Controls.Add(button_ThongKe);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox textBox_SoLuongVe;
        private TextBox textBox_TenNuoc;
        private TextBox textBox_Giave;
        private Button Button_Xoa;
        private Button button_Sua;
        private Button button_Them;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox comboBox_Ten;
        private Label label2;
        private Label label6;
        private Button button_ThongKe;
        private Button button_Thoat;
        private TextBox textBox_TimKiemTen;
    }
}