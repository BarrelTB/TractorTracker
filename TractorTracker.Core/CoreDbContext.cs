using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TractorTracker.Core.Models;

namespace TractorTracker.Core
{
    public class CoreDbContext : DbContext
    {
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Chassis> Chassis { get; set; }
        public DbSet<Engine> Engine { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<Part> Part { get; set; }
        public DbSet<Rim> Rim { get; set; }
        public DbSet<Tire> Tire { get; set; }
        public DbSet<Transmission> Transmission { get; set; }
        public DbSet<Wheel> Wheel { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Worker> Worker { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=TractorTrackerDb;User Id=myUsername;Password=myPassword;Trusted_Connection=True; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Ignore<EntityBase>();
            modelBuilder.Ignore<EquipmentBase>();

            ConfigureDeleteBehaviorRestrict(modelBuilder);
        }

        private void ConfigureDeleteBehaviorRestrict(ModelBuilder modelBuilder)
        {
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                foreach (var foreignKey in entityType.GetForeignKeys())
                {
                    foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
                }
            }
        }
    }
}
