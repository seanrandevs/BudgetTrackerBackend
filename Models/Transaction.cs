namespace BudgetTrackerBackend.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public required string Type { get; set; } // Required modifier
        public required string Category { get; set; } // Required modifier
        public required string Description { get; set; } // Required modifier
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}