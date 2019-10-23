using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter_解释器模式.Example_1
{
    //十位表达式
    public sealed class ShiExpression : Expression
    {
        public override string GetPostFix()
        {
            return "十";
        }

        public override int Multiplier()
        {
            return 10;
        }
    }
}
