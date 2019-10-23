using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_迭代器模式.Examp_e_1
{
    public class NameIterator : IIterator
    {
        string[] names;
        public NameIterator(string[] names) { this.names = names; }
        int index;
        public bool HasNext()
        {
            if (index < names.Length)
            {
                return true;
            }
            return false;
        }

        public object Next()
        {
            if (this.HasNext())
            {
                return names[index++];
            }
            return null;
        }
    }
}
