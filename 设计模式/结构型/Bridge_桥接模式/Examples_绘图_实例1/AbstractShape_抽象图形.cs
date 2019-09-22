using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_桥接模式.Examples_绘图_实例1
{
    public abstract class AbstractShape_抽象图形
    {
        protected IDrawAPI drawAPI;
        protected AbstractShape_抽象图形(IDrawAPI drawAPI)
        {
            this.drawAPI = drawAPI;
        }
        public abstract void Draw();
    }
}
