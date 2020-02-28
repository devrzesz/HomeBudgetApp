using System.Collections.Generic;
using HomeBudgetWebApp.Models.Domain;

namespace HomeBudgetWebApp.Models.Interfaces
{
    public interface ICategory
    {
        int Id { get; set; }
        string Name { get; set; }

        IEnumerable<Transaction> Transactions { get; set; }
    }
}