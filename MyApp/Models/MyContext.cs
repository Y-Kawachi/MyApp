using MyApp.Models.Entity;
using System.Data.Entity;

namespace MyApp.Models
{
    public class MyContext : DbContext
    {
        public MyContext() : base() {}

        public DbSet<Header> Headers { get; set; }
        public DbSet<Detail> Details { get; set; }
    }
}