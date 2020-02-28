using System.Data.Entity;
using HomeBudgetWebApp.Models.Domain;
using HomeBudgetWebApp.Models.Entities.Configuratations;

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
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BudgetAccountConfiguration());
        }
    }
}