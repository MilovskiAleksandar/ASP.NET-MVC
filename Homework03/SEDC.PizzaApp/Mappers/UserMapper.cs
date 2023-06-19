using SEDC.PizzaApp.Models;
using SEDC.PizzaApp.ViewModels;

namespace SEDC.PizzaApp.Mappers
{
    public  static class UserMapper
    {
        //NEW HW3
        public static UserViewModel UserToUserViewModel(User user)
        {
            return new UserViewModel
            {
                UserFullName = $"{user.FirstName} {user.LastName}"
            };
        }
    }
}
