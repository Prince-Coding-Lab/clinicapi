using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Clinic.Api.Core;
using Clinic.Api.Core.Entities;

namespace Clinic.Api.Infrastructure
{
    public class ClinicContext : DbContext
    {
        public ClinicContext(DbContextOptions<ClinicContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<LovStatus> lov_status { get; set; }
        public DbSet<LovStatusType> lov_statustype { get; set; }
        public DbSet<ExceptionApi> ExceptionApi { get; set; }
        public DbSet<ExceptionWeb> ExceptionWeb { get; set; }
        public DbSet<TokenVerification> token_verification { get; set; }
        public DbSet<Clinic.Api.Core.Entities.Clinic> Clinics { get; set; }
        public DbSet<ClinicAddress> ClinicAddresses { get; set; }
        public DbSet<ClinicCategory> ClinicCategories { get; set; }
        public DbSet<ClinicService> ClinicServices { get; set; }
        //public DbSet<ContactClinic> ContactClinics { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        //public DbSet<Favourite> Favourites { get; set; }
        //public DbSet<Offer> Offers { get; set; }
        //public DbSet<PaymentReference> PaymentReferences { get; set; }
        //public DbSet<Press> Press { get; set; }
        //public DbSet<Review> Reviews { get; set; }
        //public DbSet<LovStatus> lov_status { get; set; }
        //public DbSet<SubscriptionPlan> SubscriptionPlans { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Role>().HasData(
               new Role{Id=1, RoleName = "Admin"},
               new Role { Id = 2, RoleName = "ClinicUser" },
               new Role { Id = 3, RoleName = "User" }
             );
            builder.Entity<Clinic.Api.Core.Entities.Clinic>()
           .HasOne<User>(c => c.CreatedByUser)
           .WithMany(u => u.ClinicsCreated)
           .HasForeignKey(c => c.CreatedBy);

            builder.Entity<Clinic.Api.Core.Entities.Clinic>()
           .HasOne<User>(c => c.ModifiedByUser)
           .WithMany(u => u.ClinicsModified)
           .HasForeignKey(c => c.ModifiedBy);

            // builder.Entity<ServicesInClinic>().HasKey(sc => new { sc.ClinicId, sc.ClinicServiceId });
            //base.OnModelCreating(builder);
            //builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
