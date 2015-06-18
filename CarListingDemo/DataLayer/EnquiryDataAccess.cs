using CarListingDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarListingDemo.DataLayer
{
    public class EnquiryDataAccess : IEnquiryDataAccess
    {

      public  void CreateEnquiry(Enquiry entity)
        {
            using (var dataContext = new CarDemoContext())
            {
                dataContext.Enquiries.Add(entity);
                dataContext.SaveChanges();
            }
        }
    }
}