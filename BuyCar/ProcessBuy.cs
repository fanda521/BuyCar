using System;
using System.Collections.Generic;
using System.Text;

namespace BuyCar
{
    class ProcessBuy
    {
        private User user;
        private List<Goods> list;
        private List<List<Goods>> goods;
        public ProcessBuy()
        {

        }

        public ProcessBuy(User user ,List<Goods> list)
        {
            this.user = user;
            this.list = list;
        }

        public ProcessBuy(User user, List<Goods> list, List<List<Goods>> goods)
        {
            this.user = user;
            this.list = list;
            this.goods = goods;
        }

        public void buy()
        {
            bool flag_Id = false;
            //用户输入的产品ID
            string chooseId="";
            //用户输入的购买产品的数量
            string count="";
            //物品所在list中的下标
            int index = -1;
            while (!flag_Id)
            {
             Console.WriteLine("请输入你要购买的物品的ID号：");
             chooseId=Console.ReadLine();
             flag_Id= flag_isId(chooseId);
                if (flag_Id == false)
                {
                    Console.WriteLine("你输入的物品ID号不存在，是否重新输入：y or n？");
                    string str = Console.ReadLine();
                    if (!(str.Equals("Y") || str.Equals("y")))
                    {
                        Console.WriteLine("退出本次购买！");
                        return;
                    }
                }
            }
            bool flag_count = false;
            while (!flag_count)
            {
                //校验用户输入的格式是否正确
                Console.WriteLine("请输入你要购买的数量：");
                 count= Console.ReadLine();
                flag_count = checkInput(count);
                if(flag_count==false)
                {
                    Console.WriteLine("你输入的数量格式出错，是否重新输入：y or n ？");
                    string choose = Console.ReadLine();
                    if (!(choose.Equals("Y") || choose.Equals("y")))
                    {
                        Console.WriteLine("退出本次购买！");
                        return;
                    }
                    continue;
                }
                //判断购买数量够不够
                index = check_Num(chooseId,int.Parse(count));
                if(index<0)
                {
                    Console.WriteLine("物品购买数量超过库存量，是否重新输如购买量：y or n ？（温馨提醒所选物品库存仅剩{0}件）",list[index].Count);
                    string choose = Console.ReadLine();
                    if (!(choose.Equals("Y") || choose.Equals("y")))
                    {
                        Console.WriteLine("退出本次购买！");
                        return;
                    }
                    continue;
                }
            }
            //选中的物品直接购买还是放入购物车
            bool flag_Input = false;
            while(!flag_Input)
            {
                Console.WriteLine("所选物品直接购买还是放入购物车：1.直接购买  2.放入购物车 ？");
                string choose2 = Console.ReadLine();
                if (choose2.Equals("1"))
                {
                    bool flag_buy=directBuy(index,int.Parse(count));
                    if (flag_buy)
                    {
                     Console.WriteLine("购买成功！");
                     user.toStringHold();  
                    } 
                    return;
                }
                else if (choose2.Equals("2"))
                {
                    addShopCar(index,int.Parse(count));
                    Console.WriteLine("加入购物车成功！");
                    user.toStringShopCar();
                    return;
                }
                else
                {
                    Console.WriteLine("输入错误，是否重新输入： y or n ？");
                    string choose = Console.ReadLine();
                    if (!(choose.Equals("Y") || choose.Equals("y")))
                    {
                        Console.WriteLine("退出本次购买！");
                        return;
                    }
                }
            }
           






        }
        //判断输入的物品ID 
        public bool flag_isId(string choose)
        {
            bool flag_isid = false;
            for (var i=0;i<list.Count;i++)
            {
                if (choose.Equals(list[i].Id+""))
                {
                    flag_isid = true;
                    break;
                }
            }
            return flag_isid;
        }
        /**
	 * 提示用户输入数字，并且进行合法性校验
	 */
        public bool checkInput(string str)
        {
            //Console.WriteLine("请输入一位2~9的正整数：");
            //string str = Console.ReadLine();
            /**
             * 对用户输入的数字进行合法性校验
             */

            //1.数字是否包含非数字字符
            for (int i = 0; i < str.Length; i++)
            {
                char []c = str.ToCharArray();
                if (c[i] < 48 || c[i] > 57)
                {
                    Console.WriteLine("输入的数字包含非数字字符！");
                    return false;
                }
            }
            long inNumber;
            try {
                inNumber= long.Parse(str);
            }
            catch {
                Console.WriteLine("转成long类型的值失败！");
                return false;
            }

            //2.数字是否为正整数
            if (inNumber < 0)
            {
               Console.WriteLine("输入的数字为负数！");
                return false;
            }
            //3.数字长度是否在1~5之间
            int strLength = str.Length;
            if (strLength > 4)
            {
                Console.WriteLine("输入的数字长度大于9！");
                return false;
            }
            if (strLength < 1)
            {
                Console.WriteLine("输入的数字长度小于2！");
                return false;
            }

            return true;


        }

