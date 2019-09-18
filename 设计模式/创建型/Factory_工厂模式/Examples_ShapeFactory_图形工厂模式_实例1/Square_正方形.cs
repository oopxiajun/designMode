using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_工厂模式.Examples_ShapeFactory_图形工厂模式_实例1
{
    class Square_正方形 : Shape_图形接口
    {
        public void Draw()
        {
            Console.WriteLine("Inside Square_正方形::Draw() method.");
        }
    }
}
