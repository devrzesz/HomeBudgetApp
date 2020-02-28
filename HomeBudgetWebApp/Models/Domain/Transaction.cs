using System;
using HomeBudgetWebApp.Models.Enums;
using HomeBudgetWebApp.Models.Interfaces;

namespace HomeBudgetWebApp.Models.Domain
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TransactionType Type { get; set; }

        public int PayeeId { get; set; }
        public int CategoryId { get; set; }

        public IPayee Payee{ get; set; }
        public ICategory Category{ get; set; }
    }
}