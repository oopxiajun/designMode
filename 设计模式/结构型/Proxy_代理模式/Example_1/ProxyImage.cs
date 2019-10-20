using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_代理模式.Example_1
{
    public class ProxyImage : IImage
    {
        private RealImage realImage;
        private String fileName;
        public ProxyImage(String fileName) => this.fileName = fileName;
        public void Display()
        {
            if (realImage == null)
            {
                realImage = new RealImage(fileName);
            }
            realImage.Display();
        }
    }
}
