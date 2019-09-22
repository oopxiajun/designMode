using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_适配器模式.Examples_实例2
{
    class ThinkpadComputer : IComputer
    {
        public string ReadSD(ISDCard sdCard)
        { 
            if (sdCard == null) throw new NotImplementedException("sd card null");
            return sdCard.ReadSD();
        }
    }
}
