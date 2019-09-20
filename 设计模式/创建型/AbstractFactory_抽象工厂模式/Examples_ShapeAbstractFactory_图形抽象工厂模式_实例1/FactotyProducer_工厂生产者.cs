using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_抽象工厂模式.Examples_ShapeAbstractFactory_图形抽象工厂模式_实例1
{
    public class FactotyProducer_工厂生产者
    {
        public static AbstractFactory_抽象工厂 GetFactory(String choice)
        {
            if (choice.Equals("图形"))
            {
                return new ShapeFactory__图形工厂();
            }
            else if (choice.Equals("颜色"))
            {
                return new ColorFactory_颜色工厂();
            }
            return null;
        }
    }
}
