using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CarListingDemo.Models
{
    public class Enquiry
    {
       
        public int EnquiryID { get; set; }


        [DisplayName("Enquiry Name")]
        public string EnquiryName { get;set; }

       
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

      
        [DataType(DataType.Text)]
        [DisplayName("Content")]
        public string Content { get; set; }

        public int CarId { get; set; }


        public Car Car { get; set; }
        

    }
}