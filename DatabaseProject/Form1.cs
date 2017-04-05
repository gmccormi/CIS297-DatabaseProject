using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProject
{
    public partial class Form1 : Form
    {
        const int NUMBER_OF_MONTHS = 12;

        List<string> Months = new List<string>();

        Label[] categoryLabels;
        Label[] expenseLabels;
        Label[] incomeLabels;
        Label[] addAccountLabels;
        Label[] switchAccountLabels;
        Label[] editCategoryLabels;

        TextBox[] categoryTextBoxes;
        TextBox[] expenseTextBoxes;
        TextBox[] incomeTextBoxes;
        TextBox[] addAccountTextBoxes;
        TextBox[] switchAccountTextBoxes;
        TextBox[] editCategoryTextBoxes;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Months.Add("January");
            Months.Add("Febuary");
            Months.Add("March");
            Months.Add("April");
            Months.Add("May");
            Months.Add("June");
            Months.Add("July");
            Months.Add("August");
            Months.Add("September");
            Months.Add("October");
            Months.Add("November");
            Months.Add("December");

            for (int i = 0; i < NUMBER_OF_MONTHS; i++)
            {
                expenseDateMonth.Items.Add(Months[i]);
                incomeDateMonth.Items.Add(Months[i]);
            }

            categoryLabels = new Label[3]{ label1, label2, label3};
            expenseLabels = new Label[6] { label4, label5, label6, label7, label8, label9 };
            incomeLabels = new Label[4] { label10, label11, label12, label13 } ;
            addAccountLabels = new Label[2] { label14, label15 };
            switchAccountLabels = new Label[2] { label16, label17 };
            editCategoryLabels = new Label[3] { label18, label19, label20 };

            categoryTextBoxes = new TextBox[2] { CategoryNameTextBox, CategoryTargetAmountTextBox };
            expenseTextBoxes = new TextBox[4] { expenseAccountTextBox, expenseAmountTextBox, expenseCategoryTextBox, expenseMemoTextBox };
            incomeTextBoxes = new TextBox[2] { incomeAccountTextBox, incomeAmountTextBox };
            addAccountTextBoxes = new TextBox[1] { addAccountNameTextBox };
            switchAccountTextBoxes = new TextBox[1] { switchAccountNameTextBox };
            editCategoryTextBoxes = new TextBox[2] { editCategoryNameTextBox, editCategoryNewTargetAmountTextBox };
        }

        private void createCategoryUIButton_Click(object sender, EventArgs e)
        {
            turnOnUI(categoryLabels, categoryTextBoxes);
            createCategoryButton.Visible = true;
            turnOffChoices();
        }

        private void addExpenseUIButton_Click(object sender, EventArgs e)
        {
            turnOnUI(expenseLabels, expenseTextBoxes);
            addExpenseButton.Visible = true;
            turnOffChoices();
        }

        private void addIncomeUIButton_Click(object sender, EventArgs e)
        {
            turnOnUI(incomeLabels, incomeTextBoxes);
            addIncomeButton.Visible = true;
            turnOffChoices();
        }

        private void addAccountUIButton_Click(object sender, EventArgs e)
        {
            turnOnUI(addAccountLabels, addAccountTextBoxes);
            addAccountButton.Visible = true;
            turnOffChoices();
        }

        private void switchAccountUIButton_Click(object sender, EventArgs e)
        {
            turnOnUI(switchAccountLabels, switchAccountTextBoxes);
            switchAccountButton.Visible = true;
            turnOffChoices();
        }

        private void editCategoryUIButton_Click(object sender, EventArgs e)
        {
            turnOnUI(editCategoryLabels, editCategoryTextBoxes);
            editCategoryButton.Visible = true;
            turnOffChoices();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            turnOnChoices();

            turnOffUI(categoryLabels, categoryTextBoxes);
            createCategoryButton.Visible = false;
       
            turnOffUI(expenseLabels, expenseTextBoxes);
            addExpenseButton.Visible = false;
        
            turnOffUI(incomeLabels, incomeTextBoxes);
            addIncomeButton.Visible = false;
       
            turnOffUI(addAccountLabels, addAccountTextBoxes);
            addAccountButton.Visible = false;
        
            turnOffUI(switchAccountLabels, switchAccountTextBoxes);
            switchAccountButton.Visible = false;
      
            turnOffUI(editCategoryLabels, editCategoryTextBoxes);
            editCategoryButton.Visible = false;
        }

        private void turnOnUI(Label[] labels, TextBox[] textboxes)
        {
            foreach (Label label in labels)
            {
                label.Visible = true;
            }
            foreach (TextBox textbox in textboxes)
            {
                textbox.Visible = true;
            }
        }

        private void turnOffUI(Label[] labels, TextBox[] textboxes)
        {
            foreach (Label label in labels)
            {
                label.Visible = false;
            }
            foreach (TextBox textbox in textboxes)
            {
                textbox.Visible = false;
            }
        }

        private void turnOnChoices()
        {
            createCategoryUIButton.Visible = true;
            addExpenseUIButton.Visible = true;
            addIncomeUIButton.Visible = true;
            addAccountUIButton.Visible = true;
            switchAccountUIButton.Visible = true;
            editCategoryUIButton.Visible = true;

            goBackButton.Visible = false;
        }

        private void turnOffChoices()
        {
            createCategoryUIButton.Visible = false;
            addExpenseUIButton.Visible = false;
            addIncomeUIButton.Visible = false;
            addAccountUIButton.Visible = false;
            switchAccountUIButton.Visible = false;
            editCategoryUIButton.Visible = false;

            goBackButton.Visible = true;
        }

    }
}
