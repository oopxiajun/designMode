using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_建造者模式.Examples_SnackBar_快餐店建造者模式_实例1.Foods_食物
{
    public class Pepsi_百事可乐 : FoodItem_食物条目.ColdDrink_冷饮
    {
        public override string Name()
        {
            return "Pepsi_百事可乐";
        }

        public override float Price()
        {
            return 35.0f;
        }
    }
}
