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
    public partial class ViewIncome : Form
    {
        SqlConnection con = new SqlConnection(
@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.netprojectDB\PFMS_DB.mdf;Integrated Security=True;Connect Timeout=30");

        int currentUserId = Session.UserId;

        public ViewIncome()
        {
            InitializeComponent();
            this.Size = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;

            this.AutoSize = false;
            this.AutoScaleMode = AutoScaleMode.Dpi; // Good for high DPI displays

            // Attach Load event to DisplayIncomes
            this.Load += DisplayIncomes;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void incomeLabel_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            this.Hide();
            income.Show();
        }

        private void expenseLabel_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            this.Hide();
            expense.Show();
        }

        private void viewIncomeLabel_Click(object sender, EventArgs e)
        {
           this.Show();
        }

        private void viewExpenseLabel_Click(object sender, EventArgs e)
        {
            ViewExpense viewExpense = new ViewExpense();
            this.Hide();
            viewExpense.Show();
        }

        private void dashboardLabel_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void DisplayIncomes(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT income_id, income_name, income_amount, income_category, income_date, income_description FROM income WHERE user_id = @UserId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserId", currentUserId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                viewIncomeDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading incomes: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void viewIncomeClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
