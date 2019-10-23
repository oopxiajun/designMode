using System;
using System.Collections.Generic;
using System.Text;

namespace Memento_备忘录模式.Example_1
{
    public class ContactMemento
    {// 保存发起人的内部状态
        public List<ContactPerson> ContactPersonBack;

        public ContactMemento(List<ContactPerson> persons)
        {
            ContactPersonBack = persons;
        }
    }
}
