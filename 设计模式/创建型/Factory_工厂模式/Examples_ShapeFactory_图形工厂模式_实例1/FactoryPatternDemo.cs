using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_工厂模式.Examples_ShapeFactory_图形工厂模式_实例1
{
    public class FactoryPatternDemo
    {
        public static void test()
        {
            ShapeFactory_图形工厂 shapeFactory = new ShapeFactory_图形工厂();
            while (true)
            {
                Console.Write("请输入要画的图形名称:");
                string input = Console.ReadLine();
                //获取图形 的对象，并调用它的 draw 方法
                Shape_图形接口 shape1 = shapeFactory.GetShape(input);
                if (shape1 != null)
                {
                    //调用   draw 方法
                    shape1.Draw();
                }
                else
                {
                    Console.WriteLine("通暂不支持绘制“" + input + "”");
                }
            }
        }
    }
}
