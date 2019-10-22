using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility_职责链模式.Example_1
{
   public abstract class AbstractLogger
    {
        public static int INFO = 1;
        public static int DEBUG = 2;
        public static int ERROR = 3;

        protected int Level;

        //责任链中的下一个元素
        protected AbstractLogger NextLogger;

        public void SetNextLogger(AbstractLogger nextLogger)
        {
            this.NextLogger = nextLogger;
        }

        public void LogMessage(int level, String message)
        {
            if (this.Level <= level)
            {
                Write(message);
            }
            if (NextLogger != null)
            {
                NextLogger.LogMessage(level, message);
            }
        }

        abstract protected void Write(String message);
    }
}
