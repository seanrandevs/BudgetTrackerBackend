using Microsoft.EntityFrameworkCore;
using BudgetTrackerBackend.Models;

namespace BudgetTrackerBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // DbSet to represent the Transactions table
        public DbSet<Transaction> Transactions { get; set; }
    }
}