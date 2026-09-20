namespace PersonalBudgetTracker
{
    public class Income : Transaction
    {
        public Income(decimal amount, string category, string description, DateTime date)
            : base(amount, category, description, date)
        {
        }

        public override decimal GetValue()
        {
            return Amount;
        }
    }
}