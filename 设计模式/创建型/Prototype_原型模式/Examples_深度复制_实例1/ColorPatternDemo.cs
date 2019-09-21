using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_原型模式.Examples_深度复制_实例1
{
    public class ColorPatternDemo
    {

        public static void test()
        {
            IColor color = new RedColor();
            color.Red = 255;
            color.f = new Factroy() { name = "湖北工厂" };
            Console.WriteLine("color - Factroy:" + color.f.name);  //湖北工厂

            //浅度复制
            IColor color3 = color.ShadeClone();
            color3.Red = 233;
            color3.f.name = "成都工厂";
            Console.WriteLine("color1- Factroy:" + color3.f.name); //成都工厂
            Console.WriteLine("color - Factroy:" + color.f.name);  //成都工厂


            IColor color1 = color.DepthClone();
            color1.Red = 234;
            color1.f.name = "北京工厂";
            Console.WriteLine("color1- Factroy:" + color1.f.name); //北京工厂
            Console.WriteLine("color - Factroy:" + color.f.name);  //成都工厂


            Console.Read();
        }
    }
}
