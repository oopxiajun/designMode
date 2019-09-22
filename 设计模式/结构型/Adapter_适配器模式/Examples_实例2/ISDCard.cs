using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter_适配器模式.Examples_实例2
{
    public interface ISDCard
    { //读取SD卡方法
        String ReadSD();
        //写入SD卡功能
        int WriteSD(String msg);
    }
}
