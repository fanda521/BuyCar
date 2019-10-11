using System;
using System.Collections.Generic;
using System.Text;

namespace BuyCar
{
    class PhoneDeal
    {

        public List<Phone> init()
        {
            List<Phone> list = new List<Phone>();
            Phone p1 = new Phone(3001, "小米X", 1999.9, 500, 40, "玫瑰金", 8, 2000, "小米");
            Phone p2 = new Phone(3002, "魅族蓝", 1577.9, 450, 40, "黑金", 8, 2000, "魅族");
            Phone p3 = new Phone(3003, "华为I", 2999.9, 500, 40, "银白", 8, 2000, "华为");
            Phone p4 = new Phone(3004, "华为G", 1999.9, 500, 40, "玫瑰红", 8, 2000, "华为");
            Phone p5 = new Phone(3005, "索尼", 1999.9, 500, 40, "黑色", 8, 2000, "索尼");
            Phone p6 = new Phone(3006, "小米H", 1999.9, 500, 40, "天蓝", 8, 2000, "小米");
            Phone p7 = new Phone(3007, "三星", 1999.9, 500, 40, "湛蓝", 8, 2000, "三星");
            Phone p8 = new Phone(3008, "锤子", 1999.9, 500, 40, "橘黄", 8, 2000, "锤子");
            Phone p9 = new Phone(3009, "VIVO", 1999.9, 500, 40, "苍银", 8, 2000, "VIVO");
            Phone p10 = new Phone(3010, "OPPO", 1999.9, 500, 40, "赤红", 8, 2000, "OPPO");

            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            list.Add(p5);
            list.Add(p6);
            list.Add(p7);
            list.Add(p8);
            list.Add(p9);
            list.Add(p10);
            
            return list;


        }
    }
}
