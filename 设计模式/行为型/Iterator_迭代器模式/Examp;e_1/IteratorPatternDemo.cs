using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator_迭代器模式.Examp_e_1
{
    public class IteratorPatternDemo
    {
        public static void test()
        {
            NameRepository namesRepository = new NameRepository();

            for (IIterator iter = namesRepository.GetIterator(); iter.HasNext();)
            {
                String name = (String)iter.Next();
                Console.WriteLine("Name : " + name);
            }
        }
    }
}
