using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_原型模式.Examples_浅度复制_实例1
{
    public class ColorPatternDemo
    {
        public static void test()
        {
            IColor color = new RedColor();
            color.Red = 255;
            Console.WriteLine("color -red " + color.Red); //225
            IColor color1 = color.Clone();//这儿是个新对象
            color1.Red = 224;
            Console.WriteLine("color1-red " + color1.Red);//224
            Console.WriteLine("color -red " + color.Red); //225
        }

        public static void compaerNewObj()
        {
            IColor color = new RedColor();
            color.Red = 255;
            Console.WriteLine("color -red " + color.Red); //225
            IColor color1 = color;//还是原来的对象
            color1.Red = 224;//同时也改变了原来对象的值
            Console.WriteLine("color1-red " + color1.Red);//224
            Console.WriteLine("color -red " + color.Red); //224
        }
    }
}
