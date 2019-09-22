using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_单例模式.Singleton_懒汉和饿汉一起
{
    public class Singleton_懒汉和饿汉一起
    {
        private volatile static Singleton_懒汉和饿汉一起 singleton;
        private Singleton_懒汉和饿汉一起() { }
        public static Singleton_懒汉和饿汉一起 getSingleton()
        {
            if (singleton == null)
            {
                lock (singleton)
                {
                    if (singleton == null)
                    {
                        singleton = new Singleton_懒汉和饿汉一起();
                    }
                }
            }
            return singleton;
        }
    }
}
