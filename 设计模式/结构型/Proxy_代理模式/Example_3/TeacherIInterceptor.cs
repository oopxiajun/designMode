using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_代理模式.Example_3
{
    class TeacherIInterceptor : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            Console.WriteLine("进入方法，参数:" + invocation.Arguments[0].ToString());
            invocation.Proceed();
            Console.WriteLine("离开方法，返回值:" + invocation.ReturnValue);
        }
    }
}
