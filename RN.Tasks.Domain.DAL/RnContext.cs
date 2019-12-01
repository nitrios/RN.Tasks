using Microsoft.EntityFrameworkCore;
using RN.Tasks.Core;
using RN.Tasks.Domain.DAL.InitData;
using RN.Tasks.Domain.Entities;

namespace RN.Tasks.Domain.DAL
{
    public class RnContext : DbContext
    {
        public const string MigrationAssembly = "RN.Tasks.DAL";
        
        public RnContext(DbContextOptions options) : base(options)
        {
        }

        public RnContext()
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;

            var connectionString = AppSettings.Get().ConnectionString;

            optionsBuilder.UseSqlServer(connectionString,
                    b => b.MigrationsAssembly("RN.Tasks.Domain.DAL"));
            }
        
        public virtual DbSet<UserTask> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserTask>()
                .HasData(UserTaskInitData.Get());
        }
    }
}