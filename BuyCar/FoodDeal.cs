using System;
using System.Collections.Generic;
using System.Text;

namespace BuyCar
{
    class FoodDeal
    {
        public List<Food> foodList = null;

        internal List<Food> FoodList { get => foodList; set => foodList = value; }

        public List<Food> Food_init()
        {
            List<Food> list = new List<Food>();
            Food food1 = new Food(1001,"甜甜圈",6.5,300,20, new DateTime(2019, 12, 19, 4, 23, 02), new DateTime(12500),"润滑甜品有限公司");
            Food food2 = new Food(1002, "爽果冻",4.5, 600, 20, new DateTime(2019, 11, 19, 4, 2, 02), new DateTime(14850), "润滑甜品有限公司");
            Food food3 = new Food(1003, "曲曲饼",16.5, 500, 20, new DateTime(2019, 12, 19, 4, 23, 02), new DateTime(1250), "曲志刀有限公司");
            Food food4 = new Food(1004, "麻辣王",1.0, 100, 20, new DateTime(2019, 12, 19, 4, 23, 02), new DateTime(1200), "有限公司");
            Food food5 = new Food(1005, "溜溜梅",7.5,250, 20, new DateTime(2019, 12, 19, 4, 23, 02), new DateTime(25500), "够辣够滋味有限公司");
            Food food7 = new Food(1007, "泡泡糖",2.5, 20, 20, new DateTime(2019, 12, 19, 4, 23, 02), new DateTime(3600), "吃了还想吃有限公司");
            Food food8 = new Food(1008, "芝麻糊",7.5, 650, 20, new DateTime(2019, 12, 19, 4, 23, 02), new DateTime(16500), "凤凰有限公司");
            Food food9 = new Food(1009, "粟米条",3.5, 200, 20, new DateTime(2019, 12, 19, 4, 23, 02), new DateTime(22500), "今麦郎有限公司");
            Food food10 = new Food(1010, "牛肉丝",26.5, 330, 20, new DateTime(2019, 12, 19, 4, 23, 02), new DateTime(16500), "牛气冲天有限公司");

            list.Add(food1);
            list.Add(food2);
            list.Add(food3);
            list.Add(food4);
            list.Add(food5);
            list.Add(food7);
            list.Add(food8);
            list.Add(food9);
            list.Add(food10);
            if(FoodList==null)
            {
                FoodList = list;
            }
            return FoodList;
        }
    }
}
