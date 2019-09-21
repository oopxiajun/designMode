using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_原型模式.Examples_Shape图形_实例1
{
    class Circle__圆形 : Shape_抽象图形
    {
        public Circle__圆形()
        {
            this.setType( "Circle__圆形");
        }
        public override void Draw()
        {
            Console.WriteLine("Inside Circle__圆形::Draw() method.");
        }
    }
}
