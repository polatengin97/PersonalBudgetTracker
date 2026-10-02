using System.Text.Json;
namespace PersonalBudgetTracker
{
    public class TransactionManager
    {
        public void SaveTransactions()
        {
            JsonSerializerOptions options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(Transactions, options);
            File.WriteAllText("transactions.json", json);
        }

        public void LoadTransactions()
        {
            if (!File.Exists("transactions.json"))
            {
                return;
            }

            string json = File.ReadAllText("transactions.json");

            List<Transaction>? loadedTransactions =
                JsonSerializer.Deserialize<List<Transaction>>(json);

            if (loadedTransactions != null)
            {
                Transactions = loadedTransactions;
            }
        }
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
        public void RemoveTransaction(int index)
        {
            Transactions.RemoveAt(index);
        }
    }
}