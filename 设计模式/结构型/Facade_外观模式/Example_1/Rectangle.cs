using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_外观模式.Example_1
{
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("画了一个矩形！");
        }
    }
}
