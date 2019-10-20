using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_代理模式.Example_2
{
    class ProxySaleTicket : ISaleTicket
    {
        ISaleTicket saleTicket = null;

        public ProxySaleTicket(string saler)
        {
            if (string.IsNullOrWhiteSpace(saler))
            {
                saleTicket = new _12306SaleTicket();
            }
            else
            {
                saleTicket = new _12306SaleTicket(saler);
            }
        }
        public void BuyTicket()
        {
            saleTicket.BuyTicket();
        }

        public void DrawTicket()
        {
            saleTicket.DrawTicket();
        }
    }
}
