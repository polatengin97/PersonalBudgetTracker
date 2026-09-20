namespace PersonalBudgetTracker
{
    public class TransactionManager
    {
        public List<Transaction> Transactions { get; private set; }

        public TransactionManager()
        {
            Transactions = new List<Transaction>();
        }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }

        public decimal GetTotalIncome()
        {
            return Transactions
                .Where(transaction => transaction is Income)
                .Sum(transaction => transaction.Amount);
        }

        public decimal GetTotalExpenses()
        {
            return Transactions
                .Where(transaction => transaction is Expense)
                .Sum(transaction => transaction.Amount);
        }

        public decimal GetBalance()
        {
            return Transactions.Sum(transaction => transaction.GetValue());
        }
    }
}