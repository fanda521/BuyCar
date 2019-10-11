using System;
using System.Collections.Generic;
using System.Text;

namespace BuyCar
{
    class Menu
    {
        //食物初始数据生成对象
       // private FoodDeal fd;
        //服装初始数据生成对象
        // private ClothesDeal cd;
        private Shop foodShop;
        private Shop clothesShop;
        private Shop phoneShop;
        private User user;
        private ProcessBuy process;

        //用户登入
        public bool check_user()
        {
            bool check = false;
            user = User.GetUser();
            Boolean flag = false;
            while (!flag)
            {
                Console.WriteLine("请输入用户名：");
                string name = Console.ReadLine();
                if (!name.Equals(user.Name))
                {
                    Console.WriteLine("用户名不存在，是否重新输入：y or n");
                    string choose = Console.ReadLine();
                    if (choose.Equals("Y") || choose.Equals("y"))
                    {
                        flag = false;
                       continue;
                    }
                    else
                    {
                        flag = true;
                       return check;
                    } 
                }
                flag = true;
            }
            Boolean flag2 = false;
            while (!flag2)
            {
                Console.WriteLine("请输入用户密码：");
                string password = Console.ReadLine();
                if (!password.Equals(user.Password))
                {
                    Console.WriteLine("用户密码错误，是否重新输入：y or n");
                    string choose = Console.ReadLine();
                    if (choose.Equals("Y") || choose.Equals("y"))
                    {
                        flag2 = false;
                        continue;
                    }
                    else
                    {
                        flag2 = true;
                       return check;
                    }
                   
                }
                check = true;
                flag2 = true;
            }
             Console.WriteLine("恭喜您，成功登入，欢迎回来！");
            return check;
        }
        public void Menu_init()
        {
            bool flag=check_user();

            if (!flag)
            {
                Console.WriteLine("登入失败！");
                Environment.Exit(0);
            }
            //食物商店初始化
            FoodDeal fd = new FoodDeal();
            foodShop = new Shop(1,"天虹食品有限公司","阳光大道富贵路2号","13565487920");
            foodShop.ProductList = new List<Goods>();
            foodShop.ProductList.AddRange(fd.Food_init());
            //服装商店初始化
            ClothesDeal cd = new ClothesDeal();
            clothesShop = new Shop(2, "为你出装有限公司", "向阳大道蓝天路8号", "13565444455");
            clothesShop.ProductList = new List<Goods>();
            clothesShop.ProductList.AddRange(cd.init());
            //手机商店初始化
            PhoneDeal pd = new PhoneDeal();
            phoneShop = new Shop(3, "为你而动手机专卖商场", "红星大道默多克路7号", "1666578965");
            phoneShop.ProductList = new List<Goods>();
            phoneShop.ProductList.AddRange(pd.init());
            
            
        }

        public void MainMenu()
        {
            
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("--------Shop--Time--------");
                Console.WriteLine("----1001:进入天猫商场-----");
                Console.WriteLine("----1002:查看用户数据-----");
                Console.WriteLine("----1003:收银台结算-------");
                Console.WriteLine("----1004:充值系统---------");
                Console.WriteLine("----1005:退出系统---------");
                Console.WriteLine("--------Shop--Time--------");
                Console.WriteLine("请输入您要操作的序列号：");
                String choose = Console.ReadLine();
                switch (choose)
                {
                    case "1001":
                        MarkMenu();
                        break;
                    case "1002":
                        UserMenu();
                        break;
                    case "1003":
                        BankMenu();
                        break;
                    case "1004":
                        RechargeMenu();
                        break;
                    case "1005":
                        return;
                    default:
                        Console.WriteLine("输入错误，输入的序号不在候选项中！！！");
                        Console.WriteLine("是否继续输入：Y or N");
                        string str = Console.ReadLine();
                        if (str.Equals("Y") || str.Equals("y"))
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                        break;

                }
            }

        }

       

