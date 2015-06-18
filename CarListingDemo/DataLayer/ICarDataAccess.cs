using CarListingDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListingDemo.DataLayer
{
   public  interface ICarDataAccess
    {
        IEnumerable<Car> GetAllCars();
        Car GetCar(int carId);

        IEnumerable<Car> SearchCars(string searchText);
    }
}
