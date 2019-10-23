using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_迭代器模式.Examp_e_1
{
    public interface IIterator
    {
        bool HasNext();
        Object Next();
    }
}
