namespace Lab04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            string text = txtN.Text;
            int n = int.Parse(text);

            long s = 0;
            for (int i = 1; i <= n; i++)
            {
                s = s + i;
            }

            txtTong.Text = s.ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}