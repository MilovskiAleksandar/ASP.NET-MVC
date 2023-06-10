using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp
{
    public static class StaticDb
    {
        public static List<Pizza> Pizzas = new List<Pizza>()
        {
            new Pizza()
            {
                Id = 1,
                Name = "Capri",
                Price = 350,
                IsOnPromotion = true,
            },

            new Pizza()
            {
                Id = 2,
                Name = "Pepperoni",
                Price = 400,
                IsOnPromotion = false,
            },
        };

        public static List<Orders> Orders = new List<Orders>()
        {
            new Orders()
            {
                Id = 1,
                Price = 300,
                IsDelivered = false,
                CustomerName = "Filip",
                OrderDate = new DateTime(2021, 6, 1)
                
            },
            new Orders()
            {
                Id = 2,
                Price = 350,
                IsDelivered = true,
                CustomerName = "Kristijan",
                OrderDate = new DateTime(2022, 8, 10)
            },

            new Orders()
            {
                Id = 3,
                Price = 230,
                IsDelivered = true,
                CustomerName = "Marija",
                OrderDate = new DateTime(2020, 2, 16)
            }

        };
    }
}
