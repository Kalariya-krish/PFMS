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
    public partial class ViewExpense : Form
    {
        SqlConnection con = new SqlConnection(
@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.netprojectDB\PFMS_DB.mdf;Integrated Security=True;Connect Timeout=30");

        int currentUserId = Session.UserId;

        public ViewExpense()
        {
            InitializeComponent();
            this.Size = new Size(1200, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Normal;

            this.AutoSize = false;
            this.AutoScaleMode = AutoScaleMode.Dpi; // Good for high DPI displays

            // Attach Load event to DisplayIncomes
            this.Load += DisplayExpenses;
        }

        private void ViewExpense_Load(object sender, EventArgs e)
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
            Income income = new Income();
            this.Hide();
            income.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void expenseLabel_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense();
            this.Hide();
            expense.Show();
        }

        private void viewIncomeLabel_Click(object sender, EventArgs e)
        {
            ViewIncome viewIncome = new ViewIncome();
            this.Hide();
            viewIncome.Show();
        }

        private void viewExpenseLabel_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void DisplayExpenses(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query = "SELECT expense_id, expense_name, expense_amount, expense_category, expense_date, expense_description FROM expense WHERE user_id = @UserId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserId", currentUserId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                viewExpenseDGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading expense: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void viewExpenseClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
