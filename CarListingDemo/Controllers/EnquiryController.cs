using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarListingDemo.Models;
using CarListingDemo.DataLayer;
using CarListingDemo.BusinessLayer;

namespace CarListingDemo.Controllers
{
    public class EnquiryController : Controller
    {
       
        readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);


        [HttpPost]
        public ActionResult Create(Enquiry enquiry)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    var carBusinessLayer = new EnquiryBusinessLayer();
                    carBusinessLayer.CreateEnquiry(enquiry);
                   
                    return Content("success");
                }

                return View(enquiry);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return null;
            }
        }
       
    }
}
