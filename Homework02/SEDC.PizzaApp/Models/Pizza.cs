﻿namespace SEDC.PizzaApp.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public bool IsOnPromotion { get; set; }

        //NEW
        public bool HasExtras { get; set; }

    }
}
