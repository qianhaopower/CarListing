using CarListingDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CarListingDemo.Mapping
{
    public class CarMapping : EntityTypeConfiguration<Car>
    {
         #region Constructor

        public CarMapping()
        {
            #region Primary key

            this.HasKey(t => t.CarId);

            #endregion Primary key

            #region Validations

            this.Property(t => t.CarId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Ignore(t => t.SaleTypeDescription);
            this.Ignore(t => t.PriceTypeDescription);

           

            this.Property(t => t.Comments)
                .HasMaxLength(200);


            #endregion Validations

            #region Mappings

            this.ToTable("Car");
            this.Property(t => t.CarId).HasColumnName("CarId");
            this.Property(t => t.Make).HasColumnName("Make");

            this.Property(t => t.Model).HasColumnName("Model");

            this.Property(t => t.Year).HasColumnName("Year");

            this.Property(t => t.PriceType).HasColumnName("PriceType");
            this.Property(t => t.EgcPrice).HasColumnName("EgcPrice");
            this.Property(t => t.DapPrice).HasColumnName("DapPrice");
            this.Property(t => t.SaleType).HasColumnName("SaleType");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.ContactName).HasColumnName("ContactName");

            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.ABN).HasColumnName("ABN");
            this.Property(t => t.Comments).HasColumnName("Comments");
       
            #endregion Mappings


            #region Relationships
            #endregion Relationships
        }

        #endregion Constructor
    }
}