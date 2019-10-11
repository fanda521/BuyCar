using System;

namespace BuyCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.Menu_init();
            menu.MainMenu();
            // Food food = new Food(1,"牛肉干",22.5,600,10,new DateTime(2019,12,20,14,23,02),new DateTime(10000),"斗牛士食品有限公司");

            //Console.WriteLine(food.toString());
            //User user = User.GetUser();
            //user.ShopCar.Add(food);
            //Console.WriteLine(user.toString());
            //user.toStringShopCar();
           // FoodDeal fd = new FoodDeal();
            
        }
    }
}
