﻿namespace ketnoi_sql
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Xoa = new System.Windows.Forms.Button();
            this.button_Sửa = new System.Windows.Forms.Button();
            this.button_Them = new System.Windows.Forms.Button();
            this.textBox_SoLuong = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_GiaTien = new System.Windows.Forms.TextBox();
            this.Label_Sove = new System.Windows.Forms.Label();
            this.textBox_NuocSX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Ten = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 101);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "TênHH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Xoa);
            this.groupBox2.Controls.Add(this.button_Sửa);
            this.groupBox2.Controls.Add(this.button_Them);
            this.groupBox2.Controls.Add(this.textBox_SoLuong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_GiaTien);
            this.groupBox2.Controls.Add(this.Label_Sove);
            this.groupBox2.Controls.Add(this.textBox_NuocSX);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.comboBox_Ten);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(458, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 387);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // button_Xoa
            // 
            this.button_Xoa.AutoSize = true;
            this.button_Xoa.Location = new System.Drawing.Point(179, 339);
            this.button_Xoa.Name = "button_Xoa";
            this.button_Xoa.Size = new System.Drawing.Size(72, 24);
            this.button_Xoa.TabIndex = 12;
            this.button_Xoa.Text = "Xóa";
            this.button_Xoa.UseVisualStyleBackColor = true;
            // 
            // button_Sửa
            // 
            this.button_Sửa.AutoSize = true;
            this.button_Sửa.Location = new System.Drawing.Point(94, 339);
            this.button_Sửa.Name = "button_Sửa";
            this.button_Sửa.Size = new System.Drawing.Size(63, 24);
            this.button_Sửa.TabIndex = 11;
            this.button_Sửa.Text = "Sửa";
            this.button_Sửa.UseVisualStyleBackColor = true;
            // 
            // button_Them
            // 
            this.button_Them.AutoSize = true;
            this.button_Them.Location = new System.Drawing.Point(6, 339);
            this.button_Them.Name = "button_Them";
            this.button_Them.Size = new System.Drawing.Size(63, 24);
            this.button_Them.TabIndex = 10;
            this.button_Them.Text = "Thêm";
            this.button_Them.UseVisualStyleBackColor = true;
            this.button_Them.Click += new System.EventHandler(this.button_Them_Click);
            // 
            // textBox_SoLuong
            // 
            this.textBox_SoLuong.Location = new System.Drawing.Point(91, 218);
            this.textBox_SoLuong.Name = "textBox_SoLuong";
            this.textBox_SoLuong.Size = new System.Drawing.Size(118, 20);
            this.textBox_SoLuong.TabIndex = 9;
            this.textBox_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_SoLuong_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số Lượng";
            // 
            // textBox_GiaTien
            // 
            this.textBox_GiaTien.Location = new System.Drawing.Point(91, 150);
            this.textBox_GiaTien.Name = "textBox_GiaTien";
            this.textBox_GiaTien.ReadOnly = true;
            this.textBox_GiaTien.Size = new System.Drawing.Size(118, 20);
            this.textBox_GiaTien.TabIndex = 7;
            // 
            // Label_Sove
            // 
            this.Label_Sove.AutoSize = true;
            this.Label_Sove.Location = new System.Drawing.Point(19, 157);
            this.Label_Sove.Name = "Label_Sove";
            this.Label_Sove.Size = new System.Drawing.Size(47, 13);
            this.Label_Sove.TabIndex = 6;
            this.Label_Sove.Text = "Giá Tiền";
            // 
            // textBox_NuocSX
            // 
            this.textBox_NuocSX.Location = new System.Drawing.Point(91, 85);
            this.textBox_NuocSX.Name = "textBox_NuocSX";
            this.textBox_NuocSX.ReadOnly = true;
            this.textBox_NuocSX.Size = new System.Drawing.Size(118, 20);
            this.textBox_NuocSX.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "NướcSX";
            // 
            // comboBox_Ten
            // 
            this.comboBox_Ten.FormattingEnabled = true;
            this.comboBox_Ten.Items.AddRange(new object[] {
            "LIFEBOY",
            "HAMBURGER",
            "PEN XANH"});
            this.comboBox_Ten.Location = new System.Drawing.Point(91, 28);
            this.comboBox_Ten.Name = "comboBox_Ten";
            this.comboBox_Ten.Size = new System.Drawing.Size(118, 21);
            this.comboBox_Ten.TabIndex = 3;
            this.comboBox_Ten.SelectedIndexChanged += new System.EventHandler(this.comboBox_Ten_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TênHH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bảng Mua Hàng";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_SoLuong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_GiaTien;
        private System.Windows.Forms.Label Label_Sove;
        private System.Windows.Forms.TextBox textBox_NuocSX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Sửa;
        private System.Windows.Forms.Button button_Them;
        private System.Windows.Forms.Button button_Xoa;
    }
}

