namespace SelfHelpLedger.Models;
using System;
public class Transaction
{
    public int Id { get; set; }  
    public int MemberId { get; set; }  
    public decimal Amount { get; set; }
    public string Type { get; set; } = string.Empty; 
    public DateTime Date { get; set; } = DateTime.UtcNow;
    public string TransactionNumber { get; set; } = string.Empty;
    public Member? Member { get; set; }
}
