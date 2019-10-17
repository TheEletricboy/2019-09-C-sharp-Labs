using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_facial_recognition_forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.Text = "T.U.R.D.S. (Tiny User Recognition and Designator System)";
            this.Size = new System.Drawing.Size(614, 405);
            this.MaximizeBox = false;

            //When you click ENTER it activates the LoginButton
            passwordTextbox.KeyDown += (sender, args) => {
                if (args.KeyCode == Keys.Return)
                {
                    loginButton.PerformClick();
                }
            };



        }

        private void debug1_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            var loginForm = new LoginForm();
            //var userForm = new UserForm();
            form1.Show();
            loginForm.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("you have logged in boyo");
        }
    }
}
