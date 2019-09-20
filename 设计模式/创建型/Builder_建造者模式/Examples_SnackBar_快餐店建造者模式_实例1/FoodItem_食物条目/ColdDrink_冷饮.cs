using Builder_建造者模式.Examples_SnackBar_快餐店建造者模式_实例1.FoodItem_食物条目;
using Builder_建造者模式.Examples_SnackBar_快餐店建造者模式_实例1.Packing_包装材料;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_建造者模式.Examples_SnackBar_快餐店建造者模式_实例1.FoodItem_食物条目
{
    /// <summary>
    /// 冷饮
    /// </summary>
    public abstract class ColdDrink_冷饮 : IFoodItem_食物条目接口
    {
        public abstract string Name();

        public IPacking_食物包装接口 Packing()
        {
            return new Bottle_瓶子();
        }

        public abstract float Price();
    }
}
