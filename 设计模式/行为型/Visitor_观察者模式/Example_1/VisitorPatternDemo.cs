using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_观察者模式.Example_1
{
    public class VisitorPatternDemo
    {
        public static void test( )
        {
            ComputerPart computer = new Computer();
            computer.accept(new ComputerPartDisplayVisitor());
        }
    }
}
