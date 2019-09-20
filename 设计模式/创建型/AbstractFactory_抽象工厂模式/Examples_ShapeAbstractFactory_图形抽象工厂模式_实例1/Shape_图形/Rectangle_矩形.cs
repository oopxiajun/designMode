using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_抽象工厂模式.Examples_ShapeAbstractFactory_图形抽象工厂模式_实例1.Shape_图形
{
    public class Rectangle_矩形 : Shape_图形接口
    {
        /// <summary>
        /// 画矩形
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle_矩形::Draw() method.");
        }
    }
}
