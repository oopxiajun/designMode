using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_迭代器模式.Examp_e_1
{
    class NameRepository : IContainer
    {
        public String[] names =new string[] { "Robert", "John", "Julie", "Lora" };
        public IIterator GetIterator()
        {
            return new NameIterator(names);
        }
         
    }
}
