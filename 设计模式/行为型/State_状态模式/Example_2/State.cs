using System;
using System.Collections.Generic;
using System.Text;

namespace State_状态模式.Example_2
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}
