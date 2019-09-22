using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_桥接模式.Examples_绘图_实例1
{
    public class Circle : AbstractShape_抽象图形
    {
        private int x, y, radius;

        public Circle(int x, int y, int radius, IDrawAPI drawAPI):base(drawAPI)
        { 
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void Draw()
        {
            drawAPI.DrawCircle(radius, x, y);
        }
    }
}
