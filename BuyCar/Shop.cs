using System;
using System.Collections.Generic;
using System.Text;

namespace BuyCar
{
    class Shop
    {
        //店家的id
        private int id;
        //店家的名字
        private string name;
        //店家的地址
        private string address;
        //店家的联系方式
        private string phoneNumber;
        //店家的产品
        private List<Goods> productList;

        public Shop()
        {

        }
        public Shop(int id,string name,string address,string phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        internal List<Goods> ProductList { get => productList; set => productList = value; }

        public string toString()
        {
            return "id=" + id + "  name=" + name + "  address=" + address + "  " +
                "phoneNumber=" + phoneNumber;
        }

        public void toStringProductList()
        {
            
            for (int i = 0; i < productList.Count; i++)
            {
                if (productList[i].GetType() == typeof(Food))
                {
                    Console.WriteLine("食物ID\t食物名称\t食物价格\t食物重量\t食物数量\t食物生产日期\t\t食物保质期\t\t食物生产商");
                    Console.WriteLine(((Food)productList[i]).toString2());
                }
                else if (productList[i].GetType() == typeof(Clothes))
                {
                    Console.WriteLine("服装ID\t服装名称\t服装价格\t服装重量\t服装数量\t服装的颜色\t服装的尺码");
                    Console.WriteLine(((Clothes)productList[i]).toString2());
                }
                else if (productList[i].GetType() == typeof(Phone))
                {
                    Console.WriteLine("手机ID\t手机名称\t手机价格\t手机重量\t手机数量\t手机颜色\t手机大小\t手机像素\t手机品牌");
                    Console.WriteLine(((Phone)productList[i]).toString2());
                }
                else
                {
                    Console.Write("err !");
                }

            }
        }


        public void toStringProductList2()
        {
            if (productList[0].GetType()==typeof(Food))
            {
                Console.WriteLine("食物ID\t食物名称\t食物价格\t食物重量\t食物数量\t食物生产日期\t\t食物保质期\t\t食物生产商");
                for (int i=0;i<productList.Count;i++)
                {
                    Console.WriteLine(((Food)productList[i]).toString2());
                }
            }
            if (productList[0].GetType() == typeof(Clothes))
            {
                Console.WriteLine("服装ID\t服装名称\t服装价格\t服装重量\t服装数量\t服装的颜色\t服装的尺码");
                for (int i = 0; i < productList.Count; i++)
                {
                    Console.WriteLine(((Clothes)productList[i]).toString2());
                }
            }
            if (productList[0].GetType() == typeof(Phone))
            {
                Console.WriteLine("手机ID\t手机名称\t手机价格\t手机重量\t手机数量\t手机颜色\t手机大小\t手机像素\t手机品牌");
                for (int i = 0; i < productList.Count; i++)
                {
                    Console.WriteLine(((Phone)productList[i]).toString2());
                }
            }


        }

    }
}
