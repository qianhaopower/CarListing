using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarListingDemo.Models
{
    public enum PriceTypeEnum
    {
        POA =1,
        DAP =2,
        EGC=  3,
        Other = 0,
    }

    public enum SaleTypeEnum
    {
        Dealer =1,
        Private =2,
        Other =0,
    }


    public class Car
    {

        public Car()
        {
            this.Enquiries = new HashSet<Enquiry>();
        }

    
        [DisplayName("Sale Type")]
        public string SaleTypeDescription
        {
            get
            {
                return ((SaleTypeEnum)(this.SaleType)).ToString();
            }
        }

       
        [DisplayName("Price Type")]
        public string PriceTypeDescription
        {
            get
            {
                return ((PriceTypeEnum)(this.PriceType)).ToString();
            }
        }

        
        public int CarId { get; set; }

        public string Make { get; set; }
        public string Model { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Year { get; set; }

        public int PriceType {get;set;}

        [DisplayName("Excluding government charges price")]
        public decimal EgcPrice { get; set; }

        [DisplayName("Drive away price")]
        public decimal DapPrice { get; set; }


        public int SaleType { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DisplayName("Contact Name")]
        public string ContactName { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DisplayName("Dealer ABN")]
        public string ABN { get; set; }

        
        [DataType(DataType.Text)]
        public string Comments { get; set; }

        public virtual ICollection<Enquiry> Enquiries { get; set; }

    }
}