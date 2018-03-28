using System.Data.Entity;
using DAL.Entities;

namespace DAL.EF
{
    public class BLContext:DbContext
    {
        //public BLContext(string connectionString) : base(connectionString)
        public BLContext(string connectionString) : base(connectionString)
        {
        }
        public DbSet<PersonBase> PersonBases { get; set; }
    }
}
