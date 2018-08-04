namespace SalesPrep.Backend.Models
{
    using Domain.Models;

    public class LocalDataContext : DataContext
    {
        public System.Data.Entity.DbSet<SalesPrep.Domain.Models.Product> Products { get; set; }
    }
}