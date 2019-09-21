using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_原型模式.Examples_Shape图形_实例1
{
    class Rectangle_矩形 : Shape_抽象图形
    {
        public Rectangle_矩形()
        {
            this.setType("Rectangle_矩形");
        }
        public override void Draw()
        {
           Console.WriteLine("Inside Rectangle_矩形::Draw() method.");
        }
    }
}
