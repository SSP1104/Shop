using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shop.Data;

namespace ShopControllerTests
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
           
                
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Cars.Any())
            {
                content.AddRange(
                    new Cars
                    {
                        name = "Tesla",
                        shortDesc = "Быстрый",
                        longDesc = "Быстрый автомобиль",
                        img = "/img/tesla.jpg",
                        price = 45000,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Cars
                    {
                        name = "Ford",
                        shortDesc = "Тихий",
                        longDesc = "Тихий автомобиль",
                        img = "/img/ford.jpg",
                        price = 11000,
                        isFavourite = false,
                        available = true,
                        Category = Categories["Классические автомобили"]
                    }
                    );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                         new Category { categoryName = "Электромобили", desc = "Современный вид транспорта" },
                        new Category { categoryName = "Классические автомобили", desc = "Машины с ДВС" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}
