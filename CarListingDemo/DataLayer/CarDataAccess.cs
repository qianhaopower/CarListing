using CarListingDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarListingDemo.DataLayer
{
    public class CarDataAccess : ICarDataAccess
    {
        /// <summary>
        /// Get all cars
        /// </summary>
        /// <returns></returns>
       public  IEnumerable<Car> GetAllCars()
        {
            using (var dataContext = new CarDemoContext())
            {
                return dataContext.Cars.ToList();
            }
        }

        /// <summary>
        /// Get a car by id
        /// </summary>
        /// <param name="carId"></param>
        /// <returns></returns>
        public Car GetCar(int carId)
       {

           using (var dataContext = new CarDemoContext())
           {
               Car car = dataContext.Cars.Find(carId);

               //load all related enquiries realted with this car. 
               //dataContext.Entry(car).Collection(p => p.Enquiries).Load(); 
               return car;
           }
           
       }

        /// <summary>
        /// Get car based on search text
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns></returns>
        public IEnumerable<Car> SearchCars(string searchString)
        {
            using (var dataContext = new CarDemoContext())
            {
                var cars = dataContext.Cars.Where(s => s.Model.ToLower().Contains(searchString.ToLower())
                                           || s.Make.Contains(searchString.ToLower()));

                //load all related enquiries realted with this car. 
                //dataContext.Entry(car).Collection(p => p.Enquiries).Load();
                return cars.ToList();
            }
        }

    }
}