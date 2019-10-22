using System;
using System.Collections.Generic;
using System.Text;

namespace Command_命令模式.Example_1
{
    /// <summary>
    /// 接收者类，知道如何实施与执行一个请求相关的操作，任何类都可能作为一个接收者。
    /// </summary>
    public class Receiver
    {
        /// <summary>
        /// 真正的命令实现
        /// </summary>
        public void Action()
        {
            Console.WriteLine("Execute request!");
        }
    }
}
