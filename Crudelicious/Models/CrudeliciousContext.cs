using Microsoft.EntityFrameworkCore;

namespace Crudelicious.Models
{
    public class CrudeliciousContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public CrudeliciousContext (DbContextOptions options) : base (options) { }

        public DbSet<Dish> Dishes { get; set; }
    }
}