        //判断所选ID的物品是否够数，并返回物品所在list中的下标
        public int  check_Num(string id,int count)
        {
            int index=-1;
            for (var i=0;i<list.Count;i++)
            {
                if(list[i].Id==int.Parse(id)&&list[i].Count>=count)
                {
                    return index = i;
                }
            }
            return index;
        }
       
       /// <summary>
       /// 直接购买操作
       /// </summary>
       /// <param name="index">物品在list中的下标</param>
       /// <param name="count">购买的数量</param>
        public  bool directBuy(int index,int count)
        {
           double pay= list[index].Price * count; 
            //判断金额是否足够
            if(pay<=user.Money)
            {
                user.Money = user.Money - pay;
                list[index].Count=list[index].Count - count;
                if (list[index].GetType() == typeof(Food))
                {
                    Food food = ((Food)list[index]).Clone();
                    food.Count = count;
                    user.Hold.Add(food);
                }
                else if (list[index].GetType() == typeof(Clothes))
                {
                    Clothes food = ((Clothes)list[index]).Clone();
                    food.Count = count;
                    user.Hold.Add(food);
                }
                else if (list[index].GetType() == typeof(Phone))
                {
                    Phone food = ((Phone)list[index]).Clone();
                    food.Count = count;
                    user.Hold.Add(food);
                }
                else {
                    Console.WriteLine("没有您选中的物品类型！");
                    return false;
                }
                return true;
            }
            else
            {
                Console.WriteLine("金额不足，购买失败！");
                return false;
            }
        }
        //加入购物车
        public void addShopCar(int index, int count)
        {
            if (list[index].GetType() == typeof(Food))
            {
                Food food = ((Food)list[index]).Clone();
                food.Count = count;
                user.ShopCar.Add(food);
            }
            else if (list[index].GetType() == typeof(Clothes))
            {
                Clothes food = ((Clothes)list[index]).Clone();
                food.Count = count;
                user.ShopCar.Add(food);
            }
            else if (list[index].GetType() == typeof(Phone))
            {
                Phone food = ((Phone)list[index]).Clone();
                food.Count = count;
                user.ShopCar.Add(food);
            }
            else
            {
                Console.WriteLine("没有您选中的物品类型！");
            }
        }
        /**
         * 收银台结算操作 
         */
         public void userAccount()
        {
            bool flag = false;
            while(!flag)
            {
            Console.WriteLine("1.选择性结算  2.一键清空  ");
            string str=Console.ReadLine();
                switch (str)
                {
                    case "1":
                        selectAccount();
                        break;
                    case "2":
                        allAccount();
                        break;
                    default:
                        Console.WriteLine("输入错误，输入的序号不在候选项中！！！");
                        Console.WriteLine("是否继续输入：Y or N");
                        string choose = Console.ReadLine();
                        if (!(choose.Equals("Y") || choose.Equals("y")))
                        {
                            flag = true;
                        }
                        break;
                }
                flag = true;
            }
            

        }

        //一键支付
        private bool allAccount()
        {
            double pay=0;
            if (user==null)
            {
                return false;
            }
            for(var i=0;i<user.ShopCar.Count;i++)
            {
                pay = pay + user.ShopCar[i].Price * user.ShopCar[i].Count;
            }
            Console.WriteLine("清空购物车将花费您 "+pay+" 人民币,是否继续支付：y or n ?");
            string choose = Console.ReadLine();
            if (!(choose.Equals("Y") || choose.Equals("y")))
            {
                Console.WriteLine("支付失败！");
                return false;
            }
            else
            {
                if (user.Money>=pay&&clearAllAccount())
                {
                    user.Money = user.Money - pay;
                    user.Hold.AddRange(user.ShopCar);

                    user.ShopCar.Clear();
                    Console.WriteLine("支付成功！");
                    return true;
                } 
            }
            return false;
            

        }
        public bool clearAllAccount()
        {
            List<Goods> temp = new List<Goods>();
            for (var i = 0; i < goods.Count; i++)
            {
                temp.AddRange(goods[i]);
            }
            for (var m = 0; m < user.ShopCar.Count; m++)
            {
                bool flag = false;
                for (var i = 0; i < temp.Count; i++)
                {
                    if (user.ShopCar[m].Id.Equals(temp[i].Id))
                    {
                        Console.WriteLine("购买的物品ID是：" + temp[i].Id);
                        flag = true;
                        if (user.ShopCar[m].Count > temp[i].Count)
                        {
                            Console.WriteLine("物品:" + temp[i].Name + "的库存数量是：" + temp[i].Count + "少于购买的数量：" + user.ShopCar[m].Count + "!");
                            return false;
                        }
                        else
                        {
                            temp[i].Count -= user.ShopCar[m].Count;
                           break;
                        }
                        
                    }


                }
                if(!flag)
                {
                    Console.WriteLine("购买的物品ID是：" + user.ShopCar[m].Id+"的无货哦！");
                    return false;
                }
                
                
            }
            return true;
        }
        private void selectAccount()
        {
            
            
        }

        internal User Use { get => user; set => user = value; }
        internal List<Goods> List { get => list; set => list = value; }
        internal List<List<Goods>> Goods { get => goods; set => goods = value; }
    }
}
