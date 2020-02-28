using HomeBudgetWebApp.Models.Enums;
using HomeBudgetWebApp.Models.Interfaces;
using System.Collections.Generic;

namespace HomeBudgetWebApp.Models.Domain
{
    public class BudgetAccount : IPayee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float OpeningBalance { get; set; }
        public float Balance { get; set; }
        public BudgetAccountType Type { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}