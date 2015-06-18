using CarListingDemo.DataLayer;
using CarListingDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarListingDemo.BusinessLayer
{
    /// <summary>
    /// perform data access for enquiries
    /// </summary>
    public class EnquiryBusinessLayer
    {
        private IEnquiryDataAccess _IEnquiryAccess;
        protected IEnquiryDataAccess IEnquiryAccess
        {
            get
            {
                return this._IEnquiryAccess ?? (this._IEnquiryAccess = DataAccessFactory.GetEnquiryDataAccess());
            }
        }

       public void CreateEnquiry(Enquiry entity)
        {
            IEnquiryAccess.CreateEnquiry(entity);
        }
    }
}