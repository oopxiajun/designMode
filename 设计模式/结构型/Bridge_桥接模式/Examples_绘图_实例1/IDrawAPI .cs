using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_桥接模式.Examples_绘图_实例1
{
    public interface IDrawAPI
    {
         void DrawCircle(int radius, int x, int y);
    }
}
