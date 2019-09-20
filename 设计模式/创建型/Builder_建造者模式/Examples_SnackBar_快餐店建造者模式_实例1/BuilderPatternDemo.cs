using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_建造者模式.Examples_SnackBar_快餐店建造者模式_实例1
{
    public class BuilderPatternDemo
    {
        public static void test()
        {
            MealBuilder_膳食建造者 mealBuilder = new MealBuilder_膳食建造者();
            while (true)
            {
                Meal_膳食 vegMeal = null;
                Console.WriteLine("欢迎光临本店！！\r\n\r\n您是需要有蔬菜的膳食还是没有蔬菜的膳食（Y/N）？");
                string key = Console.ReadLine();
                if (key.ToUpper().Equals("Y"))
                {
                    Console.WriteLine("Veg Meal 有蔬菜的膳食");
                    vegMeal = mealBuilder.PrepareVegMeal();

                }
                else if (key.ToUpper().Equals("N"))
                {
                    Console.WriteLine("Non Veg Meal 无蔬菜的膳食");
                    vegMeal = mealBuilder.PrepareVegMeal();
                }
                vegMeal.ShowItems();
                Console.WriteLine("Total Cost 总价: " + vegMeal.GetCost());
            }

        }
    }
}
