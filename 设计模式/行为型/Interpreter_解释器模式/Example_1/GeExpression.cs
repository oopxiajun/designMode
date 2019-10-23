using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter_解释器模式.Example_1
{
    //个位表达式
    public sealed class GeExpression : Expression
    {
        public override string GetPostFix()
        {
            return "";
        }

        public override int Multiplier()
        {
            return 1;
        }

        public override int GetLength()
        {
            return 1;
        }
    }
}
