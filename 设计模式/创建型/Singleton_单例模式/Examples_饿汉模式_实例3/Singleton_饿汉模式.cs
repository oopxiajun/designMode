using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_单例模式.Examples_饿汉模式_实例3
{
    public class Singleton_饿汉模式
    {
        private static Singleton_饿汉模式 instance = new Singleton_饿汉模式();
        private Singleton_饿汉模式() { }
        public static Singleton_饿汉模式 getInstance()
        {
            return instance;
        }
    }
}
