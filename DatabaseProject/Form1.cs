using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DatabaseProject
{
    public partial class Form1 : Form
    {
        SqlCommand command;

        SqlConnection connection;

        List<String> categories;
        List<String> accounts;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\Steven\\OneDrive - umich.edu\\CIS\\CIS 297\\DatabaseProject\\Budget Tracker.mdf; Integrated Security = True");
            connection.Open();
            categories = new List<String>();
            accounts = new List<String>();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            command = new SqlCommand("TRUNCATE TABLE" + " Accounts", connection);
            command.ExecuteNonQuery();
            command = new SqlCommand("TRUNCATE TABLE" + " Categories", connection);
            command.ExecuteNonQuery();
            command = new SqlCommand("TRUNCATE TABLE" + " Expenses", connection);
            command.ExecuteNonQuery();
            command = new SqlCommand("TRUNCATE TABLE" + " Income", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void addIncomeButton_Click_1(object sender, EventArgs e)
        {
            float outFloat = 0;

            if (String.IsNullOrEmpty(incomeAmountTextBox.Text) || String.IsNullOrEmpty(incomeAccountTextBox.Text))
            {
                MessageBox.Show("Please confirm both fields have values.", "Error");
                return;
            }
            if (!float.TryParse(incomeAmountTextBox.Text, out outFloat))
            {
                MessageBox.Show("Please enter a numerical value for target amount.", "Error");
                return;
            }
            if (!accounts.Contains(incomeAccountTextBox.Text))
            {
                MessageBox.Show("That account does not exist.", "Error");
                return;
            }

            command = new SqlCommand("INSERT INTO Income (Date, Amount, Account) VALUES (@Date,@Amount,@Account)", connection);
            command.Parameters.AddWithValue("@Date", incomeDateBox.Value);
            command.Parameters.AddWithValue("@Amount", Convert.ToSingle(incomeAmountTextBox.Text));
            command.Parameters.AddWithValue("@Account", incomeAccountTextBox.Text);
            command.ExecuteNonQuery();
        }

        private void addExpenseButton_Click_1(object sender, EventArgs e)
        {
            float outFloat = 0;

            if (String.IsNullOrEmpty(expenseCategoryTextBox.Text) || String.IsNullOrEmpty(expenseMemoTextBox.Text) ||
                String.IsNullOrEmpty(expenseAmountTextBox.Text) || String.IsNullOrEmpty(expenseAccountTextBox.Text))
            {
                MessageBox.Show("Please confirm all four fields have values.", "Error");
                return;
            }
            if (!float.TryParse(expenseAmountTextBox.Text, out outFloat))
            {
                MessageBox.Show("Please enter a numerical value for amount.", "Error");
                return;
            }
            if (!categories.Contains(expenseCategoryTextBox.Text))
            {
                MessageBox.Show("That category does not exist.", "Error");
                return;
            }
            if (!accounts.Contains(expenseAccountTextBox.Text))
            {
                MessageBox.Show("That account does not exist.", "Error");
                return;
            }

            command = new SqlCommand("INSERT INTO Expenses (Date, Category, Memo, Amount, Account) VALUES (@Date,@Category,@Memo,@Amount,@Account)", connection);
            command.Parameters.AddWithValue("@Date", expenseDateBox.Value);
            command.Parameters.AddWithValue("@Category", expenseCategoryTextBox.Text);
            command.Parameters.AddWithValue("@Memo", expenseMemoTextBox.Text);
            command.Parameters.AddWithValue("@Amount", Convert.ToSingle(expenseAmountTextBox.Text));
            command.Parameters.AddWithValue("@Account", expenseAccountTextBox.Text);
            command.ExecuteNonQuery();
        }

        private void createCategoryButton_Click_1(object sender, EventArgs e)
        {
            float outFloat = 0;

            if (String.IsNullOrEmpty(CategoryNameTextBox.Text) || String.IsNullOrEmpty(CategoryTargetAmountTextBox.Text))
            {
                MessageBox.Show("Please confirm both fields have values.", "Error");
                return;
            }
            if (!float.TryParse(CategoryTargetAmountTextBox.Text, out outFloat))
            {
                MessageBox.Show("Please enter a numerical value for target amount.", "Error");
                return;
            }
            if (categories.Contains(CategoryNameTextBox.Text))
            {
                MessageBox.Show("That category already exists.", "Error");
                return;
            }
            else
            {
                categories.Add(CategoryNameTextBox.Text);
            }

            command = new SqlCommand("INSERT INTO Categories (Name, Budget, Balance) VALUES (@Name,@Budget,@Balance)", connection);
            command.Parameters.AddWithValue("@Name", CategoryNameTextBox.Text);
            command.Parameters.AddWithValue("@Budget", Convert.ToSingle(CategoryTargetAmountTextBox.Text));
            command.Parameters.AddWithValue("@Balance", 0);
            command.ExecuteNonQuery();
        }

        private void addAccountButton_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(addAccountNameTextBox.Text))
            {
                MessageBox.Show("Please confirm name has a value.", "Error");
                return;
            }
            if (accounts.Contains(addAccountNameTextBox.Text))
            {
                MessageBox.Show("That account already exists.", "Error");
                return;
            }
            else
            {
                accounts.Add(addAccountNameTextBox.Text);
            }

            command = new SqlCommand("INSERT INTO Accounts (Name, Balance) VALUES (@Name,@Balance)", connection);
            command.Parameters.AddWithValue("@Name", addAccountNameTextBox.Text);
            command.Parameters.AddWithValue("@Balance", 0);
            command.ExecuteNonQuery();
        }

        private void switchTableButton_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(switchAccountNameComboBox.Text))
            {
                MessageBox.Show("Please confirm name has a value.", "Error");
                return;
            }
        }
    }
}