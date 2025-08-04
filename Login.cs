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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace PFMS
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.netprojectDB\PFMS_DB.mdf;Integrated Security=True;Connect Timeout=30");

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;
                
            this.AutoSize = false;
            this.AutoScaleMode = AutoScaleMode.Dpi; // Good for high DPI displays
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = login_email.Text.Trim();
            string password = login_password.Text.Trim();
            if (email == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM users WHERE user_email = @email AND user_password = @password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                int userCount = (int)cmd.ExecuteScalar();

                if (userCount > 0)
                {
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard dash = new Dashboard();
                    dash.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void login_notaMember_Click(object sender, EventArgs e)
        {
            Registration obj = new Registration();
            obj.Show();
            this.Hide();
        }
    }
}
