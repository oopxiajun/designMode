using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_职责链模式.Example_2
{
    public class ConcreteHandler3:Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 20 && request < 30)
            {
                Console.WriteLine("20-30:{0} handled request {1}", this.GetType().Name, request);
            }

            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
