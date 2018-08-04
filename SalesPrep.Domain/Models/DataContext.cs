namespace SalesPrep.Domain.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<SalesPrep.Domain.Models.Product> Products { get; set; }
    }
}