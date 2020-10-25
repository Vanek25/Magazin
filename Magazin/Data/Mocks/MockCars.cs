using Magazin.Data.Interfaces;
using Magazin.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazin.Data.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars {
            get
            {
                return new List<Car> {
                    new Car { 
                        name = "Tesla Model X", 
                        shortDesc = "Быстрая машина", 
                        longDesc="Современный минималистический дизайн, подкрепленный автопилотом", 
                        img = "/img/tesla.jpg",
                        price = 15000000, 
                        isFavourite = true,
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Volkswagen Golf R",
                        shortDesc = "Спортивная мащина",
                        longDesc = "Удобный, городской автомобиль со спортивными нотками",
                        img = "/img/vw.jpg",
                        price = 4000000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Mercedes Vito",
                        shortDesc = "Семейный автомобиль",
                        longDesc = "Большой и комфортабельный автомобиль для всей семьи ",
                        img = "/img/mercedes.jpg",
                        price = 8000000,
                        isFavourite = false,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },


                };
            }
        }
        public IEnumerable<Car> getFavCars { get ; set ; }
       

        public Car getObjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
