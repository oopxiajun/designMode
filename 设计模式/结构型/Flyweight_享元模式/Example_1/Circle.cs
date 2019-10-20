using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_享元模式.Example_1
{
    class Circle : Shape
    {
        private ConsoleColor color;
        public int X;
        public int Y;
        public int Radius;
        public Circle(ConsoleColor color) => (this.color) = (color);

        public void Draw()
        {
            Console.ForegroundColor = this.color;
            Console.WriteLine($"圆心：（{X},{Y}）,半径：{Radius},颜色：{color}");
            Console.ResetColor();
        }
    }
}
