using Microsoft.EntityFrameworkCore;
using SelfHelpLedger.Models;

namespace SelfHelpLedger.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Member> Members { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Transaction>()
            .HasOne(t => t.Member)
            .WithMany(m => m.Transactions)
            .HasForeignKey(t => t.MemberId);
    }
}
