using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        //// set vi tri con tro
        private void Form2_Load(object sender, EventArgs e)
        {
            int vitri = TextUser.Text.Length;
            int vitri2 = Textpassword.Text.Length;
            TextUser.SelectionStart = (vitri + 1);
            Textpassword.SelectionStart = (vitri2 + 1);
        }
        // login button
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            string username = TextUser.Text;
            string password = Textpassword.Text;
            string user1 = "Admin1";
            string user2 = "Admin2";
            if (username == string.Empty || password == string.Empty)
                MessageBox.Show("Your information must be filled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (password.Length <= 6)
                MessageBox.Show("Password must be more than 6 words", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if ((string.Compare(username, user1, false) == 0 && password.Length > 6) || (string.Compare(username, user2, false) == 0 && password.Length > 6))
            {
                MessageBox.Show("Login success", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                FormNhanVien nhanVien = new FormNhanVien();
                nhanVien.Show();
            }
            else if (string.Compare(username, user1, false) != 0 || string.Compare(username, user2, false) == 0)
                MessageBox.Show("Information not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        // về menu chính
        private void ButtonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
        // password char
        private void Textpassword_TextChanged(object sender, EventArgs e)
        {
            Textpassword.PasswordChar = '•';
        }
        // action on Double-Click
        private void txt_User_Mouse_DoubleClick(object sender, MouseEventArgs e)
        {
            TextUser.Clear();
        }
        private void txt_Password_Mouse_DoubleClick(object sender, MouseEventArgs e)
        {
            Textpassword.Clear();
        }
        //// thuộc tính hover -> Enter + Leave
        //Action enter
        private void txt_User_Mouse_Enter(object sender, EventArgs e)
        {
            TextUser.Focus();
            // thay ảnh cho txt user
            pictureBox_User.Image = Properties.Resources.user_1;
            // text USer
            TextUser.ForeColor = Color.FromArgb(78, 184, 206);
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            // text password
            Textpassword.ForeColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
        }
        private void txt_Password_Mouse_Enter(object sender, EventArgs e)
        {
            Textpassword.Focus();
            // thay ảnh cho txt password
            pictureBoxPassword.Image = Properties.Resources.unlock_2;
            // text password
            Textpassword.ForeColor = Color.FromArgb(78, 184, 206);
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            // text user
            TextUser.ForeColor = Color.WhiteSmoke;
            panel1.BackColor = Color.WhiteSmoke;
        }
        //Action Leave
        private void txt_Password_Mouse_Leave(object sender, EventArgs e)
        {
            pictureBoxPassword.Image = Properties.Resources.unlock_1;
            //text password -> color white smoke
            Textpassword.ForeColor = Color.WhiteSmoke;
            panel2.BackColor = Color.WhiteSmoke;
        }
        private void txt_User_Mouse_Leave(object sender, EventArgs e)
        {
            pictureBox_User.Image = Properties.Resources.user_2;
            //text user -> color white smoke
            TextUser.ForeColor = Color.WhiteSmoke;
            panel1.BackColor = Color.WhiteSmoke;
        }
    }
}
