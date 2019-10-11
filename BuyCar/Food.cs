using System;
using System.Collections.Generic;
using System.Text;

namespace BuyCar
{
    class Food:Goods
    {
        private DateTime produceTime;
        private DateTime keepTime;
        private string productor;

        public new  Food Clone()
          {
            
            Goods goods=base.Clone();
            Food temp = new Food();
            temp.Id = goods.Id;
            temp.Name = goods.Name;
            temp.Price = goods.Price;
            temp.Weight = goods.Weight;
            temp.Count = goods.Count;
            temp.produceTime = this.produceTime;
            temp.keepTime = this.keepTime;
            temp.productor = this.productor;
            return temp;
        }  
        
        public Food()
        {

        }
        public Food(int id, string name, double price, int weight,int count,
            DateTime produceTime, DateTime keepTime,string productor):base(id, name, price, weight, count)
        {
            this.produceTime = produceTime;
            this.keepTime = keepTime;
            this.productor = productor;
           
        }

        public DateTime ProduceTime { get => produceTime; set => produceTime = value; }
        public DateTime KeepTime { get => keepTime; set => keepTime = value; }
        public string Productor { get => productor; set => productor = value; }

        public new string  toString()
        {
            //Console.WriteLine(base.toString() + "  productTime=" + produceTime +
            //    "  keepTime=" + keepTime + "  productor=" + productor);
            return base.toString() + "  productTime=" + produceTime +
                "  keepTime=" + keepTime + "  productor=" + productor;
        }

        public new string toString2()
        {
            return base.toString2() + "\t\t" + produceTime +
                "\t" + keepTime + "\t" + productor;
        }
    }
}
