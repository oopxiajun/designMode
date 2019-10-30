using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_观察者模式.Example_1
{
    public interface ComputerPart
    {
        void accept(ComputerPartVisitor computerPartVisitor);
    }
}
