using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_抽象工厂模式.Examples_DeviceFirmAbstractFactory_设备生产厂商抽象工厂模式_实例2.Router_路由器
{
    /// <summary>
    /// 小米路由器
    /// </summary>
    public class XiaomiRouter_小米路由器 : IRouterProduct_路由器产品接口
    {
        public void OpenWifi()
        {
            Console.WriteLine("打开小米路由器的wifi功能");
        }

        public void Setting()
        {
            Console.WriteLine("设置小米路由器参数");
        }

        public void Shutdown()
        {
            Console.WriteLine("关闭小米路由器");
        }

        public void Start()
        {
            Console.WriteLine("启动小米路由器");
        }
    }
}
