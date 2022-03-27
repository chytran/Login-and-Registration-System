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
    public partial class Login : Form
    {
        private SqlDataReader dr;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Coding\Login and Registration System\Login and Registration System\Database.mdf';Integrated Security=True");
            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(userText.Text != string.Empty && passwordText.Text != string.Empty)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Coding\Login and Registration System\Login and Registration System\Database.mdf';Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from LoginTable where username ='" + userText.Text + "' and password ='" + passwordText.Text + "'", con);
                dr = cmd.ExecuteReader();
                if(dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                } else
                {
                    dr.Close();
                    MessageBox.Show("No account available with this username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                MessageBox.Show("Please enter values in all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
