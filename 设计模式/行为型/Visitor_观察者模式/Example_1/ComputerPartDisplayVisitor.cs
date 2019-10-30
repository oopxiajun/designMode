using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_观察者模式.Example_1
{
    public class ComputerPartDisplayVisitor:ComputerPartVisitor
    {

        public void visit(Computer computer)
        {
            Console.WriteLine("Displaying Computer.");
        }

        public void visit(Mouse mouse)
        {
            Console.WriteLine("Displaying Mouse.");
        }

        public void visit(Keyboard keyboard)
        {
            Console.WriteLine("Displaying Keyboard.");
        }

        public void visit(Monitor monitor)
        {
            Console.WriteLine("Displaying Monitor.");
        }
    }
}
