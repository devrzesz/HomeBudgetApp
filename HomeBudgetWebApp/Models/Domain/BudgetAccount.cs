using HomeBudgetWebApp.Models.Enums;
using System.Collections.Generic;

namespace HomeBudgetWebApp.Models.Domain
{
    public class BudgetAccount
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public float OpeningBalance { get; set; }
        public float Balance { get; set; }
        public BudgetAccountType Type { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}