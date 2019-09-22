using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_适配器模式.Examples_实例2
{
    public interface IComputer
    {
        String ReadSD(ISDCard sdCard);
    }
}
