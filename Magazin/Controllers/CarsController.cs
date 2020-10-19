using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Magazin.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Magazin.Controllers
{
    public class CarsController : Controller 
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List()
        {
            var cars = _allCars.Cars;
            return View(cars);
        }
    }
}
