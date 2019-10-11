using System;
using System.Collections.Generic;
using System.Text;

namespace BuyCar
{
    class Phone:Goods
    {
        //手机颜色
        private string color;
        //手机大小
        private int size;
        //手机像素
        private int pixel;
        //手机品牌
        private string brand;

        public new Phone Clone()
        {
            Phone temp = new Phone();
            Goods goods=base.Clone();

            temp.Id = goods.Id;
            temp.Name = goods.Name;
            temp.Price = goods.Price;
            temp.Weight = goods.Weight;
            temp.Count = goods.Count;

            temp.color = this.color;
            temp.size = this.size;
            temp.pixel = this.pixel;
            temp.brand = this.brand;
            return temp;
        }

        public Phone()
        {

        }
        public  Phone(int id, string name, double price, int weight,int count,
            string color,int size,int pixel,string brand):base (id, name, price, weight, count)
        {
            this.color = color;
            this.size = size;
            this.pixel = pixel;
            this.brand = brand;
        }

        public string Color { get => color; set => color = value; }
        public int Size { get => size; set => size = value; }
        public int Pixel { get => pixel; set => pixel = value; }
        public string Brand { get => brand; set => brand = value; }

        public new string toString()
        {  
            return base.toString() + "  color=" +color +
                "  size=" + size + "  pixel=" + pixel+"  brand="+brand;
        }

        public new string toString2()
        {
            return base.toString2() + "\t\t" + color +
                "\t\t" + size + "\t\t" + pixel + "\t\t" + brand;
        }
    }
}
