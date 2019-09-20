using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_建造者模式.Examples_SnackBar_快餐店建造者模式_实例1.Packing_包装材料
{
    /// <summary>
    /// 瓶子
    /// </summary>
    public class Bottle_瓶子 : IPacking_食物包装接口
    {
        public string Pack()
        {
            return "Bottle_瓶子";
        }
    }
}
