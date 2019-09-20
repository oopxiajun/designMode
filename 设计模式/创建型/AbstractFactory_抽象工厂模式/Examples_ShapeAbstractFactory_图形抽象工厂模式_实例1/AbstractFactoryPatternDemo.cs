using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_抽象工厂模式.Examples_ShapeAbstractFactory_图形抽象工厂模式_实例1
{
    public class AbstractFactoryPatternDemo
    {
        public static void test()
        {
            while (true)
            {
                Console.WriteLine("请输入要生成的类型:");
                string factoryStr = Console.ReadLine();
                //获取形状工厂
                AbstractFactory_抽象工厂 factory = FactotyProducer_工厂生产者.GetFactory(factoryStr);

                if (factory != null)
                {
                    if (factory is ColorFactory_颜色工厂)
                    {
                        Console.WriteLine("请输入要填充的颜色:");
                        string shape = Console.ReadLine();
                        Color_颜色.Color_颜色接口 color = factory.GetColor(shape);
                        if (color != null)
                            color.Fill();
                    }
                    else if (factory is ShapeFactory__图形工厂)
                    {
                        Console.WriteLine("请输入要画的图形名称:");
                        string shapeStr = Console.ReadLine();
                        Shape_图形.Shape_图形接口 shape = factory.GetShape(shapeStr);
                        if (shape != null)
                            shape.Draw();
                    }
                    else
                    {
                        Console.WriteLine("暂不不能生产该类型");
                    }
                }
                else
                {
                    Console.WriteLine("暂不不能生产该类型");
                }
            }

        }
    }
}
