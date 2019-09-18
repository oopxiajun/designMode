using System;
using System.Collections.Generic;
using System.Text;

namespace Factory_工厂模式.Examples_ShapeFactory_图形工厂模式_实例1
{
    class Rectangle_矩形 : Shape_图形接口
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
