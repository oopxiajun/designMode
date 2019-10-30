using System;
using System.Collections.Generic;
using System.Text;

namespace State_状态模式.Example_1
{
    public class StatePatternDemo
    {
        public static void test( )
        {
            Context context = new Context();

            StartState startState = new StartState();
            startState.DoAction(context);

            Console.WriteLine(context.GetState().ToString());

            StopState stopState = new StopState();
            stopState.DoAction(context);

            Console.WriteLine(context.GetState().ToString());
        }
    }
}
