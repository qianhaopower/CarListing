
using CarListingDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarListingDemo.DataLayer
{
    public class CarInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CarDemoContext>
    {

        protected override void Seed(CarDemoContext context)
        {
            var cars = new List<Car>
            {
            new Car{
                Make = "Nissan",
                Model = "Pulsar",
                SaleType = (int)SaleTypeEnum.Dealer,
                Year = new DateTime(2015,1,1),
                PriceType = (int) PriceTypeEnum.POA,
                Email = "name@gmail.com.au",
                ABN = "53004085616",
                Comments = "A good car, buy it quickly!",
            },

               new Car{
                Make = "Toyota",
                Model = "Camary",
                SaleType = (int)SaleTypeEnum.Private,
                Year = new DateTime(1987,1,1),
                PriceType = (int) PriceTypeEnum.DAP,
                DapPrice = 22500,
                Email = "operates@gmail.com.au",
                ContactName = "John Smith",
                Phone = "0425874452",
                Comments = "A even better car, buy it quickly!",
            },

              new Car{
                Make = "SSANGYONG",
                Model = "Pulsar",
                SaleType = (int)SaleTypeEnum.Dealer,
                Year = new DateTime(2013,1,1),
                PriceType = (int) PriceTypeEnum.DAP,
                DapPrice = 22500,
                Email = "objects@gmail.com.au",
                ABN = "53004085616",
                Comments = "A good car, buy it quickly!",
            },

              new Car{
                Make = "SKODA",
                Model = "Camary",
                SaleType = (int)SaleTypeEnum.Dealer,
                Year = new DateTime(2012,1,1),
                PriceType = (int) PriceTypeEnum.DAP,
                DapPrice = 22500,
                Email = "already@gmail.com.au",
                ABN = "53004085616",
                Comments = "A good car, buy it quickly!",
            },

              new Car{
                Make = "SAAB",
                Model = "Camary",
                SaleType = (int)SaleTypeEnum.Dealer,
                Year = new DateTime(2011,1,1),
                PriceType = (int) PriceTypeEnum.EGC,
                EgcPrice = 35854,
                Email = "more@gmail.com.au",
                ABN = "53004085616",
                Comments = "A good car, buy it quickly!",
            },

              new Car{
                Make = "JAGUAR",
                Model = "Aygo",
                SaleType = (int)SaleTypeEnum.Private,
                Year = new DateTime(1965,1,1),
                PriceType = (int) PriceTypeEnum.EGC,
                EgcPrice = 22500,
                Email = "carSeller@gmail.com.au",
                ContactName = "John Smith",
                Phone = "0425874452",
                Comments = "A good car, buy it quickly!",
            },

              new Car{
                Make = "Toyota",
                Model = "Condor",
                SaleType = (int)SaleTypeEnum.Private,
                Year = new DateTime(1936,1,1),
                PriceType = (int) PriceTypeEnum.EGC,
                EgcPrice = 22500,
                Email = "carSeller@gmail.com.au",
                ContactName = "John Smith",
                Phone = "0425874452",
                Comments = "A good car, buy it quickly!",
            },

              new Car{
                Make = "DAEWOO",
                Model = "Dyna",
                SaleType = (int)SaleTypeEnum.Private,
                Year = new DateTime(2006,1,1),
                PriceType = (int) PriceTypeEnum.DAP,
                DapPrice = 22500,
                Email = "carSeller@gmail.com.au",
                ContactName = "John Smith",
                Phone = "0425874452",
                Comments = "A good car, buy it quickly!",
            },

              new Car{
                Make = "RANGE ROVER",
                Model = "Land",
                SaleType = (int)SaleTypeEnum.Private,
                Year = new DateTime(2004,1,1),
                PriceType = (int) PriceTypeEnum.POA,
                Email = "carSeller@gmail.com.au",
                ContactName = "John Smith",
                Phone = "0425874452",
                Comments = "A good car, buy it quickly!",
            },

              new Car{
                Make = "ISUZU",
                Model = "Matrix",
                SaleType = (int)SaleTypeEnum.Private,
                Year = new DateTime(2004,1,1),
                PriceType = (int) PriceTypeEnum.POA,
                Email = "carSeller@gmail.com.au",
                ContactName = "John Smith",
                Phone = "0425874452",
                Comments = "ression evaluates to an array!",
            },

            new Car{
                Make = "CHRYSLER",
                Model = "Crown",
                SaleType = (int)SaleTypeEnum.Private,
                Year = new DateTime(2003,1,1),
                PriceType = (int) PriceTypeEnum.DAP,
                DapPrice = 22500,
                Email = "carSeller@gmail.com.au",
                ContactName = "John Smith",
                Phone = "0425874452",
                Comments = "reviously added classes are removed!",
            },
            

            new Car{
                Make = "ALFA ROMEO",
                Model = "Etios",
                SaleType = (int)SaleTypeEnum.Private,
                Year = new DateTime(1984,1,1),
                PriceType = (int) PriceTypeEnum.POA,
                Email = "carSeller@gmail.com.au",
                ContactName = "John Smith",
                Phone = "0425874452",
                Comments = "key-value pair of the object with !",
            },
            

            new Car{
                Make = "PROTON",
                Model = "Hilux",
                SaleType = (int)SaleTypeEnum.Private,
                Year = new DateTime(2014,1,1),
                PriceType = (int) PriceTypeEnum.DAP,
                DapPrice = 22500,
                Email = "carSeller@gmail.com.au",
                ContactName = "John Smith",
                Phone = "0425874452",
                Comments = "more space-delimited class n!",
            },
            

            new Car{
                Make = "INFINITI",
                Model = "Belta",
                SaleType = (int)SaleTypeEnum.Private,
                Year = new DateTime(2010,1,1),
                PriceType = (int) PriceTypeEnum.DAP,
                DapPrice = 22500,
                Email = "carSeller@gmail.com.au",
                ContactName = "John Smith",
                Phone = "0425874452",
                Comments = "orts CSS3 Transitions/Animations even if they do no",
            },
            

            new Car{
                Make = "CHEVROLET",
                Model = "Corolla",
                SaleType = (int)SaleTypeEnum.Private,
                Year = new DateTime(2003,1,1),
                PriceType = (int) PriceTypeEnum.DAP,
                DapPrice = 22500,
                Email = "carSeller@gmail.com.au",
                ContactName = "John Smith",
                Phone = "0425874452",
                Comments = " styles for key aspects of th!",
            },
            

            new Car{
                Make = "ABARTH",
                Model = "IQ",
                SaleType = (int)SaleTypeEnum.Private,
                Year = new DateTime(2010,1,1),
                PriceType = (int) PriceTypeEnum.DAP,
                DapPrice = 22500,
                Email = "carSeller@gmail.com.au",
                ContactName = "John Smith",
                Phone = "0425874452",
                Comments = " pieces of Bootstrap's infrastr!",
            },
            
            
            };

            cars.ForEach(s => context.Cars.Add(s));
            context.SaveChanges();
        }
    }
}