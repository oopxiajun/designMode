using System;
using System.Collections.Generic;
using System.Text;

namespace Command_命令模式.Example_1
{
    /// <summary>
    /// 抽象命令类，用来声明执行操作的接口
    /// </summary>
    public interface ICommand
    {
        void Execute();
    }
}
