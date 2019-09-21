using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_原型模式.Examples_Shape图形_实例1
{
    class Square_正方形 : Shape_抽象图形
    {
        public Square_正方形()
        {
            this.setType("Square_正方形");
        }
        public override void Draw()
        {
            Console.WriteLine("Inside Square_正方形::Draw() method.");
        }
    }
}
