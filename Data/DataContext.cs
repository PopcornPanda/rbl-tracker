using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace rbl_tracker.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Rbl> Rbls => Set<Rbl>();
    }
}