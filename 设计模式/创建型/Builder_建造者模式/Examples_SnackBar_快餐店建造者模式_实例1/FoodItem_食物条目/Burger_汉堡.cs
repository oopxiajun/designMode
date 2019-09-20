using Builder_建造者模式.Examples_SnackBar_快餐店建造者模式_实例1.Packing_包装材料;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_建造者模式.Examples_SnackBar_快餐店建造者模式_实例1.FoodItem_食物条目
{
    public abstract class Burger_汉堡 : IFoodItem_食物条目接口
    {
        public abstract string Name();

        public IPacking_食物包装接口 Packing()
        {
            return new Wrapper_包装纸();
        }

        public abstract float Price();
    }
}
