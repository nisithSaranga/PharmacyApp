using Microsoft.EntityFrameworkCore;
using pharmacyapp.server.Models; // Your models are here

namespace pharmacyapp.server.Data // Adjust to your real namespace/folder structure
{
    public class PharmacyContext : DbContext
    {
        public PharmacyContext(DbContextOptions<PharmacyContext> options) : base(options) { }

        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<User> Users { get; set; }



    }
}
