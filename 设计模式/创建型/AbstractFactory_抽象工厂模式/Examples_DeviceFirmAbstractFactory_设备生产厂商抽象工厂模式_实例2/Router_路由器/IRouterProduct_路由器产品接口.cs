using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_抽象工厂模式.Examples_DeviceFirmAbstractFactory_设备生产厂商抽象工厂模式_实例2.Router_路由器
{
    /// <summary>
    /// 路由器产品接口
    /// </summary>
    public interface IRouterProduct_路由器产品接口
    {
        /// <summary>
        /// 开机
        /// </summary>
        void Start();

        /// <summary>
        /// 关机
        /// </summary>
        void Shutdown();

        /// <summary>
        /// 开启wifi
        /// </summary>
        void OpenWifi();

        /// <summary>
        /// 设置参数
        /// </summary>
        void Setting();

    }
}
