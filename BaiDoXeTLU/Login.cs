using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BaiDoXeTLU
{
    public partial class Login : Form
    {
       
        public Login()
        {
            InitializeComponent();
        }



        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Tên đăng nhập")
            {
                txtUsername.Text = "";
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Tên đăng nhập";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "password")
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "password";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm R = new RegisterForm();
            R.ShowDialog();
            this.Close();

        }

        private void cmdLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username" || txtPassword.Text == "Password")
            {
                MessageBox.Show("Please fill out the information completely");
            }
            else
            {
                Auth auth = new Auth();
                if (auth.IsLogin(txtUsername.Text, txtPassword.Text))
                {
                    this.Hide();
                    Form1 F = new Form1();
                    F.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username or Password incorrect");
                };
            }

        }

     
    }
}
