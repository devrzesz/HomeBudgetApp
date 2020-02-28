using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeBudgetWebApp.Models.Domain
{
    public class BudgetAccount
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public float OpeningBalance { get; set; }
        public float Balance { get; set; }
        public byte Type { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}