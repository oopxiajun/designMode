using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_单例模式.Examples_实例1
{
    public class SingletonPatternDemo
    {
        public static void test()
        {

            //不合法的构造函数
            //编译时错误：构造函数 SingleObject() 是不可见的
            //SingleObject obj = new SingleObject();

            //获取唯一可用的对象
            SingleObject object1 = SingleObject.getInstance();

            //显示消息
            object1.showMessage();
        }
    }
}
