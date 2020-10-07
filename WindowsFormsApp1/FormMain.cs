using System;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // nút login
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            //gọi form 2 xuất hiện
            FormLogin f2 = new FormLogin();
            f2.Show();
        }
        // nút Sign up
        private void button2_Click(object sender, EventArgs e)
        {
            // ẩn 1 lần nữa để có form 3
            this.Hide();
            FormSignUp f3 = new FormSignUp();
            // show form 3 -> kêu form 3 hiện hồn 
            f3.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
