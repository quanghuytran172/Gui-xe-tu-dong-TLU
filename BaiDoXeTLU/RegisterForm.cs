using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiDoXeTLU
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Exit();
        }
        private void Exit()
        {
            this.Hide();
            Login L = new Login();
            L.ShowDialog();
            this.Close();
        }

        private void cmdRegister_Click(object sender, EventArgs e)
        {
            if (txtUserNameR.Text == "" || txtPasswordR.Text == "" || txtConfirmR.Text == "")
            {
                MessageBox.Show("Please fill out the information completely");
            }
            else if (txtPasswordR.Text != txtConfirmR.Text)
            {
                MessageBox.Show("ConFirm password incorrect");
            }
            else
            {
                Auth auth = new Auth();
                if (auth.IsValidUsername(txtUserNameR.Text))
                {
                    auth.Register(txtUserNameR.Text, txtPasswordR.Text);
                    MessageBox.Show("Sign Up Success");
                    this.Exit();
                }
                else
                {
                    MessageBox.Show("Account already exists");
                }

            }
        }
    }
}
