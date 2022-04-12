using CA.Domain;
using Microsoft.EntityFrameworkCore;

namespace CA.Data
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Athlete> Athlete { get; set; }
    }
}
