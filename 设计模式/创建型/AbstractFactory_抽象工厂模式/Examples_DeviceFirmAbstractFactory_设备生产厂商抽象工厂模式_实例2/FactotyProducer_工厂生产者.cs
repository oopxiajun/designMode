using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_抽象工厂模式.Examples_DeviceFirmAbstractFactory_设备生产厂商抽象工厂模式_实例2
{
  public  class FactotyProducer_工厂生产者
    {
        public static Examples_DeviceFirmAbstractFactory_设备生产厂商抽象工厂模式_实例2.IProductFactory_抽象产品工厂接口 GetFactory(String choice)
        {
            if (choice.ToUpper().Equals("华为")|| choice.ToUpper().Equals("HUAWEI"))
            {
                return new HuaweiProductFactory_华为产品工厂();
            }
            else if (choice.ToUpper().Equals("小米")|| choice.ToUpper().Equals("XIAOMI"))
            {
                return new XiaomiProductFactory_小米产品工厂();
            }
            return null;
        } 
    }
}
