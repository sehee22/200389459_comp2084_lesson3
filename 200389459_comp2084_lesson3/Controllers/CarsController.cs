using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _200389459_comp2084_lesson3.Models;

namespace _200389459_comp2084_lesson3.Controllers
{
    public class CarsController : Controller
    {
        List<Car> carList = new List<Car>()
        {
            new Car { Id = 1, Brand = "Toyota", Model = "Corolla", Type = "Compact", Year = 2017 },
            new Car { Id = 2, Brand = "Ford", Model = "F-150", Type = "Truck", Year = 2018 },
            new Car { Id = 3, Brand = "Dodge", Model = "Caravan", Type = "Minivan", Year = 2019 }
        };
        
        // GET: Cars
        public ActionResult Index()
        {
            return View(carList);
            // return Content("/Cars - This is a list of cars from Content()");
        }
    }
}