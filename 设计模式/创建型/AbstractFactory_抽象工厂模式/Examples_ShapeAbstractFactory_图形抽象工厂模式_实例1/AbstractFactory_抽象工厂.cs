using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_抽象工厂模式.Examples_ShapeAbstractFactory_图形抽象工厂模式_实例1
{
    public abstract class AbstractFactory_抽象工厂
    {
        public abstract Color_颜色.Color_颜色接口 GetColor(string color);
        public abstract Shape_图形.Shape_图形接口 GetShape(string shape);
    }
}
