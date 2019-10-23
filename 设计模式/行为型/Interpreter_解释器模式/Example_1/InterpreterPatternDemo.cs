using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Interpreter_解释器模式.Example_1
{
    public class InterpreterPatternDemo
    {
        public static void test()
        {
            string roman = "五亿七千三百万六千四百五十二";
            //分解：((五)亿)((七千)(三百)(零)(二)万)
            //((六千)(四百)(五十)(二))

            Context context = new Context(roman);
            ArrayList tree = new ArrayList();

            tree.Add(new GeExpression());
            tree.Add(new ShiExpression());
            tree.Add(new BaiExpression());
            tree.Add(new QianExpression());
            tree.Add(new WanExpression());
            tree.Add(new YiExpression());

            foreach (Expression exp in tree)
            {
                exp.Interpreter(context);
            }

            Console.Write(context.Data);

            Console.Read();
        }
    }
}
