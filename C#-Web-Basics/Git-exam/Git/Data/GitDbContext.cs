namespace Git.Data
{
    using Git.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class GitDbContext : DbContext
    {

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Repository> Repositories { get; set; }
        public virtual DbSet<Commit> Commits { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Git;Integrated Security=True;");
            }
        }
    }
}
