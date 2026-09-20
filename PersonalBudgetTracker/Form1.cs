namespace PersonalBudgetTracker
{
    public partial class Form1 : Form
    {
        private TransactionManager manager = new TransactionManager();
        public Form1()
        {
            InitializeComponent();
            cmbType.SelectedIndex = 0;
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

            Transaction transaction;

            if (cmbType.SelectedIndex == 0)
            {
                transaction = new Income(amount, "", "", DateTime.Now);
            }
            else
            {
                transaction = new Expense(amount, "", "", DateTime.Now);
            }

            manager.AddTransaction(transaction);

            lstTransactions.Items.Add($"{cmbType.Text}: ${amount:0.00}");

            lblTotalIncome.Text = $"${manager.GetTotalIncome():0.00}";
            lblTotalExpenses.Text = $"${manager.GetTotalExpenses():0.00}";
            lblBalance.Text = $"${manager.GetBalance():0.00}";

            txtAmount.Clear();
        }
    }
}
