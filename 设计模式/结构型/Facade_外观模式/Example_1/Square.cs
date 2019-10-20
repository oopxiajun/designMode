using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_外观模式.Example_1
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("画了一个正方形！");
        }
    }
}
