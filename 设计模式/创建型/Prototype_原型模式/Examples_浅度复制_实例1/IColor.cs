using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_原型模式.Examples_浅度复制_实例1
{
    /// <summary>
    /// 颜色接口
    /// </summary>
    public interface IColor
    {
        IColor Clone();

        int Red { get; set; }
        int Green { get; set; }
        int Blue { get; set; }

    }
}
