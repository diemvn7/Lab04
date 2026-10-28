using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab04
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtSo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSo.Text == "")
                {
                    txtKetQua.Text = "";
                    return;
                }

                int n = int.Parse(txtSo.Text);
                string kq = "";

                switch (n)
                {
                    case 0: kq = "Không"; break;
                    case 1: kq = "Một"; break;
                    case 2: kq = "Hai"; break;
                    case 3: kq = "Ba"; break;
                    case 4: kq = "Bốn"; break;
                    case 5: kq = "Năm"; break;
                    case 6: kq = "Sáu"; break;
                    case 7: kq = "Bảy"; break;
                    case 8: kq = "Tám"; break;
                    case 9: kq = "Chín"; break;
                    default: kq = "Số từ 0 đến 9!"; break;
                }

                txtKetQua.Text = kq;
            }
            catch (FormatException)
            {
                txtKetQua.Text = "Không hợp lệ!";
            }
        }
    }
}
