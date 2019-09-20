using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_抽象工厂模式.Examples_DeviceFirmAbstractFactory_设备生产厂商抽象工厂模式_实例2.Phone_手机
{
    /// <summary>
    /// 华为手机
    /// </summary>
    public class HuaweiPhone_华为手机 : IPhoneProduct_手机产品接口
    {
        public void CallUp()
        {
            Console.WriteLine("用华为手机打电话");
        }

        public void SendSMS()
        {
            Console.WriteLine("用华为手机发短信");
        }

        public void Shutdown()
        {
            Console.WriteLine("关闭华为手机");
        }

        public void Start()
        {
            Console.WriteLine("开启华为手机");
        }
    }
}
