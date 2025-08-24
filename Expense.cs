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
    public partial class Expense : Form
    {
        SqlConnection con = new SqlConnection(
    @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.netprojectDB\PFMS_DB.mdf;Integrated Security=True;Connect Timeout=30");

        int currentUserId = Session.UserId;

        public Expense()
        {
            InitializeComponent();
            this.Size = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;

            this.AutoSize = false;
            this.AutoScaleMode = AutoScaleMode.Dpi; // Good for high DPI displays
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void expenseBtn_Click(object sender, EventArgs e)
        {
            string name = expenseName.Text.Trim();
            string category = expenseCategory.Text.Trim();
            string amountText = expenseAmount.Text.Trim();
            string dateText = expenseDate.Text.Trim();
            string description = expenseDescription.Text.Trim();

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

            if (!DateTime.TryParse(dateText, out DateTime expenseDateValue))
            {
                MessageBox.Show("Please enter a valid date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                con.Open();
                string query = @"INSERT INTO expense 
            (expense_name, expense_amount, expense_category, expense_date, expense_description, user_id)
            VALUES 
            (@name, @amount, @category, @date, @description, @user_id)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@date", expenseDateValue);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@user_id", currentUserId); // Replace with actual logged-in user ID

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Expense record inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to insert expense record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void Expense_Load(object sender, EventArgs e)
        {
        }

        private void expenseCloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardLabel_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void incomeLabel_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            this.Hide();
            income.Show();
        }

        private void expenseLabel_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void viewIncomeLabel_Click(object sender, EventArgs e)
        {
            ViewIncome viewincome = new ViewIncome();
            this.Hide();
            viewincome.Show();
        }

        private void viewExpenseLabel_Click(object sender, EventArgs e)
        {
            ViewExpense viewexpense = new ViewExpense();
            this.Hide();
            viewexpense.Show();
        }
    }
}
