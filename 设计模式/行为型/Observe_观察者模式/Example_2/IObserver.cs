using System;
using System.Collections.Generic;
using System.Text;

namespace Observe_观察者模式.Example_2
{
    public interface IObserver
    {
        void Update(float temperature, float humidity, float pressure);
    }
}
