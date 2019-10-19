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
            this.Size = new System.Drawing.Size(726, 405);
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
            if (userNameTextBox.Text == "" || passwordTextbox.Text == "")
            {
                MessageBox.Show("Please fill out ALL fields");
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
                        MessageBox.Show($"You are Logging as: {dt.Rows[i][2]}");
                        if (comboBox1.SelectedIndex == 0)
                        {
                            passwordTextbox.Clear();
                            var form1 = new Form1();
                            form1.Show();
                        }
                        else
                        {
                            passwordTextbox.Clear();
                            //turns UserLabel into user
                            userLabel.Text = dt.Rows[i][2].ToString();
                            userPanel.BringToFront();
                            
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            loginPanel.BringToFront();
            userPanel.SendToBack();

            userNameTextBox.Clear();
            passwordTextbox.Clear();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
