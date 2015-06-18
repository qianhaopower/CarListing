using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarListingDemo.Models;
using CarListingDemo.BusinessLayer;
using CarListingDemo.ViewModel;
using PagedList;


namespace CarListingDemo.Controllers
{
    public class CarController : Controller
    {
        readonly log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        // GET: /Car/
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        
        {
            try
            {
                ViewBag.CurrentSort = sortOrder;


                if (searchString != null)
                {
                    page = 1;
                }
                else
                {
                    searchString = currentFilter;
                }

                ViewBag.CurrentFilter = searchString;
                ViewBag.ModelSortParm = String.IsNullOrEmpty(sortOrder) ? "model_desc" : "";
                ViewBag.YearSortParm = sortOrder == "Year" ? "year_desc" : "Year";
                var carBusinessLayer = new CarBusinessLayer();
                IEnumerable<Car> cars = new List<Car>(); 

                if (String.IsNullOrEmpty(searchString))
                {
                    cars = carBusinessLayer.GetAllCars();
                }
                else
                {
                    cars = carBusinessLayer.SearchCars(searchString);
                }
                switch (sortOrder)
                {
                    case "model_desc":
                        cars = cars.OrderByDescending(s => s.Model);
                        break;
                    case "Year":
                        cars = cars.OrderBy(s => s.Year);
                        break;
                    case "year_desc":
                        cars = cars.OrderByDescending(s => s.Year);
                        break;
                    default:
                        cars = cars.OrderBy(s => s.Model);
                        break;
                }

              
                int pageSize = 5;
                int pageNumber = (page ?? 1);
                return View(cars.ToPagedList(pageNumber, pageSize));

            }catch(Exception ex)
            {
                logger.Error(ex.Message);
                return null;
            }
        }

        // GET: /Car/Details/5
        public ActionResult Details(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var carBusinessLayer = new CarBusinessLayer();
                var car = carBusinessLayer.GetCar(id.Value);

                if (car == null)
                {
                    return HttpNotFound();
                }
                else
                {
                    CarDetailsViewModel viewModel = new CarDetailsViewModel
                    {
                        Car = car,
                        CarEnquiry = new Enquiry(),
                    };
                    return View(viewModel);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return null;
            }
        }

        public ActionResult ThankYou()
        {
            return View("ThankYou");
        }

       
    }
}
