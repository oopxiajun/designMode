using System;
using System.Collections.Generic;
using System.Text;

namespace State_状态模式.Example_1
{
    public class Context
    {
        private IState state;

        public Context()
        {
            state = null;
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public IState GetState()
        {
            return state;
        }
    }
}
