using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_抽象工厂模式.Examples_ShapeAbstractFactory_图形抽象工厂模式_实例1.Shape_图形
{
    public class Circle_圆形 : Shape_图形接口
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle_圆形::Draw() method.");
        }
    }
}
