using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeBudgetWebApp.Models.Interfaces
{
    public interface ICategory
    {
        int Id { get; set; }
        string Name { get; set; }

        IEnumerable<Transaction> Transactions { get; set; }
        IEnumerable<SubCategory> SubCategories { get; set; }
    }
}