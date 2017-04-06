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
        private DataTable _dataTable;

        private SqlCommand _command;

        private SqlConnection _connection;

        private SqlDataAdapter _dataAdapter;

        private List<String> _existingCategories;
        private List<String> _existingAccounts;

        public Form1()
        {
            //Open connection.
            InitializeComponent();
            _connection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = D:\\Steven\\OneDrive - umich.edu\\CIS\\CIS 297\\Github Repositories\\CIS297-DatabaseProject\\DatabaseProject\\Budget Tracker.mdf; Integrated Security = True");
            _connection.Open();
            _existingCategories = new List<String>();
            _existingAccounts = new List<String>();
        }

        private void addIncomeButton_Click_1(object sender, EventArgs e)
        {
            float outFloat = 0;

            //Error checking.
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
            if (!_existingAccounts.Contains(incomeAccountTextBox.Text))
            {
                MessageBox.Show("That account does not exist.", "Error");
                return;
            }

            //Add to income table.
            _command = new SqlCommand("INSERT INTO Income (Date, Amount, Account) VALUES (@Date,@Amount,@Account)", _connection);
            _command.Parameters.AddWithValue("@Date", incomeDateBox.Value);
            _command.Parameters.AddWithValue("@Amount", Convert.ToSingle(incomeAmountTextBox.Text));
            _command.Parameters.AddWithValue("@Account", incomeAccountTextBox.Text);
            _command.ExecuteNonQuery();

            //Update accounts table.
            _command = new SqlCommand("UPDATE Accounts SET Balance = Balance + @value", _connection);
            _command.Parameters.AddWithValue("value", Convert.ToSingle(incomeAmountTextBox.Text));
            _command.ExecuteNonQuery();
        }

        private void addExpenseButton_Click_1(object sender, EventArgs e)
        {
            float outFloat = 0;

            //Error checking.
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
            if (!_existingCategories.Contains(expenseCategoryTextBox.Text))
            {
                MessageBox.Show("That category does not exist.", "Error");
                return;
            }
            if (!_existingAccounts.Contains(expenseAccountTextBox.Text))
            {
                MessageBox.Show("That account does not exist.", "Error");
                return;
            }

            //Add to expenses table.
            _command = new SqlCommand("INSERT INTO Expenses (Date, Category, Memo, Amount, Account) VALUES (@Date,@Category,@Memo,@Amount,@Account)", _connection);
            _command.Parameters.AddWithValue("@Date", expenseDateBox.Value);
            _command.Parameters.AddWithValue("@Category", expenseCategoryTextBox.Text);
            _command.Parameters.AddWithValue("@Memo", expenseMemoTextBox.Text);
            _command.Parameters.AddWithValue("@Amount", Convert.ToSingle(expenseAmountTextBox.Text));
            _command.Parameters.AddWithValue("@Account", expenseAccountTextBox.Text);
            _command.ExecuteNonQuery();

            //Update accounts table.
            _command = new SqlCommand("UPDATE Accounts SET Balance = Balance - @value", _connection);
            _command.Parameters.AddWithValue("value", Convert.ToSingle(expenseAmountTextBox.Text));
            _command.ExecuteNonQuery();

            //Update categories table.
            _command = new SqlCommand("UPDATE Categories SET Balance = Balance + @value", _connection);
            _command.Parameters.AddWithValue("value", Convert.ToSingle(expenseAmountTextBox.Text));
            _command.ExecuteNonQuery();
        }

        private void createCategoryButton_Click_1(object sender, EventArgs e)
        {
            float outFloat = 0;

            //Error checking.
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
            if (_existingCategories.Contains(CategoryNameTextBox.Text))
            {
                MessageBox.Show("That category already exists.", "Error");
                return;
            }
            else
            {
                _existingCategories.Add(CategoryNameTextBox.Text);
            }

            _command = new SqlCommand("INSERT INTO Categories (Name, Budget, Balance) VALUES (@Name,@Budget,@Balance)", _connection);
            _command.Parameters.AddWithValue("@Name", CategoryNameTextBox.Text);
            _command.Parameters.AddWithValue("@Budget", Convert.ToSingle(CategoryTargetAmountTextBox.Text));
            _command.Parameters.AddWithValue("@Balance", 0);
            _command.ExecuteNonQuery();
        }

        private void addAccountButton_Click_1(object sender, EventArgs e)
        {
            //Error checking.
            if (String.IsNullOrEmpty(addAccountNameTextBox.Text))
            {
                MessageBox.Show("Please confirm name has a value.", "Error");
                return;
            }
            if (_existingAccounts.Contains(addAccountNameTextBox.Text))
            {
                MessageBox.Show("That account already exists.", "Error");
                return;
            }
            else
            {
                _existingAccounts.Add(addAccountNameTextBox.Text);
            }

            _command = new SqlCommand("INSERT INTO Accounts (Name, Balance) VALUES (@Name,@Balance)", _connection);
            _command.Parameters.AddWithValue("@Name", addAccountNameTextBox.Text);
            _command.Parameters.AddWithValue("@Balance", 0);
            _command.ExecuteNonQuery();
        }

        private void switchTableButton_Click_1(object sender, EventArgs e)
        {
            //Error checking.
            if (String.IsNullOrEmpty(switchAccountNameComboBox.Text))
            {
                MessageBox.Show("Please confirm name has a value.", "Error");
                return;
            }

            //Display table in grid view.
            if (switchAccountNameComboBox.Text == "Accounts")
            {
                _command = new SqlCommand("select * from Accounts", _connection);
                _command.ExecuteNonQuery();
                _dataTable = new DataTable();
                _dataAdapter = new SqlDataAdapter(_command);
                _dataAdapter.Fill(_dataTable);
                BudgetTrackerData.DataSource = _dataTable;
            }
            else if (switchAccountNameComboBox.Text == "Categories")
            {
                _command = new SqlCommand("select * from Categories", _connection);
                _command.ExecuteNonQuery();
                _dataTable = new DataTable();
                _dataAdapter = new SqlDataAdapter(_command);
                _dataAdapter.Fill(_dataTable);
                BudgetTrackerData.DataSource = _dataTable;
            }
            else if (switchAccountNameComboBox.Text == "Expenses")
            {
                _command = new SqlCommand("select * from Expenses", _connection);
                _command.ExecuteNonQuery();
                _dataTable = new DataTable();
                _dataAdapter = new SqlDataAdapter(_command);
                _dataAdapter.Fill(_dataTable);
                BudgetTrackerData.DataSource = _dataTable;
            }
            else if (switchAccountNameComboBox.Text == "Income")
            {
                _command = new SqlCommand("select * from Income", _connection);
                _command.ExecuteNonQuery();
                _dataTable = new DataTable();
                _dataAdapter = new SqlDataAdapter(_command);
                _dataAdapter.Fill(_dataTable);
                BudgetTrackerData.DataSource = _dataTable;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Erase tables and close connection.
            _command = new SqlCommand("TRUNCATE TABLE" + " Accounts", _connection);
            _command.ExecuteNonQuery();
            _command = new SqlCommand("TRUNCATE TABLE" + " Categories", _connection);
            _command.ExecuteNonQuery();
            _command = new SqlCommand("TRUNCATE TABLE" + " Expenses", _connection);
            _command.ExecuteNonQuery();
            _command = new SqlCommand("TRUNCATE TABLE" + " Income", _connection);
            _command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}