using System;
using System.Collections.Generic;
using System.Text;

namespace State_状态模式.Example_1
{
    class StartState:IState
    {
        public void DoAction(Context context)
        {
            Console.WriteLine("Player is in start state");
            context.SetState(this);
        }

        public String ToString()
        {
            return "Start State";
        }
    }
}
