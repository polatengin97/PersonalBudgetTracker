namespace PersonalBudgetTracker
{
    public class Expense : Transaction
    {
        public Expense(decimal amount, string category, string description, DateTime date)
            : base(amount, category, description, date)
        {
        }

        public override decimal GetValue()
        {
            return -Amount;
        }
    }
}