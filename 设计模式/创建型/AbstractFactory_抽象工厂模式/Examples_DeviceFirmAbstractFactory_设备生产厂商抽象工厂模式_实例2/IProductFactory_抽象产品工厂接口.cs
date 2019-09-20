using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_抽象工厂模式.Examples_DeviceFirmAbstractFactory_设备生产厂商抽象工厂模式_实例2
{
    /// <summary>
    /// 抽象产品工厂（定义了同一个产品族的产品生产行为）
    /// </summary>
    public interface IProductFactory_抽象产品工厂接口
    {
        /// <summary>
        /// 生产手机
        /// </summary>
        /// <returns></returns>
        Phone_手机.IPhoneProduct_手机产品接口 ProduceTelPhone();

        /// <summary>
        /// 生产路由器
        /// </summary>
        /// <returns></returns>
        Router_路由器.IRouterProduct_路由器产品接口 ProduceRouter();
    }
}
