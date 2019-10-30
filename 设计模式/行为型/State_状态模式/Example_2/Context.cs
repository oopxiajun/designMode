using System;
using System.Collections.Generic;
using System.Text;

namespace State_状态模式.Example_2
{
    public class Context
    {
        private State _state;

        public Context(State state)
        {
            this.State = state;
        }

        public State State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                Console.WriteLine("State: " + _state.GetType().Name);
            }
        }

        public void Request()
        {
            _state.Handle(this);
        }
    }
}
