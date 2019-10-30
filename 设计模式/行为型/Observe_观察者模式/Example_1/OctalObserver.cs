using System;
using System.Collections.Generic;
using System.Text;

namespace Observe_观察者模式.Example_1
{
    /// <summary>
    /// 实体观察者  Octal
    /// </summary>
    public class OctalObserver : Observer
    {

        public OctalObserver(Subject subject)
        {
            this.subject = subject;
            this.subject.Add(this);
        }

        public override void Update()
        {
            Console.WriteLine("Octal String: " + subject.GetState());
        }
    }
}
