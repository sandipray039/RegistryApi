using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using RegistryApi.Models;

namespace RegistryApi.Db
{
    public class RegistryDbContext : IdentityDbContext<ApplicationUser>
    {
        public RegistryDbContext(DbContextOptions<RegistryDbContext> options) : base(options)
        {
        }

        public DbSet<Attendence> Attendances { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Attendence>()
                .HasOne(a => a.User)
                .WithMany()
                .HasForeignKey(a => a.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Attendence>()
                .HasOne(a => a.Location)
                .WithMany()
                .HasForeignKey(a => a.LocationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
