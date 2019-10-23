using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter_解释器模式.Example_2
{
    class TerminalExpression : IExpression
    {
        private String data;

        public TerminalExpression(String data)
        {
            this.data = data;
        }
        public bool interpret(string context)
        {
            if (context.Contains(data))
            {
                return true;
            }
            return false;
        }
    }
}
