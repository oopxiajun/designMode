using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_桥接模式.Examples_绘图_实例1
{
    public class RedCircle : IDrawAPI
    {
        public void DrawCircle(int radius, int x, int y)
        {
            Console.ForegroundColor = ConsoleColor.Red;
           Console.WriteLine("Drawing Circle[ color: red, radius: "
       + radius + ", x: " + x + ", " + y + "]");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
