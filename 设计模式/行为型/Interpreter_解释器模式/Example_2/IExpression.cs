using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter_解释器模式.Example_2
{
    public interface IExpression
    {
        bool interpret(String context);
    }
}
