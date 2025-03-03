namespace SelfHelpLedger.Models;

public class Transaction
{
    public int Id { get; set; }  // Primary Key
    public int MemberId { get; set; }  // Foreign Key
    public decimal Amount { get; set; }
    public string Type { get; set; } = string.Empty; // "Deposit" or "Withdrawal"
    public DateTime Date { get; set; } = DateTime.UtcNow;

    // Navigation Property
    public Member? Member { get; set; }
}
