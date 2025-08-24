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

namespace PFMS
{
    public partial class Income : Form
    {
        SqlConnection con = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.netprojectDB\PFMS_DB.mdf;Integrated Security=True;Connect Timeout=30");

        int currentUserId = Session.UserId;

        public Income()
        {
            InitializeComponent();
            this.Size = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;

            this.AutoSize = false;
            this.AutoScaleMode = AutoScaleMode.Dpi; // Good for high DPI displays
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void dashboardLabel_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void incomeLabel_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void expenseLabel_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            this.Hide();
            expense.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewExpenseLabel_Click(object sender, EventArgs e)
        {
            ViewExpense viewExpense = new ViewExpense();
            this.Hide();
            viewExpense.Show();
        }

        private void viewIncomeLabel_Click(object sender, EventArgs e)
        {
            ViewIncome viewIncome = new ViewIncome();
            this.Hide();
            viewIncome.Show();
        }

        private void income_closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void income_btn_Click(object sender, EventArgs e)
        {
            string name = incomeName.Text.Trim();
            string category = incomeCategory.Text.Trim();
            string amountText = incomeAmount.Text.Trim();
            string dateText = incomeDate.Text.Trim();
            string description = incomeDescription.Text.Trim();

            if (name == "" || category == "" || amountText == "" || dateText == "" || description == "")
            {
                MessageBox.Show("Please enter all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(amountText, out int amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!DateTime.TryParse(dateText, out DateTime incomeDateValue))
            {
                MessageBox.Show("Please enter a valid date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();
                string query = @"INSERT INTO income 
            (income_name, income_amount, income_category, income_date, income_description, user_id)
            VALUES 
            (@name, @amount, @category, @date, @description, @user_id)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@date", incomeDateValue);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@user_id", currentUserId); // Replace with actual logged-in user ID

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Income record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to insert income record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

    }
}
