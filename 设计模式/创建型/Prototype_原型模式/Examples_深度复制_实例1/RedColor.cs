using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype_原型模式.Examples_深度复制_实例1
{
    /// <summary>
    /// 颜色
    /// </summary>
    [Serializable]
    public class RedColor : IColor
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public Factroy f { get; set; }

        public IColor DepthClone()
        { 
            //string target =Newtonsoft.Json.JsonConvert.SerializeObject(this);
            //return Newtonsoft.Json.JsonConvert.DeserializeObject<IColor>(target);

            SerializableHelper s = new SerializableHelper();
            string target = s.Serializable(this);
            return s.Derializable<IColor>(target); 
        }

        public IColor ShadeClone()
        {
            return (IColor)this.MemberwiseClone();
        }
    } 
}
