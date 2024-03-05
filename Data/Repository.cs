using Microsoft.EntityFrameworkCore;

namespace Challenge.Data
{
    public class Repository : DbContext
    {
        public Repository(DbContextOptions<Repository> opts) : base(opts)
        {

        }

        public DbSet<ChallengeClass> Challenges { get; set; } = null!;
    }
}
