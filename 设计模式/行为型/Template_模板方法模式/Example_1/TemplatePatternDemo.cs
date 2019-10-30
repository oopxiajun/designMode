using System;
using System.Collections.Generic;
using System.Text;

namespace Template_模板方法模式.Example_1
{
    public class TemplatePatternDemo
    {
        public static void test( )
        {

            Game game = new Cricket();
            game.play();
            Console.WriteLine();
            game = new Football();
            game.play();
        }
    }
}
