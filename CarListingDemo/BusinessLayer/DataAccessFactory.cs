using CarListingDemo.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarListingDemo.BusinessLayer
{

    /// <summary>
    /// Providing DataAccess instances. 
    /// </summary>
    public class DataAccessFactory
    {
        public static ICarDataAccess GetCarDataAccess()
        {
            return new CarDataAccess();
        }


        internal static IEnquiryDataAccess GetEnquiryDataAccess()
        {
            return new EnquiryDataAccess();
        }
    }
}