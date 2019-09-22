using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_桥接模式.Examples_绘图_实例1
{
    public class BridgePatternDemo
    {
        public static void test( )
        {
            AbstractShape_抽象图形 redCircle = new Circle(100, 100, 10, new RedCircle());
            AbstractShape_抽象图形 greenCircle = new Circle(100, 100, 10, new GreenCircle());

            redCircle.Draw();
            greenCircle.Draw();
        }
    }
}
