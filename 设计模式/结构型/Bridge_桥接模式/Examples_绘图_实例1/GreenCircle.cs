using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_桥接模式.Examples_绘图_实例1
{
    public class GreenCircle : IDrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Drawing Circle[ color: green, radius: "
         + radius + ", x: " + x + ", " + y + "]");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
