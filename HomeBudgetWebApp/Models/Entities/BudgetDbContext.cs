using System.Data.Entity;
using HomeBudgetWebApp.Models.Domain;

namespace HomeBudgetWebApp.Models.Entities
{
    public class BudgetDbContext : DbContext
    {
        public DbSet<BudgetAccount> budgetAccounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Payee> Payees { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        public BudgetDbContext()
            : base("name=DefaultConnection")
        {

        }
    }
}