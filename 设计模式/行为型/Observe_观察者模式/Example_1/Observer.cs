using System;
using System.Collections.Generic;
using System.Text;

namespace Observe_观察者模式.Example_1
{
    public abstract  class Observer
    {
        protected Subject subject;
        public abstract void Update();
    }
}
