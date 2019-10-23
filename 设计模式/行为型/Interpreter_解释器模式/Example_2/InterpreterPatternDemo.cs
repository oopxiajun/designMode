using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter_解释器模式.Example_2
{
    public class InterpreterPatternDemo
    {//规则：Robert 和 John 是男性
        public static IExpression getMaleExpression()
        {
            IExpression robert = new TerminalExpression("Robert");
            IExpression john = new TerminalExpression("John");
            return new OrExpression(robert, john);
        }

        //规则：Julie 是一个已婚的女性
        public static IExpression getMarriedWomanExpression()
        {
            IExpression julie = new TerminalExpression("Julie");
            IExpression married = new TerminalExpression("Married");
            return new AndExpression(julie, married);
        }

        public static void test()
        {
            IExpression isMale = getMaleExpression();
            IExpression isMarriedWoman = getMarriedWomanExpression();

            Console.WriteLine("John is male? " + isMale.interpret("John"));
            Console.WriteLine("Julie is a married women? "
            + isMarriedWoman.interpret("Married Julie"));
        }
    }
}
