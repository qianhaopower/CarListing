using CarListingDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListingDemo.DataLayer
{
    public interface IEnquiryDataAccess
    {
        void CreateEnquiry(Enquiry entity);
    }
}
