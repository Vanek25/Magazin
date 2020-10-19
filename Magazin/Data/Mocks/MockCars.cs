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
                        img = "https://blog-johnchow.netdna-ssl.com/wp-content/uploads/2016/05/26828419540_f1587ebb7a_o.jpg",
                        price = 50000, 
                        isFavourite = true,
                        available = true, 
                        Category = _categoryCars.AllCategories.First()
                    },
                    new Car {
                        name = "Volkswagen Golf R",
                        shortDesc = "Спортивная мащина",
                        longDesc = "Удобный, городской автомобиль со спортивными нотками",
                        img = "https://a.d-cd.net/b158e55s-1920.jpg",
                        price = 30000,
                        isFavourite = true,
                        available = true,
                        Category = _categoryCars.AllCategories.Last()
                    },
                    new Car {
                        name = "Mercedes Vito",
                        shortDesc = "Семейный автомобиль",
                        longDesc = "Большой и комфортабельный автомобиль для всей семьи ",
                        img = "https://s.auto.drom.ru/i24200/pubs/4/45717/2183198.jpg",
                        price = 45000,
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