        private void MarkMenu()
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("--------Shop--Time--------");
                Console.WriteLine("------1001:食品专场-------");
                Console.WriteLine("------1002:服饰专场-------");
                Console.WriteLine("------1003:手机专场-------");
                Console.WriteLine("------1004:返回上一层-----");
                Console.WriteLine("--------Shop--Time--------");
                Console.WriteLine("请输入您要操作的序列号：");
                String choose = Console.ReadLine();
                switch (choose)
                {
                    case "1001":
                        FoodMenu();
                        break;
                    case "1002":
                        ClothesMenu();
                        break;
                    case "1003":
                        PhoneMenu();
                        break;
                    case "1004":

                        return;
                    default:
                        Console.WriteLine("输入错误，输入的序号不在候选项中！！！");
                        Console.WriteLine("是否继续输入：Y or N");
                        string str = Console.ReadLine();
                        if (str.Equals("Y") || str.Equals("y"))
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                        break;
                }
            }
        }
        //食物列表展示菜单
        private void FoodMenu()
        {
            foodShop.toStringProductList2();
            process = new ProcessBuy(user,foodShop.ProductList);
            process.buy();
        }
        //服装列表展示菜单
        private void ClothesMenu()
        {
            clothesShop.toStringProductList2();
            process = new ProcessBuy(user,clothesShop.ProductList);
            process.buy();
        }
        //手机列表展示菜单
        private void PhoneMenu()
        {
            phoneShop.toStringProductList2();
            process = new ProcessBuy(user,phoneShop.ProductList);
            process.buy();
        }
        private void RechargeMenu()
        {
            bool flag = false;
            while(!flag)
            {
            Console.WriteLine("请输入需要充值的金额：");
            string str = Console.ReadLine();
            int temp = int.Parse(str);
            if(temp<0)
                {
                    Console.Write("金额数不能小于0！ 是否重新输入： y or n");
                    string choose = Console.ReadLine();
                    if (!(choose.Equals("Y") || choose.Equals("y")))
                    {
                        Console.WriteLine("充值失败！");
                        return;
                    }
                    continue;
                }
            else
                {
                    user.Money = user.Money + temp;
                    Console.WriteLine("充值成功，目前金额为："+user.Money);
                    return;
                }
            }
            
        }

        private void BankMenu()
        {
            user.toStringShopCar();
            List<List<Goods>> goods = new List<List<Goods>>();
            goods.Add(foodShop.ProductList);
            goods.Add(clothesShop.ProductList);
            goods.Add(phoneShop.ProductList);
            process = new ProcessBuy();
            process.Goods = goods;
            process.userAccount();

        }

        private void UserMenu()
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("--------Shop--Time--------");
                Console.WriteLine("------1001:用户基本信息-------");
                Console.WriteLine("------1002:已购商品-------");
                Console.WriteLine("------1003:购物车信息-------");
                Console.WriteLine("------1004:返回上一层-----");
                Console.WriteLine("--------Shop--Time--------");
                Console.WriteLine("请输入您要操作的序列号：");
                String choose = Console.ReadLine();
                switch (choose)
                {
                    case "1001":
                        User_Base_Menu();
                        break;
                    case "1002":
                       User_Hold_Menu();
                        break;
                    case "1003":
                        User_ShopCar_Menu();
                        break;
                    case "1004":

                        return;
                    default:
                        Console.WriteLine("输入错误，输入的序号不在候选项中！！！");
                        Console.WriteLine("是否继续输入：Y or N");
                        string str = Console.ReadLine();
                        if (str.Equals("Y") || str.Equals("y"))
                        {
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }
                        break;
                }
            }
        }

        private void User_ShopCar_Menu()
        {
            user.toStringShopCar();
        }

        private void User_Hold_Menu()
        {
            user.toStringHold();
            
        }

        private void User_Base_Menu()
        {
            Console.WriteLine("用户ID\t用户名\t年龄\t性别\t金额\t密码");
            Console.WriteLine(user.toString2());
        }
    }
   
}
