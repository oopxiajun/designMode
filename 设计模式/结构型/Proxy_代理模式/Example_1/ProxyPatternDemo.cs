using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_代理模式.Example_1
{
    class ProxyPatternDemo
    {
        public static void main( )
        {
            IImage image = new ProxyImage("test_10mb.jpg");

            // 图像将从磁盘加载
            image.Display(); 
            // 图像不需要从磁盘加载
            image.Display();
        }
    }
}
