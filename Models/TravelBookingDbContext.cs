using Microsoft.EntityFrameworkCore;

namespace TravelBookingModels.Models
{
    public class TravelBookingDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Agency> Agencies { get; set; }
        public DbSet<TravelPackage> TravelPackages { get; set; }
        public DbSet<Booking> Bookings { get; set; }


           protected override void OnModelCreating(ModelBuilder modelBuilder)
           { 
                // User-Booking relationship
                modelBuilder.Entity<Booking>()
                .HasOne(b => b.User)
                .WithMany(u => u.Bookings)
                .HasForeignKey(b => b.UserId);

                // TravelPackage-Booking relationship
                modelBuilder.Entity<Booking>()
                .HasOne(b => b.TravelPackage)
                .WithMany(tp => tp.Bookings)
                .HasForeignKey(b => b.PackageId);


                // Agency-TravelPackage relationship
                 modelBuilder.Entity<TravelPackage>()
                .HasOne(tp => tp.ManagingAgency)
                .WithMany(a => a.ManagedPackages)
                .HasForeignKey(tp => tp.AgencyId);


               // Configuring inheritance
               modelBuilder.Entity<Agency>()
                .HasBaseType<User>();

               modelBuilder.Entity<Customer>()
                .HasBaseType<User>();



            base.OnModelCreating(modelBuilder);

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-BGVTK21;Initial Catalog=TravelBooking;Integrated Security=True;Pooling=False;Encrypt=False;Trust Server Certificate=True");
        }
    }
}
