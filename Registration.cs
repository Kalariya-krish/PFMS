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

namespace PFMS
{
    public partial class Registration : Form
    {
        SqlConnection con = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.netprojectDB\PFMS_DB.mdf;Integrated Security=True;Connect Timeout=30");

        public Registration()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;

            this.AutoSize = false;
            this.AutoScaleMode = AutoScaleMode.Dpi; // Good for high DPI displays
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear_form(object sender, EventArgs e)
        {
            reg_username.Text = "";
            reg_dob.Text = "";
            reg_email.Text = "";
            reg_password.Text = "";
            reg_phone.Text = "";
            reg_address.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(reg_username.Text == "" || reg_dob.Text == "" || reg_password.Text == "" || reg_email.Text == "" || reg_phone.Text == "" || reg_address.Text == "")
            {
                MessageBox.Show("Please fill all the fields.");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO users (user_name, user_dob, user_email, user_password, user_phone, user_address) VALUES (@Username, @DOB, @Email, @Password, @Phone, @Address)", con);
                    cmd.Parameters.AddWithValue("@Username", reg_username.Text);
                    cmd.Parameters.AddWithValue("@DOB", reg_dob.Text);
                    cmd.Parameters.AddWithValue("@Email", reg_email.Text);
                    cmd.Parameters.AddWithValue("@Password", reg_password.Text);
                    cmd.Parameters.AddWithValue("@Phone", reg_phone.Text);
                    cmd.Parameters.AddWithValue("@Address", reg_address.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void reg_backtoLogin_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            this.Hide();
            obj.Show();
        }
    }
}
