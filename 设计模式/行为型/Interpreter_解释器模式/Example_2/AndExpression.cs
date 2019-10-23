using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter_解释器模式.Example_2
{
    class AndExpression : IExpression
    {
        private IExpression expr1 = null;
        private IExpression expr2 = null;

        public AndExpression(IExpression expr1, IExpression expr2)
        {
            this.expr1 = expr1;
            this.expr2 = expr2;
        }
        public bool interpret(string context)
        {
            return expr1.interpret(context) && expr2.interpret(context);
        }
    }
}
