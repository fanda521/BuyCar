using System;
using System.Collections.Generic;
using System.Text;

namespace BuyCar
{
    class ClothesDeal
    {
        public List<Clothes> init()
        {
            List<Clothes> list = new List<Clothes>();
            Clothes c1 = new Clothes(2001,"T恤",35.9,500,30,"米色","S");
            Clothes c2 = new Clothes(2002, "牛仔", 85.9, 1000, 30, "青蓝色", "L");
            Clothes c3 = new Clothes(2003, "衬衫", 45.9, 600, 30, "湛蓝色", "L");
            Clothes c4 = new Clothes(2004, "休闲裤", 65.9,22500, 30, "犀牛黑", "L");
            Clothes c5 = new Clothes(2005, "风衣", 235.9,1500, 30, "条纹色", "S");
            Clothes c6 = new Clothes(2006, "背心", 45.9, 300, 30, "白色", "M");
            Clothes c7 = new Clothes(2007, "运动裤", 67.9, 800, 30, "黄色", "LL");
            Clothes c8 = new Clothes(2008, " polo衫", 55.5, 600, 30, "花色", "L");
            Clothes c9 = new Clothes(2009, "棉T恤", 85.9, 460, 30, "红蓝", "S");
            Clothes c10 = new Clothes(2010, "五分袖", 65.9, 550, 30, "草原绿", "M");

            list.Add(c1);
            list.Add(c2);
            list.Add(c3);
            list.Add(c4);
            list.Add(c5);
            list.Add(c6);
            list.Add(c7);
            list.Add(c8);
            list.Add(c9);
            list.Add(c10);

            return list;
        }
        
        
    }
}
