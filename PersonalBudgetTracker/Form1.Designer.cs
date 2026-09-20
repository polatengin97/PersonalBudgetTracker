namespace PersonalBudgetTracker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblBalanceTitle = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            lblTitle = new Label();
            lblBalance = new Label();
            lblTotalIncome = new Label();
            lblTotalExpenses = new Label();
            lblIncomeTitle = new Label();
            lblExpensesTitle = new Label();
            panel4 = new Panel();
            lblType = new Label();
            cmbType = new ComboBox();
            txtAmount = new TextBox();
            lblAmount = new Label();
            btnAdd = new Button();
            panel5 = new Panel();
            label1 = new Label();
            lstTransactions = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblBalance);
            panel1.Controls.Add(lblBalanceTitle);
            panel1.Location = new Point(36, 81);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(153, 83);
            panel1.TabIndex = 0;
            // 
            // lblBalanceTitle
            // 
            lblBalanceTitle.AutoSize = true;
            lblBalanceTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalanceTitle.Location = new Point(14, 17);
            lblBalanceTitle.Margin = new Padding(4, 0, 4, 0);
            lblBalanceTitle.Name = "lblBalanceTitle";
            lblBalanceTitle.Size = new Size(135, 21);
            lblBalanceTitle.TabIndex = 1;
            lblBalanceTitle.Text = "Current Balance ";
            lblBalanceTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblIncomeTitle);
            panel2.Controls.Add(lblTotalIncome);
            panel2.Location = new Point(223, 81);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(151, 83);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblExpensesTitle);
            panel3.Controls.Add(lblTotalExpenses);
            panel3.Location = new Point(407, 81);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(154, 83);
            panel3.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(36, 25);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(285, 30);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "Personal Budget Dashboard";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.Location = new Point(51, 53);
            lblBalance.Margin = new Padding(4, 0, 4, 0);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(49, 19);
            lblBalance.TabIndex = 2;
            lblBalance.Text = "$0.00";
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalIncome.ForeColor = Color.FromArgb(0, 192, 0);
            lblTotalIncome.Location = new Point(48, 53);
            lblTotalIncome.Margin = new Padding(4, 0, 4, 0);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(49, 19);
            lblTotalIncome.TabIndex = 3;
            lblTotalIncome.Text = "$0.00";
            // 
            // lblTotalExpenses
            // 
            lblTotalExpenses.AutoSize = true;
            lblTotalExpenses.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalExpenses.ForeColor = Color.FromArgb(192, 0, 0);
            lblTotalExpenses.Location = new Point(51, 53);
            lblTotalExpenses.Margin = new Padding(4, 0, 4, 0);
            lblTotalExpenses.Name = "lblTotalExpenses";
            lblTotalExpenses.Size = new Size(49, 19);
            lblTotalExpenses.TabIndex = 3;
            lblTotalExpenses.Text = "$0.00";
            // 
            // lblIncomeTitle
            // 
            lblIncomeTitle.AutoSize = true;
            lblIncomeTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIncomeTitle.Location = new Point(18, 17);
            lblIncomeTitle.Margin = new Padding(4, 0, 4, 0);
            lblIncomeTitle.Name = "lblIncomeTitle";
            lblIncomeTitle.Size = new Size(109, 21);
            lblIncomeTitle.TabIndex = 4;
            lblIncomeTitle.Text = "Total Income";
            lblIncomeTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblIncomeTitle.Click += label1_Click;
            // 
            // lblExpensesTitle
            // 
            lblExpensesTitle.AutoSize = true;
            lblExpensesTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExpensesTitle.Location = new Point(23, 17);
            lblExpensesTitle.Margin = new Padding(4, 0, 4, 0);
            lblExpensesTitle.Name = "lblExpensesTitle";
            lblExpensesTitle.Size = new Size(115, 21);
            lblExpensesTitle.TabIndex = 4;
            lblExpensesTitle.Text = "Total Expense";
            lblExpensesTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(lblAmount);
            panel4.Controls.Add(txtAmount);
            panel4.Controls.Add(cmbType);
            panel4.Controls.Add(lblType);
            panel4.Location = new Point(36, 193);
            panel4.Name = "panel4";
            panel4.Size = new Size(228, 262);
            panel4.TabIndex = 4;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.Location = new Point(14, 11);
            lblType.Name = "lblType";
            lblType.Size = new Size(127, 20);
            lblType.TabIndex = 0;
            lblType.Text = "Transaction Type\n";
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Income ", "Expense" });
            cmbType.Location = new Point(14, 43);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(163, 28);
            cmbType.TabIndex = 1;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(14, 129);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(100, 27);
            txtAmount.TabIndex = 3;
            txtAmount.Text = "0.00";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAmount.Location = new Point(14, 94);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(67, 20);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Amount";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Blue;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(14, 184);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(195, 33);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "ADD TRANSACTION";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lstTransactions);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(310, 193);
            panel5.Name = "panel5";
            panel5.Size = new Size(251, 262);
            panel5.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 11);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Recent Transactions";
            // 
            // lstTransactions
            // 
            lstTransactions.FormattingEnabled = true;
            lstTransactions.Location = new Point(20, 38);
            lstTransactions.Name = "lstTransactions";
            lstTransactions.Size = new Size(215, 204);
            lstTransactions.TabIndex = 1;
            lstTransactions.SelectedIndexChanged += lstTransactions_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1029, 748);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(lblTitle);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Location = new Point(50, 100);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblBalance;
        private Label lblBalanceTitle;
        private Panel panel2;
        private Panel panel3;
        private Label lblTitle;
        private Label lblTotalIncome;
        private Label lblTotalExpenses;
        private Label lblIncomeTitle;
        private Label lblExpensesTitle;
        private Panel panel4;
        private ComboBox cmbType;
        private Label lblType;
        private TextBox txtAmount;
        private Label lblAmount;
        private Button btnAdd;
        private Panel panel5;
        private ListBox lstTransactions;
        private Label label1;
    }
}
