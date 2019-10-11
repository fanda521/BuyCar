using System;
using System.Collections.Generic;
using System.Text;

namespace BuyCar
{
    class User
    {
        private int id;
        private string name;
        private int age;
        private string sex;
        private double money;
        private string password;
        private static List<Goods> shopCar;
        private static List<Goods> hold;
        private static  User userSingle;
        private User(){
            
            }
        private User(int id, string name, int age, 
            string sex, double money,string password,List<Goods> shopCar1,List<Goods> hold1)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.money = money;
            this.password = password;
            shopCar = shopCar1;
            hold = hold1;
        }

        public static User GetUser()
        {
            if (userSingle == null)
            {
                shopCar = new List<Goods>();
                hold = new List<Goods>();
                userSingle = new User(1,"陈凡",22,"男",2000.00,"123456",shopCar,hold);
            }
            return userSingle;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Sex { get => sex; set => sex = value; }
        public double Money { get => money; set => money = value; }
        internal List<Goods> ShopCar { get => shopCar; set => shopCar = value; }
        internal User UserSingle { get => userSingle; set => userSingle = value; }
        public string Password { get => password; set => password = value; }
        internal List<Goods> Hold { get => hold; set => hold = value; }

        public string toString()
        {
            //Console.WriteLine("id="+id+"  name="+name+"  age="+age+"  sex="+sex+"  money="+money );
           

            return "id=" + id + "  name=" + name + "  age=" + age + "  sex=" + sex + "  money=" + money+"  password="+password;
        }

        public string toString2()
        {
            return "" + id + "\t" + name + "\t" + age + "\t" + sex + "\t" + money + "\t" + password;
        }
        public void toStringHold()
        {
            Console.WriteLine("--------------------------------------------------用户已购商品信息-------------------------------------------------");
            for (int i = 0; i < hold.Count; i++)
            {
                if (hold[i].GetType() == typeof(Food))
                {
                    Console.WriteLine("食物ID\t食物名称\t食物价格\t食物重量\t食物数量\t食物生产日期\t\t食物保质期\t\t食物生产商");
                    Console.WriteLine(((Food)hold[i]).toString2());
                }
                else if (hold[i].GetType() == typeof(Clothes))
                {
                    Console.WriteLine("服装ID\t服装名称\t服装价格\t服装重量\t服装数量\t服装的颜色\t服装的尺码");
                    Console.WriteLine(((Clothes)hold[i]).toString2());
                }
                else if (hold[i].GetType() == typeof(Phone))
                {
                    Console.WriteLine("手机ID\t手机名称\t手机价格\t手机重量\t手机数量\t手机颜色\t手机大小\t手机像素\t手机品牌");
                    Console.WriteLine(((Phone)hold[i]).toString2());
                }
                else
                {
                    Console.Write("err !");
                    Console.WriteLine(hold[i].toString2());
                }

            }
        }

        public void toStringShopCar()
        {
            Console.WriteLine("-------------------------------------------------用户购物车信息-------------------------------------------------");
            for (int i = 0; i < shopCar.Count; i++)
            {
                if (shopCar[i].GetType() == typeof(Food))
                {
                    Console.WriteLine("食物ID\t食物名称\t食物价格\t食物重量\t食物数量\t食物生产日期\t\t食物保质期\t\t食物生产商");
                    Console.WriteLine(((Food)shopCar[i]).toString2());
                }
                else if (shopCar[i].GetType() == typeof(Clothes))
                {
                    Console.WriteLine("服装ID\t服装名称\t服装价格\t服装重量\t服装数量\t服装的颜色\t服装的尺码");
                    Console.WriteLine(((Clothes)shopCar[i]).toString2());
                }
                else if (shopCar[i].GetType() == typeof(Phone))
                {
                    Console.WriteLine("手机ID\t手机名称\t手机价格\t手机重量\t手机数量\t手机颜色\t手机大小\t手机像素\t手机品牌");
                    Console.WriteLine(((Phone)shopCar[i]).toString2());
                }
                else
                {
                    Console.Write("err !");
                }

            }
        }

    }
}
