using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Prototype_原型模式.Examples_深度复制_实例1
{
    /// <summary>
    /// 序列化和反序列化辅助类
    /// </summary>
    public class SerializableHelper
    {
        public string Serializable(object target)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                new BinaryFormatter().Serialize(stream, target);

                return Convert.ToBase64String(stream.ToArray());
            }
        }

        public object Derializable(string target)
        {
            byte[] targetArray = Convert.FromBase64String(target);

            using (MemoryStream stream = new MemoryStream(targetArray))
            {
                return new BinaryFormatter().Deserialize(stream);
            }
        }

        public T Derializable<T>(string target)
        {
            return (T)Derializable(target);
        }
    } 
}
