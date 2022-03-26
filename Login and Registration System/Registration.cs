using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login_and_Registration_System
{
    public partial class Registration : Form
    {
        private SqlDataReader dr;

        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Coding\Login and Registration System\Login and Registration System\Database.mdf';Integrated Security=True");
            con.Open(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Login login = new Login();
            //login.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Coding\Login and Registration System\Login and Registration System\Database.mdf';Integrated Security=True");
            con.Open(); 
            if(confirmPassword.Text != string.Empty || passwordText.Text != string.Empty)
            {
                if (passwordText.Text == confirmPassword.Text)
                {
                    SqlCommand cmd = new SqlCommand("select * from LoginTable where username='" + userNameTxt.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username already exist, please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    } else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable values(@username,@password)", con);
                        cmd.Parameters.AddWithValue("password", passwordText.Text);
                        cmd.Parameters.AddWithValue("username", userNameTxt.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please Login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } 
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
