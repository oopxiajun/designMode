using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_装饰模式.Example_1
{
    public class Circle : Shape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
}
