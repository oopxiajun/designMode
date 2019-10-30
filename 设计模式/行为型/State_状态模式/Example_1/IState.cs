using System;
using System.Collections.Generic;
using System.Text;

namespace State_状态模式.Example_1
{
    public interface IState
    {
        void DoAction(Context context);
        String ToString();
    }
}
