using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_原型模式.Examples_深度复制_实例1
{
    /// <summary>
    /// 颜色接口
    /// </summary>
    public interface IColor
    {
        /// <summary>
        /// 深度复制【本类所有属性全部被复制，深度复制应用类型的属性的类上面需要序列化标签【Factroy[Serializable],否则否则复制时序列化要报错】】
        /// </summary>
        /// <returns></returns>
        IColor DepthClone();
        /// <summary>
        /// 浅度复制（只复制了本类值类型的属性【Red,Green,Blue】，应用类型的属性没有被复制【f】）
        /// </summary>
        /// <returns></returns>
        IColor ShadeClone();

        int Red { get; set; }
        int Green { get; set; }
        int Blue { get; set; }
        Factroy f { get; set; }
    }
}
