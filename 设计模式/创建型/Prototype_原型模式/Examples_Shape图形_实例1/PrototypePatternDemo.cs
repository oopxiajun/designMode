using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_原型模式.Examples_Shape图形_实例1
{
    public class PrototypePatternDemo
    {
        public static void test()
        {
            ShapeCache_图形缓存.LoadCache();

            Shape_抽象图形 clonedShape = (Shape_抽象图形)ShapeCache_图形缓存.getShape("1");
            Console.WriteLine("Shape : " + clonedShape.getType());
            clonedShape.Draw();

            Shape_抽象图形 clonedShape2 = (Shape_抽象图形)ShapeCache_图形缓存.getShape("2");
            Console.WriteLine("Shape : " + clonedShape2.getType());
            clonedShape2.Draw();

            Shape_抽象图形 clonedShape3 = (Shape_抽象图形)ShapeCache_图形缓存.getShape("3");
            Console.WriteLine("Shape : " + clonedShape3.getType());
            clonedShape3.Draw();
        }
    }
}
