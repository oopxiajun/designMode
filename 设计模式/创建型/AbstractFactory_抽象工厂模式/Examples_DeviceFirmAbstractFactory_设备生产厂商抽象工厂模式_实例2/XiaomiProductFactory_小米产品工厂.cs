using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory_抽象工厂模式.Examples_DeviceFirmAbstractFactory_设备生产厂商抽象工厂模式_实例2.Phone_手机;
using AbstractFactory_抽象工厂模式.Examples_DeviceFirmAbstractFactory_设备生产厂商抽象工厂模式_实例2.Router_路由器;

namespace AbstractFactory_抽象工厂模式.Examples_DeviceFirmAbstractFactory_设备生产厂商抽象工厂模式_实例2
{
    /// <summary>
    /// 小米产品工厂
    /// </summary>
    class XiaomiProductFactory_小米产品工厂 : IProductFactory_抽象产品工厂接口
    {
        public IRouterProduct_路由器产品接口 ProduceRouter()
        {
            Console.WriteLine(">>>>>>生产小米路由器");
            return new XiaomiRouter_小米路由器();
        }

        public IPhoneProduct_手机产品接口 ProduceTelPhone()
        {
            Console.WriteLine(">>>>>>生产小米手机");
            return new XiaomiPhone_小米手机();
        }
    }
}
