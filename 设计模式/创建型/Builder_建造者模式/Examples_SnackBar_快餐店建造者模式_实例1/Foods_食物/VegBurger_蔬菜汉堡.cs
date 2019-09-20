using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_建造者模式.Examples_SnackBar_快餐店建造者模式_实例1.Foods_食物
{
    /// <summary>
    /// 蔬菜汉堡
    /// </summary>
    public class VegBurger_蔬菜汉堡 : FoodItem_食物条目.Burger_汉堡
    {
        public override string Name()
        {
            return "VegBurger_蔬菜汉堡";
        }

        public override float Price()
        {
            return 25.0f;
        }
    }
}
