using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_原型模式.Examples_Shape图形_实例1
{
    /// <summary>
    /// Shape_抽象图形
    /// </summary>
    public abstract class Shape_抽象图形 : ICloneable
    {
        private String id;
        private String type;


        public void setType(string type)
        {
            this.type = type;
        }
        public String getType()
        {
            return type;
        }

        public String getId()
        {
            return id;
        }

        public void setId(String id)
        {
            this.id = id;
        }


        public abstract void Draw();
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
