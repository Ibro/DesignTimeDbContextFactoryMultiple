using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class OtherDbContext : DbContext
    {
        public OtherDbContext(DbContextOptions<OtherDbContext> options)
            : base(options)
        {

        }

        public DbSet<Tag> Tags { get; set; }
    }
}
