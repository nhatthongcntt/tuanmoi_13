﻿namespace _02_2001215969_LeHoaiNam
{
    partial class Bai1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PC02_969_rdoBac2 = new System.Windows.Forms.RadioButton();
            this.PC02_969_rdoBac1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PC02_969_lbC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PC02_969_txtA = new System.Windows.Forms.TextBox();
            this.PC02_969_txtB = new System.Windows.Forms.TextBox();
            this.PC02_969_txtC = new System.Windows.Forms.TextBox();
            this.PC02_969_result = new System.Windows.Forms.TextBox();
            this.PC02_969_btnGiai = new System.Windows.Forms.Button();
            this.PC02_969_btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(77, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PC02_969_rdoBac2);
            this.groupBox1.Controls.Add(this.PC02_969_rdoBac1);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 68);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bạn vui lòng chọn";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // PC02_969_rdoBac2
            // 
            this.PC02_969_rdoBac2.AutoSize = true;
            this.PC02_969_rdoBac2.Location = new System.Drawing.Point(6, 39);
            this.PC02_969_rdoBac2.Name = "PC02_969_rdoBac2";
            this.PC02_969_rdoBac2.Size = new System.Drawing.Size(123, 17);
            this.PC02_969_rdoBac2.TabIndex = 1;
            this.PC02_969_rdoBac2.Text = "Phương trình bậc hai";
            this.PC02_969_rdoBac2.UseVisualStyleBackColor = true;
            this.PC02_969_rdoBac2.CheckedChanged += new System.EventHandler(this.PC02_969_rdoBac2_CheckedChanged);
            // 
            // PC02_969_rdoBac1
            // 
            this.PC02_969_rdoBac1.AutoSize = true;
            this.PC02_969_rdoBac1.Checked = true;
            this.PC02_969_rdoBac1.Location = new System.Drawing.Point(6, 16);
            this.PC02_969_rdoBac1.Name = "PC02_969_rdoBac1";
            this.PC02_969_rdoBac1.Size = new System.Drawing.Size(130, 17);
            this.PC02_969_rdoBac1.TabIndex = 0;
            this.PC02_969_rdoBac1.TabStop = true;
            this.PC02_969_rdoBac1.Text = "Phương trình bậc nhất";
            this.PC02_969_rdoBac1.UseVisualStyleBackColor = true;
            this.PC02_969_rdoBac1.CheckedChanged += new System.EventHandler(this.PC02_969_rdoBac1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập b";
            // 
            // PC02_969_lbC
            // 
            this.PC02_969_lbC.AutoSize = true;
            this.PC02_969_lbC.Enabled = false;
            this.PC02_969_lbC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PC02_969_lbC.Location = new System.Drawing.Point(14, 176);
            this.PC02_969_lbC.Name = "PC02_969_lbC";
            this.PC02_969_lbC.Size = new System.Drawing.Size(59, 20);
            this.PC02_969_lbC.TabIndex = 4;
            this.PC02_969_lbC.Text = "Nhập c";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kết quả";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PC02_969_txtA
            // 
            this.PC02_969_txtA.Location = new System.Drawing.Point(81, 103);
            this.PC02_969_txtA.Name = "PC02_969_txtA";
            this.PC02_969_txtA.Size = new System.Drawing.Size(131, 20);
            this.PC02_969_txtA.TabIndex = 6;
            this.PC02_969_txtA.TextChanged += new System.EventHandler(this.PC02_969_txtA_TextChanged);
            this.PC02_969_txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PC02_969_txtA_KeyPress);
            // 
            // PC02_969_txtB
            // 
            this.PC02_969_txtB.Location = new System.Drawing.Point(81, 140);
            this.PC02_969_txtB.Name = "PC02_969_txtB";
            this.PC02_969_txtB.Size = new System.Drawing.Size(131, 20);
            this.PC02_969_txtB.TabIndex = 7;
            this.PC02_969_txtB.TextChanged += new System.EventHandler(this.PC02_969_txtB_TextChanged);
            this.PC02_969_txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PC02_969_txtB_KeyPress);
            // 
            // PC02_969_txtC
            // 
            this.PC02_969_txtC.Enabled = false;
            this.PC02_969_txtC.Location = new System.Drawing.Point(81, 178);
            this.PC02_969_txtC.Name = "PC02_969_txtC";
            this.PC02_969_txtC.Size = new System.Drawing.Size(131, 20);
            this.PC02_969_txtC.TabIndex = 8;
            this.PC02_969_txtC.TextChanged += new System.EventHandler(this.PC02_969_txtC_TextChanged);
            this.PC02_969_txtC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PC02_969_txtC_KeyPress);
            // 
            // PC02_969_result
            // 
            this.PC02_969_result.Enabled = false;
            this.PC02_969_result.Location = new System.Drawing.Point(81, 218);
            this.PC02_969_result.Multiline = true;
            this.PC02_969_result.Name = "PC02_969_result";
            this.PC02_969_result.Size = new System.Drawing.Size(220, 58);
            this.PC02_969_result.TabIndex = 9;
            // 
            // PC02_969_btnGiai
            // 
            this.PC02_969_btnGiai.Enabled = false;
            this.PC02_969_btnGiai.Location = new System.Drawing.Point(226, 101);
            this.PC02_969_btnGiai.Name = "PC02_969_btnGiai";
            this.PC02_969_btnGiai.Size = new System.Drawing.Size(75, 39);
            this.PC02_969_btnGiai.TabIndex = 10;
            this.PC02_969_btnGiai.Text = "Giải";
            this.PC02_969_btnGiai.UseVisualStyleBackColor = true;
            // 
            // PC02_969_btnExit
            // 
            this.PC02_969_btnExit.Location = new System.Drawing.Point(226, 157);
            this.PC02_969_btnExit.Name = "PC02_969_btnExit";
            this.PC02_969_btnExit.Size = new System.Drawing.Size(75, 39);
            this.PC02_969_btnExit.TabIndex = 11;
            this.PC02_969_btnExit.Text = "Thoát";
            this.PC02_969_btnExit.UseVisualStyleBackColor = true;
            this.PC02_969_btnExit.Click += new System.EventHandler(this.PC02_969_btnExit_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 288);
            this.Controls.Add(this.PC02_969_btnExit);
            this.Controls.Add(this.PC02_969_btnGiai);
            this.Controls.Add(this.PC02_969_result);
            this.Controls.Add(this.PC02_969_txtC);
            this.Controls.Add(this.PC02_969_txtB);
            this.Controls.Add(this.PC02_969_txtA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PC02_969_lbC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Bai1";
            this.Text = "Bai1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton PC02_969_rdoBac2;
        private System.Windows.Forms.RadioButton PC02_969_rdoBac1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PC02_969_lbC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PC02_969_txtA;
        private System.Windows.Forms.TextBox PC02_969_txtB;
        private System.Windows.Forms.TextBox PC02_969_txtC;
        private System.Windows.Forms.TextBox PC02_969_result;
        private System.Windows.Forms.Button PC02_969_btnGiai;
        private System.Windows.Forms.Button PC02_969_btnExit;
    }
}

