namespace SEDC.PizzaApp.ViewModels
{
    public class OrderDetailsViewModel
    {
        //we want to show: user fullname, pizza name, price(price of pizza + 50 for delivery ), payment method
        public string UserFullName { get; set; }
        public string PizzaName { get; set; }
        public decimal OrderPrice { get; set; }
        public string PaymentMethod { get; set; }
        public string UserAddress { get; set; }
    }
}
