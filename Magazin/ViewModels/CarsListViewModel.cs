using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Magazin.Data.Models;

namespace Magazin.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }

        public string currCategory { get; set; }
    }
}
