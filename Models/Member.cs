namespace SelfHelpLedger.Models;

public class Member
{
    public int Id { get; set; }  // Primary Key
    public string Name { get; set; } = string.Empty;
    public decimal Balance { get; set; } = 0;
    
    // One member has many transactions
    public List<Transaction> Transactions { get; set; } = new();
}
