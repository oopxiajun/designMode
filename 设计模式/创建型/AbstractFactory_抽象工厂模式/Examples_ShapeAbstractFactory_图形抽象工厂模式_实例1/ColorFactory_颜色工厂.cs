using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory_抽象工厂模式.Examples_ShapeAbstractFactory_图形抽象工厂模式_实例1.Color_颜色;
using AbstractFactory_抽象工厂模式.Examples_ShapeAbstractFactory_图形抽象工厂模式_实例1.Shape_图形;

namespace AbstractFactory_抽象工厂模式.Examples_ShapeAbstractFactory_图形抽象工厂模式_实例1
{
    public class ColorFactory_颜色工厂 : AbstractFactory_抽象工厂
    {
        public override Color_颜色接口 GetColor(string color)
        {
            if (color == null)
            {
                return null;
            }
            if (color.ToUpper().Equals("RED") || color.Equals("红") || color.Equals("红色"))
            {
                return new Red_红色();
            }
            else if (color.ToUpper().Equals("GREEN") || color.Equals("绿") || color.Equals("绿色"))
            {
                return new Green_绿色();
            }
            else if (color.ToUpper().Equals("BLUE") || color.Equals("蓝") || color.Equals("蓝色"))
            {
                return new Blue_蓝色();
            }
            return null;
        }

        public override Shape_图形接口 GetShape(string shape)
        {
            return null;
        }
    }
}
