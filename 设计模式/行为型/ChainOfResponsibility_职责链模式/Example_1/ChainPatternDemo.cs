using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_职责链模式.Example_1
{
    public class ChainPatternDemo
    {
        private static AbstractLogger GetChainOfLoggers()
        {
            AbstractLogger errorLogger = new ErrorLogger(AbstractLogger.ERROR);
            AbstractLogger fileLogger = new FileLogger(AbstractLogger.DEBUG);
            AbstractLogger consoleLogger = new ConsoleLogger(AbstractLogger.INFO);

            errorLogger.SetNextLogger(fileLogger);
            fileLogger.SetNextLogger(consoleLogger);

            return errorLogger;
        }

        public static void test()
        {
            AbstractLogger loggerChain = GetChainOfLoggers();

            loggerChain.LogMessage(AbstractLogger.INFO, "This is an information.");

            loggerChain.LogMessage(AbstractLogger.DEBUG, "This is a debug level information.");

            loggerChain.LogMessage(AbstractLogger.ERROR, "This is an error information.");
        }
    }
}
