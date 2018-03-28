using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;

namespace DAL.EF
{
    class TestContext:DbContext
    {
        public TestContext() : base("BLDB")
        {
        }
        public DbSet<PersonBase> PersonBases { get; set; }
        public DbSet<News> News { get; set; }
    }
}
