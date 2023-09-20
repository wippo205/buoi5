namespace _2001207444_NguyenHuuDai
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
            this.Cong_btn = new System.Windows.Forms.Button();
            this.Tru_btn = new System.Windows.Forms.Button();
            this.Nhan_btn = new System.Windows.Forms.Button();
            this.Chia_btn = new System.Windows.Forms.Button();
            this.label_b = new System.Windows.Forms.Label();
            this.label_ketqua = new System.Windows.Forms.Label();
            this.label_a = new System.Windows.Forms.Label();
            this.textBox_a = new System.Windows.Forms.TextBox();
            this.textBox_b = new System.Windows.Forms.TextBox();
            this.textBox_ketqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Cong_btn
            // 
            this.Cong_btn.Location = new System.Drawing.Point(30, 211);
            this.Cong_btn.Name = "Cong_btn";
            this.Cong_btn.Size = new System.Drawing.Size(75, 23);
            this.Cong_btn.TabIndex = 0;
            this.Cong_btn.Text = "+";
            this.Cong_btn.UseVisualStyleBackColor = true;
            this.Cong_btn.Click += new System.EventHandler(this.Cong_btn_Click);
            // 
            // Tru_btn
            // 
            this.Tru_btn.Location = new System.Drawing.Point(133, 211);
            this.Tru_btn.Name = "Tru_btn";
            this.Tru_btn.Size = new System.Drawing.Size(75, 23);
            this.Tru_btn.TabIndex = 1;
            this.Tru_btn.Text = "-";
            this.Tru_btn.UseVisualStyleBackColor = true;
            this.Tru_btn.Click += new System.EventHandler(this.Tru_btn_Click);
            // 
            // Nhan_btn
            // 
            this.Nhan_btn.Location = new System.Drawing.Point(235, 211);
            this.Nhan_btn.Name = "Nhan_btn";
            this.Nhan_btn.Size = new System.Drawing.Size(75, 23);
            this.Nhan_btn.TabIndex = 2;
            this.Nhan_btn.Text = "x";
            this.Nhan_btn.UseVisualStyleBackColor = true;
            this.Nhan_btn.Click += new System.EventHandler(this.Nhan_btn_Click);
            // 
            // Chia_btn
            // 
            this.Chia_btn.Location = new System.Drawing.Point(336, 211);
            this.Chia_btn.Name = "Chia_btn";
            this.Chia_btn.Size = new System.Drawing.Size(75, 23);
            this.Chia_btn.TabIndex = 3;
            this.Chia_btn.Text = "/";
            this.Chia_btn.UseVisualStyleBackColor = true;
            this.Chia_btn.Click += new System.EventHandler(this.Chia_btn_Click);
            // 
            // label_b
            // 
            this.label_b.AutoSize = true;
            this.label_b.Location = new System.Drawing.Point(219, 47);
            this.label_b.Name = "label_b";
            this.label_b.Size = new System.Drawing.Size(28, 17);
            this.label_b.TabIndex = 5;
            this.label_b.Text = "b =";
            this.label_b.Click += new System.EventHandler(this.label_b_Click);
            // 
            // label_ketqua
            // 
            this.label_ketqua.AutoSize = true;
            this.label_ketqua.Location = new System.Drawing.Point(48, 135);
            this.label_ketqua.Name = "label_ketqua";
            this.label_ketqua.Size = new System.Drawing.Size(65, 17);
            this.label_ketqua.TabIndex = 6;
            this.label_ketqua.Text = "Kết quả :";
            // 
            // label_a
            // 
            this.label_a.AutoSize = true;
            this.label_a.Location = new System.Drawing.Point(48, 47);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(32, 17);
            this.label_a.TabIndex = 7;
            this.label_a.Text = "a = ";
            // 
            // textBox_a
            // 
            this.textBox_a.Location = new System.Drawing.Point(86, 44);
            this.textBox_a.Name = "textBox_a";
            this.textBox_a.Size = new System.Drawing.Size(104, 22);
            this.textBox_a.TabIndex = 8;
            this.textBox_a.TextChanged += new System.EventHandler(this.textBox_a_TextChanged);
            // 
            // textBox_b
            // 
            this.textBox_b.Location = new System.Drawing.Point(253, 44);
            this.textBox_b.Name = "textBox_b";
            this.textBox_b.Size = new System.Drawing.Size(106, 22);
            this.textBox_b.TabIndex = 9;
            // 
            // textBox_ketqua
            // 
            this.textBox_ketqua.Location = new System.Drawing.Point(119, 132);
            this.textBox_ketqua.Name = "textBox_ketqua";
            this.textBox_ketqua.Size = new System.Drawing.Size(240, 22);
            this.textBox_ketqua.TabIndex = 10;
            this.textBox_ketqua.TextChanged += new System.EventHandler(this.textBox_ketqua_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 297);
            this.Controls.Add(this.textBox_ketqua);
            this.Controls.Add(this.textBox_b);
            this.Controls.Add(this.textBox_a);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.label_ketqua);
            this.Controls.Add(this.label_b);
            this.Controls.Add(this.Chia_btn);
            this.Controls.Add(this.Nhan_btn);
            this.Controls.Add(this.Tru_btn);
            this.Controls.Add(this.Cong_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cong_btn;
        private System.Windows.Forms.Button Tru_btn;
        private System.Windows.Forms.Button Nhan_btn;
        private System.Windows.Forms.Button Chia_btn;
        private System.Windows.Forms.Label label_b;
        private System.Windows.Forms.Label label_ketqua;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.TextBox textBox_a;
        private System.Windows.Forms.TextBox textBox_b;
        private System.Windows.Forms.TextBox textBox_ketqua;
    }
}

