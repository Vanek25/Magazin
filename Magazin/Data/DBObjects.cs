using Magazin.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazin.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
           

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        name = "Tesla Model X",
                        shortDesc = "Быстрая машина",
                        longDesc = "Современный минималистический дизайн, подкрепленный автопилотом",
                        img = "/img/tesla.jpg",
                        price = 15000000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        name = "Volkswagen Golf R",
                        shortDesc = "Спортивная мащина",
                        longDesc = "Удобный, городской автомобиль со спортивными нотками",
                        img = "/img/vw.jpg",
                        price = 4000000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Mercedes Vito",
                        shortDesc = "Семейный автомобиль",
                        longDesc = "Большой и комфортабельный автомобиль для всей семьи ",
                        img = "/img/mercedes.jpg",
                        price = 8000000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    }
                );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary <string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                         new Category{ categoryName = "Электромобили", desc = "Современный вид транспорта"},
                         new Category{ categoryName = "Классические автомобили", desc = "Машины с двигателем внутреннего сгорания"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }

                }
                return category;
            }
        }
    }
}
