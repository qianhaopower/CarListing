using CarListingDemo.Mapping;
using CarListingDemo.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CarListingDemo.DataLayer
{
    public class CarDemoContext : DbContext
    {
        public CarDemoContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Enquiry> Enquiries { get; set; }
     
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new CarMapping());
            modelBuilder.Configurations.Add(new EnquiryMapping());
        }
    }
}