using System.Text.Json.Serialization;
namespace PersonalBudgetTracker
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(Income), "income")]
    [JsonDerivedType(typeof(Expense), "expense")]
    public abstract class Transaction
    {
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Transaction(decimal amount, string category, string description, DateTime date)
        {
            Amount = amount;
            Category = category;
            Description = description;
            Date = date;
        }

        public abstract decimal GetValue();
    }
}