using System;
using System.Collections.Generic;
using System.Text;

namespace Command_命令模式.Example_1
{
    public class CommandPatternDemo
    {
        public   static void test()
        {
            Receiver receiver = new Receiver();
            ICommand command = new ConcereteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExecuteCommand();

            Console.Read();
        }
    }
}
