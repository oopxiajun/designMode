using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_装饰模式.Example_1
{
   public class DecoratorPatternDemo
    {
        public static void test() {

            Shape circle = new Circle();
            ShapeDecorator_图形装饰抽象类 redCircle = new RedShapeDecorator(circle);
            ShapeDecorator_图形装饰抽象类 shapeDecorator = new RedShapeDecorator(new Rectangle());

            circle.Draw();
            redCircle.Draw();
            shapeDecorator.Draw();
            Console.Read();
        }
    }
}
