using System;
using System.Collections.Generic;
using System.Text;

namespace State_状态模式.Example_2
{
  public  class StatePatternDemo
    {
        public static void test( )
        {
            // Setup context in a state
            Context c = new Context(new ConcreteStateA());

            // Issue requests, which toggles state
            c.Request();
            c.Request();
            c.Request();
            c.Request();
            c.Request();
            c.Request();
        }
    }
}
