using System;
using System.Collections.Generic;
using System.Text;

namespace Command_命令模式.Example_2
{
    public class Stock
    {
        String Name = "ABC";
        int Quantity = 10;

        public void Buy()
        {
            Console.WriteLine("Stock [ Name: " + Name + ",   Quantity: " + Quantity + " ] bought");
        }
        public void Sell()
        {
            Console.WriteLine("Stock [ Name: " + Name + ",   Quantity: " + Quantity + " ] sold");
        }
    }
}
