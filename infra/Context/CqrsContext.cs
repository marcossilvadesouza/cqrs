using core.Entity;
using Microsoft.EntityFrameworkCore;

namespace infra.Context
{
    public class CqrsContext : DbContext
    {
        public CqrsContext(DbContextOptions<CqrsContext> options) : base(options)
        {                
        }

        public DbSet<Curso> Curso { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CqrsContext).Assembly);
        }
    }
}
