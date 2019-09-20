using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_抽象工厂模式.Examples_ShapeAbstractFactory_图形抽象工厂模式_实例1.Color_颜色
{
    class Blue_蓝色 : Color_颜色接口
    {
        public void Fill()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Inside Blue_蓝色::Fill() method.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
