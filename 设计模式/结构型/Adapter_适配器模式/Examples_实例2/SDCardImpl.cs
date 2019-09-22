using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_适配器模式.Examples_实例2
{
    public class SDCardImpl : ISDCard
    {
        public string ReadSD()
        {
            String msg = "sdcard read a msg :hello word SD";
            return msg;
        }

        public int WriteSD(string msg)
        {
           Console.WriteLine("sd card write msg : " + msg);
            return 1;
        }
    }
}
