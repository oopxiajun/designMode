using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_适配器模式.Examples_实例2
{
    public class ComputerReadDemo
    {
        public static void test1()
        {
            IComputer computer = new ThinkpadComputer();
            ISDCard sdCard = new SDCardImpl();
            Console.WriteLine(computer.ReadSD(sdCard));
        }
        public static void test2( )
        {
            IComputer computer = new ThinkpadComputer();
            ISDCard sdCard = new SDCardImpl();
            Console.WriteLine(computer.ReadSD(sdCard));
            Console.WriteLine("====================================");
            ITFCard tfCard = new TFCardImpl();
            ISDCard tfCardAdapterSD = new SDAdapterTF(tfCard);
            Console.WriteLine(computer.ReadSD(tfCardAdapterSD));
        }
    }
}
