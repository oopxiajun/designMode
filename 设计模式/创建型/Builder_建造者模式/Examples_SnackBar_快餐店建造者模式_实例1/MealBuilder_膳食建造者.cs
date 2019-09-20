using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_建造者模式.Examples_SnackBar_快餐店建造者模式_实例1
{
    public class MealBuilder_膳食建造者
    {
        /// <summary>
        /// 准备有蔬菜的膳食
        /// </summary>
        /// <returns></returns>
        public Meal_膳食 PrepareVegMeal()
        {
            Meal_膳食 meal = new Meal_膳食();
            meal.AddItem(new Foods_食物.VegBurger_蔬菜汉堡());
            meal.AddItem(new Foods_食物.Coke_可口可乐());
            return meal;
        }
        /// <summary>
        /// 准备没有蔬菜的膳食
        /// </summary>
        /// <returns></returns>
        public Meal_膳食 PrepareNonVegMeal()
        {
            Meal_膳食 meal = new Meal_膳食();
            meal.AddItem(new Foods_食物.ChickenBurger_鸡肉汉堡());
            meal.AddItem(new Foods_食物.Pepsi_百事可乐());
            return meal;
        }
    }
}
