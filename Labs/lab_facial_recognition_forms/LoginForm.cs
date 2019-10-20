using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab_facial_recognition_forms
{
    public partial class LoginForm : Form
    {
        
        static string connectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog= TURDSLoginUser; Integrated Security= True;";
        public LoginForm()
        {
            InitializeComponent();

            //userPanel.Hide();

            
            this.Text = "T.U.R.D.S. (Tiny User Recognition and Designator System)";
            this.Size = new System.Drawing.Size(340, 520);
            this.MaximizeBox = false;
            

            this.StartPosition = FormStartPosition.CenterScreen;
            Center(this);


            //When you click ENTER it activates the LoginButton
            passwordTextbox.KeyDown += (sender, args) => {
                if (args.KeyCode == Keys.Return)
                {
                    loginButton.PerformClick();
                }
            };

            failedLoginLabel.Hide();
            failedLoginLabel2.Hide();

            //loading gif hide on execute
            loadingGif.Hide();
            

        }

        private void Center(Form form)
        {
            form.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (form.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (form.Size.Height / 2));
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
            //if (userNameTextBox.Text == "" || passwordTextbox.Text == "")
            //{
            //    //MessageBox.Show("Please fill out ALL fields");
            //}
            //loadingGif.Show();
            if (userNameTextBox.Text != "Admin")
            {
                comboBox1.SelectedItem = "User";
            }
            else
            {
                comboBox1.SelectedItem = "Admin";
            }

            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT * FROM LoginUser WHERE LoginUserName='"+userNameTextBox.Text+"' AND Password= '"+passwordTextbox.Text+"'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string cmbItemsValue = comboBox1.SelectedItem.ToString();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["UserType"].ToString() == cmbItemsValue)
                    {
                        //MessageBox.Show($"You are Logging as: {dt.Rows[i][2]}");

                        
                        

                        //logging in as ADMIN
                        if (comboBox1.SelectedIndex == 0)
                        {
                            
                            failedLoginLabel.Hide();
                            failedLoginLabel2.Hide();

                            passwordTextbox.Clear();
                            var form1 = new Form1();
                            form1.Show();
                            form1.Size = new System.Drawing.Size(770, 845);
                            Center(form1);
                        }
                        else
                        {
                            //logging in as USER
                            //goes into user panel
                            failedLoginLabel.Hide();
                            failedLoginLabel2.Hide();

                            loginPanel.SendToBack();
                            userPanel.BringToFront();
                            passwordTextbox.Clear();
                            //turns UserLabel into user
                            userLabel.Text = dt.Rows[i][2].ToString();
                            this.Size = new System.Drawing.Size(744, 520);
                            Center(this);

                        }
                    }
                }
            }
            else
            {
                //MessageBox.Show("Error!");
                failedLoginLabel.Show();
                failedLoginLabel2.Show();

                userNameTextBox.Focus();
                userNameTextBox.SelectAll();
                passwordTextbox.Clear();

            }

        }

        

        private void SqlShow()
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog= TURDSDB; Integrated Security= True;"))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Users WHERE UserName= '"+ userNameTextBox.Text +"'", sqlCon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                dataGridView1.DataSource = dtbl;

            }
        }

        private void attendanceButton_Click(object sender, EventArgs e)
        {
            SqlShow();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            //dataGridView1.Rows.Clear();
            this.Size = new System.Drawing.Size(340, 520);
            Center(this);
            userPanel.SendToBack();
            loginPanel.BringToFront();
            

            userNameTextBox.Clear();
            passwordTextbox.Clear();
        }

      

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
