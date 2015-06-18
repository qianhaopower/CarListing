using CarListingDemo.DataLayer;
using CarListingDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarListingDemo.BusinessLayer
{

    /// <summary>
    /// Perform all business logic for cars
    /// </summary>
    public class CarBusinessLayer
    {

        private ICarDataAccess _ICarAccess;
        protected ICarDataAccess ICarAccess
        {
            get
            {
                return this._ICarAccess ?? (this._ICarAccess = DataAccessFactory.GetCarDataAccess());
            }
        }

       public  IEnumerable<Car> GetAllCars()
        {
            return ICarAccess.GetAllCars();
        }

       public IEnumerable<Car> SearchCars(string searchText)
       {
           return ICarAccess.SearchCars(searchText);
       }

        public Car GetCar(int carId)
        {
            return ICarAccess.GetCar(carId);
        }

    }
}