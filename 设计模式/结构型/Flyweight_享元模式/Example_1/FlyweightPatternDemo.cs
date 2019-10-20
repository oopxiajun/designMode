using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_享元模式.Example_1
{
    public class FlyweightPatternDemo
    {
        private static Random random = new Random();
        private static ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.White };
        public static void test()
        {
            for (int i = 0; i < 20; ++i)
            {
                Circle circle =
                   (Circle)ShapeFactory.getCircle(getRandomColor());
                circle.X = getRandomX();
                circle.Y = getRandomY();
                circle.Radius = getRandomRadius();
                circle.Draw();
            }
        }

        private static ConsoleColor getRandomColor()
        {
            return colors[(int)(random.Next() % colors.Length)];
        }
        private static int getRandomX()
        {
            return (int)(random.Next() * 100);
        }
        private static int getRandomY()
        {
            return (int)(random.Next() * 100);
        }

        private static int getRandomRadius()
        {
            return (int)(random.Next() * 100);
        }
    }
}
