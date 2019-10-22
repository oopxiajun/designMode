using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_职责链模式.Example_1
{
    public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level)
        {
            this.Level = level;
        }
        protected override void Write(string message)
        {
            Console.WriteLine("Error Console::Logger: " + message);
        }
    }
}
