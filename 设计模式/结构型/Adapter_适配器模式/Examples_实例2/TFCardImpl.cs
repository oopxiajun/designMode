using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_适配器模式.Examples_实例2
{
    class TFCardImpl : ITFCard
    {
        public string ReadTF()
        { 
            String msg = "tf card reade msg : hello word tf card";
            return msg;
        }

        public int WriteTF(string msg)
        {
           Console.WriteLine("tf card write a msg : " + msg);
            return 1;
        }
    }
}
