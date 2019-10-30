using System;
using System.Collections.Generic;
using System.Text;

namespace State_状态模式.Example_2
{
    public class ConcreteStateB : State
    {
        public override void Handle(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }
}
