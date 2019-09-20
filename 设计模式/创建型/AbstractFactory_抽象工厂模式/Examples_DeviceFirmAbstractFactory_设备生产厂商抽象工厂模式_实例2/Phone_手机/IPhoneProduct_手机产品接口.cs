using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_抽象工厂模式.Examples_DeviceFirmAbstractFactory_设备生产厂商抽象工厂模式_实例2.Phone_手机
{
    /// <summary>
    /// 手机产品接口
    /// </summary>
    public interface IPhoneProduct_手机产品接口
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
        /// 拨打电话
        /// </summary>
        void CallUp();

        /// <summary>
        /// 发送短信
        /// </summary>
        void SendSMS(); 
    }
}
