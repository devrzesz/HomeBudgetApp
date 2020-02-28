using HomeBudgetWebApp.Models.Interfaces;
using System.Collections.Generic;

namespace HomeBudgetWebApp.Models.Domain
{
    public class SubCategory : ICategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MainCategoryId { get; set; }

        public Category MainCategory { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }

    }
}