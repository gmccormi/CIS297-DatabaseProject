namespace DatabaseProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.budget_TrackerDataSet = new DatabaseProject.Budget_TrackerDataSet();
            this.BudgetTrackerData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.CategoryTargetAmountTextBox = new System.Windows.Forms.TextBox();
            this.createCategoryButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.expenseCategoryTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.expenseMemoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.expenseAmountTextBox = new System.Windows.Forms.TextBox();
            this.expenseAccountTextBox = new System.Windows.Forms.TextBox();
            this.addExpenseButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.incomeAccountTextBox = new System.Windows.Forms.TextBox();
            this.incomeAmountTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addIncomeButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.addAccountNameTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.addAccountButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.switchTableButton = new System.Windows.Forms.Button();
            this.expenseDateBox = new System.Windows.Forms.DateTimePicker();
            this.incomeDateBox = new System.Windows.Forms.DateTimePicker();
            this.switchAccountNameComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.budget_TrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetTrackerData)).BeginInit();
            this.SuspendLayout();
            // 
            // budget_TrackerDataSet
            // 
            this.budget_TrackerDataSet.DataSetName = "Budget_TrackerDataSet";
            this.budget_TrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BudgetTrackerData
            // 
            this.BudgetTrackerData.AutoGenerateColumns = false;
            this.BudgetTrackerData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BudgetTrackerData.DataSource = this.budget_TrackerDataSet;
            this.BudgetTrackerData.Location = new System.Drawing.Point(11, 11);
            this.BudgetTrackerData.Margin = new System.Windows.Forms.Padding(2);
            this.BudgetTrackerData.Name = "BudgetTrackerData";
            this.BudgetTrackerData.RowTemplate.Height = 24;
            this.BudgetTrackerData.Size = new System.Drawing.Size(372, 458);
            this.BudgetTrackerData.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Create Categoy:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 71);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Budget:";
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(517, 41);
            this.CategoryNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryNameTextBox.MaxLength = 50;
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.CategoryNameTextBox.TabIndex = 0;
            // 
            // CategoryTargetAmountTextBox
            // 
            this.CategoryTargetAmountTextBox.Location = new System.Drawing.Point(517, 69);
            this.CategoryTargetAmountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.CategoryTargetAmountTextBox.Name = "CategoryTargetAmountTextBox";
            this.CategoryTargetAmountTextBox.Size = new System.Drawing.Size(200, 20);
            this.CategoryTargetAmountTextBox.TabIndex = 1;
            // 
            // createCategoryButton
            // 
            this.createCategoryButton.Location = new System.Drawing.Point(593, 8);
            this.createCategoryButton.Margin = new System.Windows.Forms.Padding(2);
            this.createCategoryButton.Name = "createCategoryButton";
            this.createCategoryButton.Size = new System.Drawing.Size(56, 19);
            this.createCategoryButton.TabIndex = 2;
            this.createCategoryButton.Text = "Create";
            this.createCategoryButton.UseVisualStyleBackColor = true;
            this.createCategoryButton.Click += new System.EventHandler(this.createCategoryButton_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Add Expense:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 162);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 194);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Category:";
            // 
            // expenseCategoryTextBox
            // 
            this.expenseCategoryTextBox.Location = new System.Drawing.Point(517, 191);
            this.expenseCategoryTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.expenseCategoryTextBox.MaxLength = 50;
            this.expenseCategoryTextBox.Name = "expenseCategoryTextBox";
            this.expenseCategoryTextBox.Size = new System.Drawing.Size(200, 20);
            this.expenseCategoryTextBox.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Memo:";
            // 
            // expenseMemoTextBox
            // 
            this.expenseMemoTextBox.Location = new System.Drawing.Point(517, 222);
            this.expenseMemoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.expenseMemoTextBox.MaxLength = 100;
            this.expenseMemoTextBox.Name = "expenseMemoTextBox";
            this.expenseMemoTextBox.Size = new System.Drawing.Size(200, 20);
            this.expenseMemoTextBox.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Amount:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 285);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Account:";
            // 
            // expenseAmountTextBox
            // 
            this.expenseAmountTextBox.Location = new System.Drawing.Point(517, 254);
            this.expenseAmountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.expenseAmountTextBox.Name = "expenseAmountTextBox";
            this.expenseAmountTextBox.Size = new System.Drawing.Size(200, 20);
            this.expenseAmountTextBox.TabIndex = 6;
            // 
            // expenseAccountTextBox
            // 
            this.expenseAccountTextBox.Location = new System.Drawing.Point(517, 282);
            this.expenseAccountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.expenseAccountTextBox.MaxLength = 50;
            this.expenseAccountTextBox.Name = "expenseAccountTextBox";
            this.expenseAccountTextBox.Size = new System.Drawing.Size(200, 20);
            this.expenseAccountTextBox.TabIndex = 7;
            // 
            // addExpenseButton
            // 
            this.addExpenseButton.Location = new System.Drawing.Point(593, 129);
            this.addExpenseButton.Margin = new System.Windows.Forms.Padding(2);
            this.addExpenseButton.Name = "addExpenseButton";
            this.addExpenseButton.Size = new System.Drawing.Size(56, 19);
            this.addExpenseButton.TabIndex = 8;
            this.addExpenseButton.Text = "Add";
            this.addExpenseButton.UseVisualStyleBackColor = true;
            this.addExpenseButton.Click += new System.EventHandler(this.addExpenseButton_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(412, 343);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Add Income:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(412, 371);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Date:";
            // 
            // incomeAccountTextBox
            // 
            this.incomeAccountTextBox.Location = new System.Drawing.Point(517, 433);
            this.incomeAccountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.incomeAccountTextBox.MaxLength = 50;
            this.incomeAccountTextBox.Name = "incomeAccountTextBox";
            this.incomeAccountTextBox.Size = new System.Drawing.Size(200, 20);
            this.incomeAccountTextBox.TabIndex = 11;
            // 
            // incomeAmountTextBox
            // 
            this.incomeAmountTextBox.Location = new System.Drawing.Point(517, 404);
            this.incomeAmountTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.incomeAmountTextBox.Name = "incomeAmountTextBox";
            this.incomeAmountTextBox.Size = new System.Drawing.Size(200, 20);
            this.incomeAmountTextBox.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(412, 435);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Account:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(412, 407);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Amount:";
            // 
            // addIncomeButton
            // 
            this.addIncomeButton.Location = new System.Drawing.Point(593, 341);
            this.addIncomeButton.Margin = new System.Windows.Forms.Padding(2);
            this.addIncomeButton.Name = "addIncomeButton";
            this.addIncomeButton.Size = new System.Drawing.Size(56, 19);
            this.addIncomeButton.TabIndex = 12;
            this.addIncomeButton.Text = "Add";
            this.addIncomeButton.UseVisualStyleBackColor = true;
            this.addIncomeButton.Click += new System.EventHandler(this.addIncomeButton_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(409, 491);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Create Account:";
            // 
            // addAccountNameTextBox
            // 
            this.addAccountNameTextBox.Location = new System.Drawing.Point(517, 518);
            this.addAccountNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.addAccountNameTextBox.MaxLength = 50;
            this.addAccountNameTextBox.Name = "addAccountNameTextBox";
            this.addAccountNameTextBox.Size = new System.Drawing.Size(200, 20);
            this.addAccountNameTextBox.TabIndex = 13;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(409, 520);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Name:";
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(593, 489);
            this.addAccountButton.Margin = new System.Windows.Forms.Padding(2);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(56, 19);
            this.addAccountButton.TabIndex = 14;
            this.addAccountButton.Text = "Create";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Click += new System.EventHandler(this.addAccountButton_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 487);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Switch Table:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(41, 520);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Name:";
            // 
            // switchTableButton
            // 
            this.switchTableButton.Location = new System.Drawing.Point(224, 485);
            this.switchTableButton.Margin = new System.Windows.Forms.Padding(2);
            this.switchTableButton.Name = "switchTableButton";
            this.switchTableButton.Size = new System.Drawing.Size(56, 19);
            this.switchTableButton.TabIndex = 16;
            this.switchTableButton.Text = "Switch";
            this.switchTableButton.UseVisualStyleBackColor = true;
            this.switchTableButton.Click += new System.EventHandler(this.switchTableButton_Click_1);
            // 
            // expenseDateBox
            // 
            this.expenseDateBox.Location = new System.Drawing.Point(517, 162);
            this.expenseDateBox.Name = "expenseDateBox";
            this.expenseDateBox.Size = new System.Drawing.Size(200, 20);
            this.expenseDateBox.TabIndex = 3;
            // 
            // incomeDateBox
            // 
            this.incomeDateBox.Location = new System.Drawing.Point(517, 371);
            this.incomeDateBox.Name = "incomeDateBox";
            this.incomeDateBox.Size = new System.Drawing.Size(200, 20);
            this.incomeDateBox.TabIndex = 9;
            // 
            // switchAccountNameComboBox
            // 
            this.switchAccountNameComboBox.FormattingEnabled = true;
            this.switchAccountNameComboBox.Items.AddRange(new object[] {
            "Accounts",
            "Categories",
            "Expenses",
            "Income"});
            this.switchAccountNameComboBox.Location = new System.Drawing.Point(159, 517);
            this.switchAccountNameComboBox.Name = "switchAccountNameComboBox";
            this.switchAccountNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.switchAccountNameComboBox.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 547);
            this.Controls.Add(this.switchAccountNameComboBox);
            this.Controls.Add(this.incomeDateBox);
            this.Controls.Add(this.expenseDateBox);
            this.Controls.Add(this.switchTableButton);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.addAccountButton);
            this.Controls.Add(this.addAccountNameTextBox);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.addIncomeButton);
            this.Controls.Add(this.incomeAccountTextBox);
            this.Controls.Add(this.incomeAmountTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.addExpenseButton);
            this.Controls.Add(this.expenseAccountTextBox);
            this.Controls.Add(this.expenseAmountTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.expenseMemoTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.expenseCategoryTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createCategoryButton);
            this.Controls.Add(this.CategoryTargetAmountTextBox);
            this.Controls.Add(this.CategoryNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BudgetTrackerData);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Tracker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.budget_TrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BudgetTrackerData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Budget_TrackerDataSet budget_TrackerDataSet;
        private System.Windows.Forms.DataGridView BudgetTrackerData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.TextBox CategoryTargetAmountTextBox;
        private System.Windows.Forms.Button createCategoryButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox expenseCategoryTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox expenseMemoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox expenseAmountTextBox;
        private System.Windows.Forms.TextBox expenseAccountTextBox;
        private System.Windows.Forms.Button addExpenseButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox incomeAccountTextBox;
        private System.Windows.Forms.TextBox incomeAmountTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button addIncomeButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox addAccountNameTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button addAccountButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button switchTableButton;
        private System.Windows.Forms.DateTimePicker expenseDateBox;
        private System.Windows.Forms.DateTimePicker incomeDateBox;
        private System.Windows.Forms.ComboBox switchAccountNameComboBox;
    }
}

