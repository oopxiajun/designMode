using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_适配器模式.Examples_实例2
{
    public class SDAdapterTF : ISDCard
    {
        private ITFCard tfCard;
        public SDAdapterTF(ITFCard tfCard)
        {
            this.tfCard = tfCard;
        }
        public String ReadSD()
        {
            Console.WriteLine("adapter read tf card ");
            return tfCard.ReadTF();
        }
        public int WriteSD(String msg)
        {
            Console.WriteLine("adapter write tf card");
            return tfCard.WriteTF(msg);
        }
    }
}
