using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_抽象工厂模式.Examples_ShapeAbstractFactory_图形抽象工厂模式_实例1.Color_颜色
{
    public class Green_绿色 : Color_颜色接口
    {
        public void Fill()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Inside Green_绿色::Fill() method.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
