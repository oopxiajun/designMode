using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory_抽象工厂模式.Examples_DeviceFirmAbstractFactory_设备生产厂商抽象工厂模式_实例2
{
    public class AbstractFactoryPatternDemo
    {
        public static void test()
        {
            while (true)
            {
                Console.WriteLine("请输入生产厂商:");
                string factoryStr = Console.ReadLine();
                //获取形状工厂
                Examples_DeviceFirmAbstractFactory_设备生产厂商抽象工厂模式_实例2.IProductFactory_抽象产品工厂接口 factory = FactotyProducer_工厂生产者.GetFactory(factoryStr);

                if (factory != null)
                {
                    Console.WriteLine("请输入生产的产品:");
                    string prod = Console.ReadLine();
                    if (prod.ToUpper().Equals("手机"))
                    {
                        Phone_手机.IPhoneProduct_手机产品接口 phone = factory.ProduceTelPhone();
                        phone.Start();
                        phone.CallUp();
                        phone.SendSMS();
                        phone.Shutdown();

                    }
                    else if (prod.ToUpper().Equals("路由器"))
                    {
                        Router_路由器.IRouterProduct_路由器产品接口 router = factory.ProduceRouter();
                        router.Start();
                        router.Setting();
                        router.OpenWifi();
                        router.Shutdown();
                    }
                    else
                    {
                        Console.WriteLine("暂不不能生产该类型");
                    }
                }
                else
                {
                    Console.WriteLine("暂不不能生产该类型");
                }
            }

        }
    }
}
