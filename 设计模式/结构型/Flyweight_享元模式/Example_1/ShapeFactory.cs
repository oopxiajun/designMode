using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_享元模式.Example_1
{
    public class ShapeFactory
    {
        private static Dictionary<ConsoleColor, Shape> circleMap = new Dictionary<ConsoleColor, Shape>();

        public static Shape getCircle(ConsoleColor color)
        {
            if (!circleMap.ContainsKey(color))
            {
                Circle circle = new Circle( color);
                circleMap.Add(color, circle);
                Console.WriteLine($"创建了一个{color}色的圆!");
                return circle;
            }
            else
            {
                return circleMap[color];
            }

        }
    }
}
