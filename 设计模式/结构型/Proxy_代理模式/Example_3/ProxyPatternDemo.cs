using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_代理模式.Example_3
{
    public class ProxyPatternDemo
    {
        public static void test()
        {
            Teacher teacher = CreateLandlordProxy();
            teacher.Say("天天");
        }
        private static Teacher CreateLandlordProxy()
        {
            ProxyGenerator proxyGenerator = new ProxyGenerator();
            Teacher proyLandlord = proxyGenerator.CreateClassProxy<Teacher>(new TeacherIInterceptor());
            return proyLandlord;
        }
    }
}
