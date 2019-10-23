using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter_解释器模式.Example_1
{
    //百位表达式
    public sealed class BaiExpression : Expression
    {
        public override string GetPostFix()
        {
            return "百";
        }

        public override int Multiplier()
        {
            return 100;
        }
    }
}
