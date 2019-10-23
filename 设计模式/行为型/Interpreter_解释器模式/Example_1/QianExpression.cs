using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter_解释器模式.Example_1
{
    //千位表达式
    public sealed class QianExpression : Expression
    {
        public override string GetPostFix()
        {
            return "千";
        }

        public override int Multiplier()
        {
            return 1000;
        }
    }
}
