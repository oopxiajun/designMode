using System;
using System.Collections.Generic;
using System.Text;

namespace Command_命令模式.Example_2
{
    public class Broker
    {
        private List<IOrder> orderList = new List<IOrder>();

        public void TakeOrder(IOrder order)
        {
            orderList.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (IOrder order in orderList)
            {
                order.Execute();
            }
            orderList.Clear();
        }
    }
}
