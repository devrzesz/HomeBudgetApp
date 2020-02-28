using System.Data.Entity.ModelConfiguration;
using HomeBudgetWebApp.Models.Domain;

namespace HomeBudgetWebApp.Models.Entities.Configuratations
{
    public class BudgetAccountConfiguration 
        : EntityTypeConfiguration<BudgetAccount>
    {
        public BudgetAccountConfiguration()
        {
            HasKey(ba => ba.Id);

            Property(ba => ba.Balance)
                .IsOptional();
                
            Property(ba => ba.Name)
                .IsRequired()
                .HasMaxLength(50);

            Property(ba => ba.OpeningBalance)
                .IsOptional();

            Property(ba => ba.Type)
                .IsRequired();

            HasMany(ba => ba.Transactions)
                .WithRequired(t => (BudgetAccount)t.Payee)
                .HasForeignKey(t => t.PayeeId);

        }
    }
}