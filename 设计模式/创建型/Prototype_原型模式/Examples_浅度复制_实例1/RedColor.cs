using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_原型模式.Examples_浅度复制_实例1
{
    public class RedColor : IColor
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }


        public IColor Clone()
        {
            return (IColor)this.MemberwiseClone();
        }
    }
}
