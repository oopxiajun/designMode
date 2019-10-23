using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator_中介者模式.Example_1
{
    public class Women : Matcher
    {
        public Women(int age, int money, int familuBG, int favor) : base(age, money, familuBG, favor)
        {
        }
    }
}
