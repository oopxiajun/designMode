using System;
using System.Collections.Generic;
using System.Text;

namespace Command_命令模式.Example_2
{
    class BuyStock : IOrder
    {
        private Stock abcStock;

        public BuyStock(Stock abcStock)
        {
            this.abcStock = abcStock;
        }
        public void Execute()
        {
            abcStock.Buy();
        }
    }
}
