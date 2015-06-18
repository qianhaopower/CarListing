using CarListingDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CarListingDemo.Mapping
{
    public class EnquiryMapping : EntityTypeConfiguration<Enquiry>
    {
        #region Constructor

        public EnquiryMapping()
        {
            #region Primary key

            this.HasKey(t => t.EnquiryID);

            #endregion Primary key

            #region Validations

            this.Property(t => t.EnquiryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Content)
                .HasMaxLength(500);

            this.Property(t => t.EnquiryName).IsRequired();
            this.Property(t => t.Email).IsRequired();

            #endregion Validations

            #region Mappings

            this.ToTable("Enquiry");

            this.Property(t => t.EnquiryID).HasColumnName("EnquiryID");

            this.Property(t => t.EnquiryName).HasColumnName("EnquiryName");

            this.Property(t => t.Email).HasColumnName("Email");

            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.CarId).HasColumnName("CarId");

            #endregion Mappings


            #region Relationships

            this.HasRequired(t => t.Car)
         .WithMany(t => t.Enquiries)
         .HasForeignKey(t => t.CarId);
            #endregion Relationships
        }

        #endregion Constructor
    }
}