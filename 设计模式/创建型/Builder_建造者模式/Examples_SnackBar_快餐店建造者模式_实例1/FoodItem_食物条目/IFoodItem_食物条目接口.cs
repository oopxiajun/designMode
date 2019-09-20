using Builder_建造者模式.Examples_SnackBar_快餐店建造者模式_实例1.Packing_包装材料;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_建造者模式.Examples_SnackBar_快餐店建造者模式_实例1.FoodItem_食物条目
{
    /// <summary>
    /// 食物条目接口
    /// </summary>
    public interface IFoodItem_食物条目接口
    {
        /// <summary>
        /// 名字
        /// </summary>
        /// <returns></returns>
        string Name();
        /// <summary>
        /// 包装
        /// </summary>
        /// <returns></returns>
        IPacking_食物包装接口 Packing();
        /// <summary>
        /// 价格
        /// </summary>
        /// <returns></returns>
        float Price();
    }
}
