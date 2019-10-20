using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_代理模式.Example_2
{
   public class ProxyPatternDemo
    {
        public static void test() {
            ISaleTicket saleTicket = new ProxySaleTicket("");
            ISaleTicket saleTicket2 = new ProxySaleTicket("东门");

            saleTicket.BuyTicket();
            saleTicket2.BuyTicket();

            saleTicket.DrawTicket();
            saleTicket2.DrawTicket();

        }
    }
}
