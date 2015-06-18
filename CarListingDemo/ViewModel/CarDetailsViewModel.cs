using CarListingDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarListingDemo.ViewModel
{
    public class CarDetailsViewModel
    {
        public Car Car { get; set; }
        public Enquiry CarEnquiry { get; set; }

    }
}