using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_代理模式.Example_1
{
    class RealImage : IImage
    {
        private String fileName;
        public RealImage(String fileName)
        {
            this.fileName = fileName;
            loadFromDisk(fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying:" + fileName);
        }
        private void loadFromDisk(String fileName)
        {
            Console.WriteLine("Loading:" + fileName);
        }
    }
}
