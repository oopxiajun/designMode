using System;
using System.Collections.Generic;
using System.Text;

namespace Command_命令模式.Example_2
{
    public class CommandPatternDemo
    {
        public static void test()
        {
            Stock abcStock = new Stock();

            BuyStock buyStockOrder = new BuyStock(abcStock);
            SellStock sellStockOrder = new SellStock(abcStock);

            Broker broker = new Broker();
            broker.TakeOrder(buyStockOrder);
            broker.TakeOrder(sellStockOrder);

            broker.PlaceOrders();
        }
    }
}
