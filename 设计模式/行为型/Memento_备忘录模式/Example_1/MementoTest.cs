using System;
using System.Collections.Generic;
using System.Text;

namespace Memento_备忘录模式.Example_1
{
    public class MementoTest
    {
        public static void Main(string[] args)
        {
            var persons = new List<ContactPerson> {
                new ContactPerson { Name= "Learning Hard", MobileNum = "123445"},
                new ContactPerson { Name = "Tony", MobileNum = "234565"},
                new ContactPerson { Name = "Jock", MobileNum = "231455"}
            };
            var mobileOwner = new MobileOwner(persons);
            mobileOwner.Show();

            // 创建备忘录并保存备忘录对象
            var caretaker = new Caretaker { ContactM = mobileOwner.CreateMemento() };

            // 更改发起人联系人列表
            Console.WriteLine("----移除最后一个联系人--------");
            mobileOwner.ContactPersons.RemoveAt(2);
            mobileOwner.Show();

            // 恢复到原始状态
            Console.WriteLine("-------恢复联系人列表------");
            mobileOwner.RestoreMemento(caretaker.ContactM);
            mobileOwner.Show();

            Console.Read();
        }
    }
}
