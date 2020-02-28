using HomeBudgetWebApp.Models.Interfaces;
using System.Collections.Generic;

namespace HomeBudgetWebApp.Models.Domain
{
    public class Category : ICategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Transaction> Transactions { get; set; }
        public IEnumerable<SubCategory> SubCategories { get; set; }

    }
}