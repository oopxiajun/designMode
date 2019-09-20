using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_工厂模式.Examples_ShapeFactory_图形工厂模式_实例1
{
    public class ShapeFactory_图形工厂
    {
        public Shape_图形接口 GetShape(string shapeType) {
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
