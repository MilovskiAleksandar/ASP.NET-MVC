using SEDC.PizzaApp.Models;
using SEDC.PizzaApp.Models.Enums;
using SEDC.PizzaApp.ViewModels;

namespace SEDC.PizzaApp.Mappers
{
    public static class PizzaMapper
    {
        //NEW
        public static PizzaViewModel PizzaListToPizzaViewModel(Pizza pizzaDb)
        {
            return new PizzaViewModel
            {
                PizzaName = pizzaDb.Name,
                PizzaId = pizzaDb.Id,
                PizzaPrice = pizzaDb.Price,
                PizzaSize = PizzaSize.Normal,
                PizzaHasExtras = pizzaDb.HasExtras
                
            };
        }

    }
}
