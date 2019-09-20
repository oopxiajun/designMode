using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_工厂模式.Examples_ShapeFactory_图形工厂模式_实例1
{
    public class Circle_圆形 : Shape_图形接口
    {
        public void Draw()
        {
            Console.WriteLine("Inside Circle_圆形::Draw() method.");
        }
    }
}
