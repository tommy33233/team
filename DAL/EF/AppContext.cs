using System.Data.Entity;
using DAL.Entities;

namespace DAL.EF
{
   public class AppContext:DbContext
    {
        public AppContext(string connectionString) : base(connectionString)
        {
        }
        public DbSet<PersonBase> Persons { get; set; }
    }
}
