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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.budget_TrackerDataSet = new DatabaseProject.Budget_TrackerDataSet();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.expenseDateMonth = new System.Windows.Forms.ComboBox();
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
            this.incomeDateMonth = new System.Windows.Forms.ComboBox();
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
            this.switchAccountNameTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.switchAccountButton = new System.Windows.Forms.Button();
            this.createCategoryUIButton = new System.Windows.Forms.Button();
            this.addExpenseUIButton = new System.Windows.Forms.Button();
            this.addIncomeUIButton = new System.Windows.Forms.Button();
            this.addAccountUIButton = new System.Windows.Forms.Button();
            this.editCategoryButton = new System.Windows.Forms.Button();
            this.editCategoryNewTargetAmountTextBox = new System.Windows.Forms.TextBox();
            this.editCategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.switchAccountUIButton = new System.Windows.Forms.Button();
            this.editCategoryUIButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.budget_TrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // budget_TrackerDataSet
            // 
            this.budget_TrackerDataSet.DataSetName = "Budget_TrackerDataSet";
            this.budget_TrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(931, 27);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.budget_TrackerDataSet;
            this.dataGridView1.Location = new System.Drawing.Point(12, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 354);
            this.dataGridView1.TabIndex = 1;
            // 
            // expenseDateMonth
            // 
            this.expenseDateMonth.FormattingEnabled = true;
            this.expenseDateMonth.Location = new System.Drawing.Point(687, 221);
            this.expenseDateMonth.Name = "expenseDateMonth";
            this.expenseDateMonth.Size = new System.Drawing.Size(176, 24);
            this.expenseDateMonth.TabIndex = 2;
            this.expenseDateMonth.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Create Categoy:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(543, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Target Amuont:";
            this.label3.Visible = false;
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(687, 75);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(176, 22);
            this.CategoryNameTextBox.TabIndex = 6;
            this.CategoryNameTextBox.Visible = false;
            // 
            // CategoryTargetAmountTextBox
            // 
            this.CategoryTargetAmountTextBox.Location = new System.Drawing.Point(687, 109);
            this.CategoryTargetAmountTextBox.Name = "CategoryTargetAmountTextBox";
            this.CategoryTargetAmountTextBox.Size = new System.Drawing.Size(176, 22);
            this.CategoryTargetAmountTextBox.TabIndex = 7;
            this.CategoryTargetAmountTextBox.Visible = false;
            // 
            // createCategoryButton
            // 
            this.createCategoryButton.Location = new System.Drawing.Point(788, 35);
            this.createCategoryButton.Name = "createCategoryButton";
            this.createCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.createCategoryButton.TabIndex = 8;
            this.createCategoryButton.Text = "Create";
            this.createCategoryButton.UseVisualStyleBackColor = true;
            this.createCategoryButton.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(543, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Add Expense:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(546, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date:";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(546, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Category:";
            this.label6.Visible = false;
            // 
            // expenseCategoryTextBox
            // 
            this.expenseCategoryTextBox.Location = new System.Drawing.Point(687, 260);
            this.expenseCategoryTextBox.Name = "expenseCategoryTextBox";
            this.expenseCategoryTextBox.Size = new System.Drawing.Size(176, 22);
            this.expenseCategoryTextBox.TabIndex = 13;
            this.expenseCategoryTextBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(546, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Memo:";
            this.label7.Visible = false;
            // 
            // expenseMemoTextBox
            // 
            this.expenseMemoTextBox.Location = new System.Drawing.Point(687, 298);
            this.expenseMemoTextBox.Name = "expenseMemoTextBox";
            this.expenseMemoTextBox.Size = new System.Drawing.Size(176, 22);
            this.expenseMemoTextBox.TabIndex = 15;
            this.expenseMemoTextBox.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(546, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Amount:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(546, 375);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "Account:";
            this.label9.Visible = false;
            // 
            // expenseAmountTextBox
            // 
            this.expenseAmountTextBox.Location = new System.Drawing.Point(687, 337);
            this.expenseAmountTextBox.Name = "expenseAmountTextBox";
            this.expenseAmountTextBox.Size = new System.Drawing.Size(176, 22);
            this.expenseAmountTextBox.TabIndex = 18;
            this.expenseAmountTextBox.Visible = false;
            // 
            // expenseAccountTextBox
            // 
            this.expenseAccountTextBox.Location = new System.Drawing.Point(687, 372);
            this.expenseAccountTextBox.Name = "expenseAccountTextBox";
            this.expenseAccountTextBox.Size = new System.Drawing.Size(176, 22);
            this.expenseAccountTextBox.TabIndex = 19;
            this.expenseAccountTextBox.Visible = false;
            // 
            // addExpenseButton
            // 
            this.addExpenseButton.Location = new System.Drawing.Point(788, 183);
            this.addExpenseButton.Name = "addExpenseButton";
            this.addExpenseButton.Size = new System.Drawing.Size(75, 23);
            this.addExpenseButton.TabIndex = 20;
            this.addExpenseButton.Text = "Add";
            this.addExpenseButton.UseVisualStyleBackColor = true;
            this.addExpenseButton.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(546, 447);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Add Income:";
            this.label10.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(546, 481);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "Date:";
            this.label11.Visible = false;
            // 
            // incomeDateMonth
            // 
            this.incomeDateMonth.FormattingEnabled = true;
            this.incomeDateMonth.Location = new System.Drawing.Point(687, 481);
            this.incomeDateMonth.Name = "incomeDateMonth";
            this.incomeDateMonth.Size = new System.Drawing.Size(176, 24);
            this.incomeDateMonth.TabIndex = 23;
            this.incomeDateMonth.Visible = false;
            // 
            // incomeAccountTextBox
            // 
            this.incomeAccountTextBox.Location = new System.Drawing.Point(687, 557);
            this.incomeAccountTextBox.Name = "incomeAccountTextBox";
            this.incomeAccountTextBox.Size = new System.Drawing.Size(176, 22);
            this.incomeAccountTextBox.TabIndex = 28;
            this.incomeAccountTextBox.Visible = false;
            // 
            // incomeAmountTextBox
            // 
            this.incomeAmountTextBox.Location = new System.Drawing.Point(687, 522);
            this.incomeAmountTextBox.Name = "incomeAmountTextBox";
            this.incomeAmountTextBox.Size = new System.Drawing.Size(176, 22);
            this.incomeAmountTextBox.TabIndex = 27;
            this.incomeAmountTextBox.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(546, 560);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Account:";
            this.label12.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(546, 525);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Amount:";
            this.label13.Visible = false;
            // 
            // addIncomeButton
            // 
            this.addIncomeButton.Location = new System.Drawing.Point(788, 444);
            this.addIncomeButton.Name = "addIncomeButton";
            this.addIncomeButton.Size = new System.Drawing.Size(75, 23);
            this.addIncomeButton.TabIndex = 29;
            this.addIncomeButton.Text = "Add";
            this.addIncomeButton.UseVisualStyleBackColor = true;
            this.addIncomeButton.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(543, 629);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 17);
            this.label14.TabIndex = 30;
            this.label14.Text = "Add Account:";
            this.label14.Visible = false;
            // 
            // addAccountNameTextBox
            // 
            this.addAccountNameTextBox.Location = new System.Drawing.Point(687, 662);
            this.addAccountNameTextBox.Name = "addAccountNameTextBox";
            this.addAccountNameTextBox.Size = new System.Drawing.Size(176, 22);
            this.addAccountNameTextBox.TabIndex = 32;
            this.addAccountNameTextBox.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(543, 665);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 17);
            this.label15.TabIndex = 31;
            this.label15.Text = "Name:";
            this.label15.Visible = false;
            // 
            // addAccountButton
            // 
            this.addAccountButton.Location = new System.Drawing.Point(788, 626);
            this.addAccountButton.Name = "addAccountButton";
            this.addAccountButton.Size = new System.Drawing.Size(75, 23);
            this.addAccountButton.TabIndex = 33;
            this.addAccountButton.Text = "Add";
            this.addAccountButton.UseVisualStyleBackColor = true;
            this.addAccountButton.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 523);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 17);
            this.label16.TabIndex = 34;
            this.label16.Text = "Switch Account:";
            this.label16.Visible = false;
            // 
            // switchAccountNameTextBox
            // 
            this.switchAccountNameTextBox.Location = new System.Drawing.Point(156, 561);
            this.switchAccountNameTextBox.Name = "switchAccountNameTextBox";
            this.switchAccountNameTextBox.Size = new System.Drawing.Size(176, 22);
            this.switchAccountNameTextBox.TabIndex = 36;
            this.switchAccountNameTextBox.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 564);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 17);
            this.label17.TabIndex = 35;
            this.label17.Text = "Name:";
            this.label17.Visible = false;
            // 
            // switchAccountButton
            // 
            this.switchAccountButton.Location = new System.Drawing.Point(257, 520);
            this.switchAccountButton.Name = "switchAccountButton";
            this.switchAccountButton.Size = new System.Drawing.Size(75, 23);
            this.switchAccountButton.TabIndex = 37;
            this.switchAccountButton.Text = "Switch";
            this.switchAccountButton.UseVisualStyleBackColor = true;
            this.switchAccountButton.Visible = false;
            // 
            // createCategoryUIButton
            // 
            this.createCategoryUIButton.Location = new System.Drawing.Point(15, 411);
            this.createCategoryUIButton.Name = "createCategoryUIButton";
            this.createCategoryUIButton.Size = new System.Drawing.Size(223, 23);
            this.createCategoryUIButton.TabIndex = 38;
            this.createCategoryUIButton.Text = "Create Category";
            this.createCategoryUIButton.UseVisualStyleBackColor = true;
            this.createCategoryUIButton.Click += new System.EventHandler(this.createCategoryUIButton_Click);
            // 
            // addExpenseUIButton
            // 
            this.addExpenseUIButton.Location = new System.Drawing.Point(244, 411);
            this.addExpenseUIButton.Name = "addExpenseUIButton";
            this.addExpenseUIButton.Size = new System.Drawing.Size(226, 23);
            this.addExpenseUIButton.TabIndex = 39;
            this.addExpenseUIButton.Text = "Add Expense";
            this.addExpenseUIButton.UseVisualStyleBackColor = true;
            this.addExpenseUIButton.Click += new System.EventHandler(this.addExpenseUIButton_Click);
            // 
            // addIncomeUIButton
            // 
            this.addIncomeUIButton.Location = new System.Drawing.Point(12, 440);
            this.addIncomeUIButton.Name = "addIncomeUIButton";
            this.addIncomeUIButton.Size = new System.Drawing.Size(226, 23);
            this.addIncomeUIButton.TabIndex = 40;
            this.addIncomeUIButton.Text = "Add Income";
            this.addIncomeUIButton.UseVisualStyleBackColor = true;
            this.addIncomeUIButton.Click += new System.EventHandler(this.addIncomeUIButton_Click);
            // 
            // addAccountUIButton
            // 
            this.addAccountUIButton.Location = new System.Drawing.Point(244, 440);
            this.addAccountUIButton.Name = "addAccountUIButton";
            this.addAccountUIButton.Size = new System.Drawing.Size(226, 23);
            this.addAccountUIButton.TabIndex = 41;
            this.addAccountUIButton.Text = "Add Account";
            this.addAccountUIButton.UseVisualStyleBackColor = true;
            this.addAccountUIButton.Click += new System.EventHandler(this.addAccountUIButton_Click);
            // 
            // editCategoryButton
            // 
            this.editCategoryButton.Location = new System.Drawing.Point(257, 606);
            this.editCategoryButton.Name = "editCategoryButton";
            this.editCategoryButton.Size = new System.Drawing.Size(75, 23);
            this.editCategoryButton.TabIndex = 47;
            this.editCategoryButton.Text = "Change";
            this.editCategoryButton.UseVisualStyleBackColor = true;
            this.editCategoryButton.Visible = false;
            // 
            // editCategoryNewTargetAmountTextBox
            // 
            this.editCategoryNewTargetAmountTextBox.Location = new System.Drawing.Point(156, 680);
            this.editCategoryNewTargetAmountTextBox.Name = "editCategoryNewTargetAmountTextBox";
            this.editCategoryNewTargetAmountTextBox.Size = new System.Drawing.Size(176, 22);
            this.editCategoryNewTargetAmountTextBox.TabIndex = 46;
            this.editCategoryNewTargetAmountTextBox.Visible = false;
            // 
            // editCategoryNameTextBox
            // 
            this.editCategoryNameTextBox.Location = new System.Drawing.Point(156, 646);
            this.editCategoryNameTextBox.Name = "editCategoryNameTextBox";
            this.editCategoryNameTextBox.Size = new System.Drawing.Size(176, 22);
            this.editCategoryNameTextBox.TabIndex = 45;
            this.editCategoryNameTextBox.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(12, 683);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 17);
            this.label18.TabIndex = 44;
            this.label18.Text = "New Target Amuont:";
            this.label18.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 649);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 17);
            this.label19.TabIndex = 43;
            this.label19.Text = "Name:";
            this.label19.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 609);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(92, 17);
            this.label20.TabIndex = 42;
            this.label20.Text = "Edit Categoy:";
            this.label20.Visible = false;
            // 
            // switchAccountUIButton
            // 
            this.switchAccountUIButton.Location = new System.Drawing.Point(12, 469);
            this.switchAccountUIButton.Name = "switchAccountUIButton";
            this.switchAccountUIButton.Size = new System.Drawing.Size(226, 23);
            this.switchAccountUIButton.TabIndex = 48;
            this.switchAccountUIButton.Text = "Switch Account";
            this.switchAccountUIButton.UseVisualStyleBackColor = true;
            this.switchAccountUIButton.Click += new System.EventHandler(this.switchAccountUIButton_Click);
            // 
            // editCategoryUIButton
            // 
            this.editCategoryUIButton.Location = new System.Drawing.Point(244, 469);
            this.editCategoryUIButton.Name = "editCategoryUIButton";
            this.editCategoryUIButton.Size = new System.Drawing.Size(226, 23);
            this.editCategoryUIButton.TabIndex = 49;
            this.editCategoryUIButton.Text = "Edit Category";
            this.editCategoryUIButton.UseVisualStyleBackColor = true;
            this.editCategoryUIButton.Click += new System.EventHandler(this.editCategoryUIButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(372, 520);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(136, 74);
            this.goBackButton.TabIndex = 50;
            this.goBackButton.Text = "Go Back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Visible = false;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 717);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.editCategoryUIButton);
            this.Controls.Add(this.switchAccountUIButton);
            this.Controls.Add(this.editCategoryButton);
            this.Controls.Add(this.editCategoryNewTargetAmountTextBox);
            this.Controls.Add(this.editCategoryNameTextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.addAccountUIButton);
            this.Controls.Add(this.addIncomeUIButton);
            this.Controls.Add(this.addExpenseUIButton);
            this.Controls.Add(this.createCategoryUIButton);
            this.Controls.Add(this.switchAccountButton);
            this.Controls.Add(this.switchAccountNameTextBox);
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
            this.Controls.Add(this.incomeDateMonth);
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
            this.Controls.Add(this.expenseDateMonth);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bindingNavigator1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.budget_TrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Budget_TrackerDataSet budget_TrackerDataSet;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox expenseDateMonth;
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
        private System.Windows.Forms.ComboBox incomeDateMonth;
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
        private System.Windows.Forms.TextBox switchAccountNameTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button switchAccountButton;
        private System.Windows.Forms.Button createCategoryUIButton;
        private System.Windows.Forms.Button addExpenseUIButton;
        private System.Windows.Forms.Button addIncomeUIButton;
        private System.Windows.Forms.Button addAccountUIButton;
        private System.Windows.Forms.Button editCategoryButton;
        private System.Windows.Forms.TextBox editCategoryNewTargetAmountTextBox;
        private System.Windows.Forms.TextBox editCategoryNameTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button switchAccountUIButton;
        private System.Windows.Forms.Button editCategoryUIButton;
        private System.Windows.Forms.Button goBackButton;
    }
}

