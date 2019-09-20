using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory_抽象工厂模式.Examples_ShapeAbstractFactory_图形抽象工厂模式_实例1.Color_颜色;
using AbstractFactory_抽象工厂模式.Examples_ShapeAbstractFactory_图形抽象工厂模式_实例1.Shape_图形;

namespace AbstractFactory_抽象工厂模式.Examples_ShapeAbstractFactory_图形抽象工厂模式_实例1
{
    public class ShapeFactory__图形工厂 : AbstractFactory_抽象工厂
    {
        public override Color_颜色接口 GetColor(string color)
        {
            return null;
        }

        public override Shape_图形接口 GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.Equals("圆形"))
            {
                return new Circle_圆形();
            }
            else if (shapeType.Equals("矩形"))
            {
                return new Rectangle_矩形();
            }
            else if (shapeType.Equals("正方形"))
            {
                return new Square_正方形();
            }
            return null;
        }
    }
}
