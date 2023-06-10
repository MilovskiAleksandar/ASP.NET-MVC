using Microsoft.AspNetCore.Mvc;
using SEDC.PizzaApp.Models;

namespace SEDC.PizzaApp.Controllers
{
    public class OrdersController : Controller
    {
        //Add Index action that returns a view with a simple html that says “List of orders”.
        //It should be accessed through custom route http://localhost:[port]/ListOrders
        [Route("ListOrders")]
        //I change it to show List of all Orders in the html :)
        public IActionResult Index()
        {
            List<Orders> orders = StaticDb.Orders;
            return View(orders);
        }
        //Add Details action with optional parameter id. If id is null it should return empty action result
        //, else it should return a view with simple html.
        //It should be accessed through route http://localhost/[Controller Name]/Details/{id?}

        //COMMENT BECAUSE FOR BONUS I NEED TO CHANGE IT TO THE CODE BELOW

        //public IActionResult Details(int? id)
        //{
        //    if(id == null)
        //    {
        //        return new EmptyResult();
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //}
        //Add an action that returns Json (create an example model, class by your choice)
        //it should be accessed by http://localhost/[Controller Name]/JsonData.
        public IActionResult JsonData()
        {
            List<Orders> orders = StaticDb.Orders.ToList();
            return new JsonResult(orders);
        }
        //Add an action that redirects to Action Index in Home Controller.
        public IActionResult RedirectToHome()
        {
            return RedirectToAction("Index", "Home");
        }


        //Create model for Order and static list consisting of several orders.
        //Use it in the Details action (refer to the demo for hint)

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Error", "Orders");
            }

            Orders order = StaticDb.Orders.FirstOrDefault(o => o.Id == id);
            if(order == null)
            {
                return RedirectToAction("Error", "Orders");
            }

            return View(order);
        }


    }
}
