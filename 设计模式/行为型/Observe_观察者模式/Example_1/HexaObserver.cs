using System;
using System.Collections.Generic;
using System.Text;

namespace Observe_观察者模式.Example_1
{
    /// <summary>
    /// 具体观察者  ：Hexa
    /// </summary>
    class HexaObserver : Observer
    {

        public HexaObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Add(this);
        }

        public override void Update()
        {
            Console.WriteLine("Hex String: "  + subject.GetState());
        }
    }
}
