using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Prototype_原型模式.Examples_Shape图形_实例1
{
    public class ShapeCache_图形缓存
    {
        private static   Hashtable  shapeMap  = new Hashtable ();

        public static Shape_抽象图形 getShape(String shapeId)
        {
            Shape_抽象图形 cachedShape = (Shape_抽象图形)shapeMap[shapeId];
            return (Shape_抽象图形)cachedShape.Clone();
        }

        // 对每种形状都运行数据库查询，并创建该形状
        // shapeMap.Add(shapeKey, shape);
        // 例如，我们要添加三种形状
        public static void LoadCache()
        {
            Circle__圆形 circle = new Circle__圆形();
            circle. setId("1");
            shapeMap.Add(circle.getId(), circle);

            Square_正方形 square = new Square_正方形();
            square.setId("2");
            shapeMap.Add(square.getId(), square);

            Rectangle_矩形 rectangle = new Rectangle_矩形();
            rectangle.setId("3");
            shapeMap.Add(rectangle.getId(), rectangle);
        }
    }
}
