using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_中介者模式.Example_1
{
    public class MediatorTest
    {// Use this for initialization
        public static void test()
        {
            Matcher liGouDan = new Man(52, 10000000, 20000, 0);
            Matcher cuiHua = new Women(20, 3000, 3000000, 0);

            WomenMatchMaker womenMatchMaker = new WomenMatchMaker(liGouDan, cuiHua);
            womenMatchMaker.OfferManInformation();
            womenMatchMaker.OfferWoManInformation();
        }
    }
}
