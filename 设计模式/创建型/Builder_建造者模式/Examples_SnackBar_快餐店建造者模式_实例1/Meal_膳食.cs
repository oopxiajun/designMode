using Builder_建造者模式.Examples_SnackBar_快餐店建造者模式_实例1.FoodItem_食物条目;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder_建造者模式.Examples_SnackBar_快餐店建造者模式_实例1
{
    public class Meal_膳食
    {
        private List<IFoodItem_食物条目接口> items = new List<IFoodItem_食物条目接口>();

        public void AddItem(IFoodItem_食物条目接口 item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;
            foreach (IFoodItem_食物条目接口 item in
                items)
            {
                cost += item.Price();
            }
            return cost;
        }

        public void ShowItems()
        {
            foreach (IFoodItem_食物条目接口 item in items)
            {
                Console.WriteLine("Item : " + item.Name());
                Console.WriteLine(", Packing : " + item.Packing().Pack());
                Console.WriteLine(", Price : " + item.Price());
            }
        }
    }
}
