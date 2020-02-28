using HomeBudgetWebApp.Models.Interfaces;

namespace HomeBudgetWebApp.Models.Domain
{
    public class Payee : IPayee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}