using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_代理模式.Example_2
{
    class _12306SaleTicket : ISaleTicket
    {
        string saler;
        public _12306SaleTicket(string saler= "12306") => this.saler = saler;
        public void BuyTicket()
        {
            Console.WriteLine($"从{saler}上购票");
        }

        public void DrawTicket()
        {
            Console.WriteLine($"从{saler}上出票");
        }
    }
}
