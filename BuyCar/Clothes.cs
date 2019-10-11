using System;
using System.Collections.Generic;
using System.Text;

namespace BuyCar
{
    class Clothes:Goods
    {
        private string color;
        private string size;

        public new  Clothes Clone()
        {
            Clothes temp = new Clothes();
            Goods goods=base.Clone();

            temp.Id = goods.Id;
            temp.Name = goods.Name;
            temp.Price = goods.Price;
            temp.Weight = goods.Weight;
            temp.Count = goods.Count;

            temp.color = this.color;
            temp.size = this.size;
            return temp;
        }

        public Clothes()
        {

        }
        public Clothes(int id, string name, double price, int weight,int count,
            string color,string size): base(id, name, price, weight,count)
        {
            this.Color = color;
            this.Size = size;
        }

        public string Color { get => color; set => color = value; }
        public string Size { get => size; set => size = value; }

        public string toString()
        {
            return base.toString() + "  color=" + color + "  size=" + size;
        }
        public string toString2()
        {
            return base.toString2() + "\t\t" + color + "\t\t" + size;
        }
    }
}
