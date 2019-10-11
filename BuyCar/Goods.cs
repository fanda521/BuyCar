using System;
using System.Collections.Generic;
using System.Text;

namespace BuyCar
{
    class Goods
    {
        //物品的id
       private int id;
        //物品的名字
        private string name;
        //物品的价格
        private double price;
        //物品的重量，单位为克
        private int weight;
        //物品的数量，持有量
        private int count;

        public Goods Clone()
        {
            Goods temp = new Goods();
            temp.id = this.id;
            temp.name = this.name;
            temp.price = this.price;
            temp.weight=this.weight;
            return temp;
        }
        public Goods()
        {

        }
        public Goods(int id,string name,double price,int weight,int count)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.weight=weight;
            this.count = count;
        }


        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public int Weight { get => weight; set => weight = value; }
        public int Count { get => count; set => count = value; }

        public string  toString()
        {
            //Console.WriteLine("id="+id+"  name="+name+"  price="+price+"  weight="+weight);
            return "id=" + id + "  name=" + name + "  price=" + price + "  weight=" + weight+"  count="+count;
        }

        public string toString2()
        {
            //Console.WriteLine("id="+id+"  name="+name+"  price="+price+"  weight="+weight);
            return  + id + "\t" + name + "\t\t" + price + "\t\t" + weight + "\t\t" + count;
        }


    }
}
