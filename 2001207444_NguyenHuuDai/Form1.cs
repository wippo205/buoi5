using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001207444_NguyenHuuDai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng form không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Ngăn form từ việc đóng
            }
        }


        private void label_b_Click(object sender, EventArgs e)
        {

        }

        private void textBox_ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_a_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Cong_btn_Click(object sender, EventArgs e)
        {
            int soThuNhat = Convert.ToInt32(textBox_a.Text);
            int soThuHai = Convert.ToInt32(textBox_b.Text);
            int Kq = soThuNhat + soThuHai;
            textBox_ketqua.Text = Kq.ToString();

        }

        private void Tru_btn_Click(object sender, EventArgs e)
        {
            int soThuNhat = Convert.ToInt32(textBox_a.Text);
            int soThuHai = Convert.ToInt32(textBox_b.Text);
            int Kq = soThuNhat - soThuHai;
            textBox_ketqua.Text = Kq.ToString();
        }

        private void Nhan_btn_Click(object sender, EventArgs e)
        {
            int soThuNhat = Convert.ToInt32(textBox_a.Text);
            int soThuHai = Convert.ToInt32(textBox_b.Text);
            int Kq = soThuNhat * soThuHai;
            textBox_ketqua.Text = Kq.ToString();
        }

        private void Chia_btn_Click(object sender, EventArgs e)
        {
            float soThuNhat = float.Parse(textBox_a.Text);
            float soThuHai = float.Parse(textBox_b.Text);
            if (soThuHai == 0)
            {
                MessageBox.Show("nhap so b khac 0");
            }
            else
            {
                float chia = soThuNhat / soThuHai;
                textBox_ketqua.Text = chia.ToString();
            }
        }

        
        
    }
}
