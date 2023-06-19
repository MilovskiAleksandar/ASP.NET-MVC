using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Mappers;
using SEDC.PizzaApp.Models;
using SEDC.PizzaApp.ViewModels;

namespace SEDC.PizzaApp.Controllers
{
    public class PizzaController : Controller
    {

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return new EmptyResult();
            }
            Pizza pizza = StaticDb.Pizzas.FirstOrDefault(x => x.Id == id);

            if (pizza == null)
            {
                return new EmptyResult();
            }

            PizzaViewModel pizzaViewModel = PizzaMapper.PizzaListToPizzaViewModel(pizza);

            return View(pizzaViewModel);
        }
        //NEW
        public IActionResult Index()
        {
            List<Pizza> pizzaDb = StaticDb.Pizzas;



            List<PizzaViewModel> pizzaViewModel = pizzaDb.Select(x => PizzaMapper.PizzaListToPizzaViewModel(x)).ToList();
            return View(pizzaViewModel);
        }
    }
}
