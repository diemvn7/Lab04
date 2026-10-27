using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Đọc giá trị từ các ô TextBox và chuyển đổi sang kiểu số thực (double) hoặc số nguyên (int)
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);

                // 2. Giả định ban đầu a là lớn nhất và nhỏ nhất
                double max = a;
                double min = a;

                // 3. Tìm số lớn nhất sử dụng cấu trúc If...Else
                if (b > max)
                {
                    max = b;
                }
                if (c > max)
                {
                    max = c;
                }

                // 4. Tìm số nhỏ nhất sử dụng cấu trúc If...Else
                if (b < min)
                {
                    min = b;
                }
                if (c < min)
                {
                    min = c;
                }

                // 5. Hiển thị kết quả ra các TextBox tương ứng
                txtMax.Text = max.ToString();
                txtMin.Text = min.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập vào số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}