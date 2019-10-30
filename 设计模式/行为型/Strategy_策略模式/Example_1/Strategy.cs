using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_策略模式.Example_1
{
    public interface IStrategy
    {
         int DoOperation(int num1, int num2);
    }
}
