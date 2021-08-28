using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Upwork.Authorization.Roles;
using Upwork.Authorization.Users;
using Upwork.MultiTenancy;
using Upwork.Countries;
using Upwork.States;

namespace Upwork.EntityFrameworkCore
{
    public class UpworkDbContext : AbpZeroDbContext<Tenant, Role, User, UpworkDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<State> States { get; set; }

        public UpworkDbContext(DbContextOptions<UpworkDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<State>()
            .HasOne(p => p.Country)
            .WithMany(b => b.States)
            .HasForeignKey(p => p.CountryId)
            .IsRequired(true);
        }
    }
}
