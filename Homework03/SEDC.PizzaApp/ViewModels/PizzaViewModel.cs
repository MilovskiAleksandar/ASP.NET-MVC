using SEDC.PizzaApp.Models.Enums;

namespace SEDC.PizzaApp.ViewModels
{
    public class PizzaViewModel
    {
        public int PizzaId { get; set; }
        public string PizzaName { get; set; }
        public decimal PizzaPrice { get; set; }
        public PizzaSize PizzaSize { get; set; }
        public bool PizzaHasExtras { get; set; }
        //Homework03
        public bool PizzaIsOnPromotion { get; set; }
    }
}
