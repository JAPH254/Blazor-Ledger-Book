namespace SelfHelpLedger.Models;

public class Member
{
    public int Id { get; set; } 
    public string Name { get; set; } = string.Empty;
    public decimal Balance { get; set; } = 0;
    public List<Transaction> Transactions { get; set; } = new();
}
