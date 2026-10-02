namespace PersonalBudgetTracker
{
    public partial class Form1 : Form
    {
        private TransactionManager manager = new TransactionManager();
        public Form1()
        {
            InitializeComponent();
            cmbType.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
        
        try
{
    manager.LoadTransactions();
    RefreshDisplay();
    }
catch (Exception ex)
{
    MessageBox.Show("Saved transactions could not be loaded: " + ex.Message);
}
}
private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.");
                return;
            }

            string category = cmbCategory.Text;
            string description = txtDescription.Text;
            DateTime date = dtpDate.Value;

            Transaction transaction;

            if (cmbType.SelectedIndex == 0)
            {
                transaction = new Income(amount, category, description, date);
            }
            else
            {
                transaction = new Expense(amount, category, description, date);
            }

            manager.AddTransaction(transaction);
            try
            {
                manager.SaveTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction could not be saved: " + ex.Message);
            }

            RefreshDisplay();
           

            

            txtAmount.Clear();
            txtDescription.Clear();
            dtpDate.Value = DateTime.Now;
        }

        private void lstTransactions_DoubleClick(object sender, EventArgs e)
        {

            if (lstTransactions.SelectedIndex == -1)
            {
                return;
            }

            Transaction transaction =
                manager.Transactions[lstTransactions.SelectedIndex];

            string type;

            if (transaction is Income)
            {
                type = "Income";
            }
            else
            {
                type = "Expense";
            }

            MessageBox.Show(
                $"Type: {type}\n" +
                $"Amount: ${transaction.Amount:0.00}\n" +
                $"Category: {transaction.Category}\n" +
                $"Description: {transaction.Description}\n" +
                $"Date: {transaction.Date.ToShortDateString()}",
                "Transaction Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
            if (lstTransactions.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a transaction.");
                return;
            }

            int index = lstTransactions.SelectedIndex;

            manager.RemoveTransaction(index);
            try
            {
                manager.SaveTransactions();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Changes could not be saved: " + ex.Message);
            }

            RefreshDisplay();
        }

        private void RefreshDisplay()
        {
            lstTransactions.Items.Clear();

            foreach (Transaction transaction in manager.Transactions)
            {
                string type = transaction is Income ? "Income" : "Expense";

                lstTransactions.Items.Add(
                    $"{transaction.Date.ToShortDateString()} - {type} - " +
                    $"{transaction.Category} - {transaction.Description} - " +
                    $"${transaction.Amount:0.00}");
            }

            lblTotalIncome.Text = $"${manager.GetTotalIncome():0.00}";
            lblTotalExpenses.Text = $"${manager.GetTotalExpenses():0.00}";
            lblBalance.Text = $"${manager.GetBalance():0.00}";
        }
    }
    }


