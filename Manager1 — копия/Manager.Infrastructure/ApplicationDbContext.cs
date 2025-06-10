using Manager.Domain.Entities; // Подключаем Entities
using Manager.Domain.ValueObjects; // Подключаем ValueObjects
using Microsoft.EntityFrameworkCore;

namespace Manager.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<ManagerEntity> Managers { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Deal> Deals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
