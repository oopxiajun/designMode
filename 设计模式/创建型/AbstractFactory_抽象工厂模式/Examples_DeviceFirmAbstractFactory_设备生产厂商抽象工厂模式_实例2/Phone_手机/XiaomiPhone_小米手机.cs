using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_抽象工厂模式.Examples_DeviceFirmAbstractFactory_设备生产厂商抽象工厂模式_实例2.Phone_手机
{
    /// <summary>
    /// 小米手机产品
    /// </summary>
    public class XiaomiPhone_小米手机 : IPhoneProduct_手机产品接口
    {
        public void CallUp()
        {
            Console.WriteLine("用小米手机打电话");
        }

        public void SendSMS()
        {
            Console.WriteLine("用小米手机发短信");
        }

        public void Shutdown()
        {
            Console.WriteLine("关闭小米手机");
        }

        public void Start()
        {
            Console.WriteLine("开启小米手机");
        }
    }
}
