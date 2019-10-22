using System;
using System.Collections.Generic;
using System.Text;

namespace Command_命令模式.Example_2
{
    public class SellStock : IOrder
    {
        private Stock abcStock;

        public SellStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }
        public void Execute()
        {
            abcStock.Sell();
        }
    }
}
