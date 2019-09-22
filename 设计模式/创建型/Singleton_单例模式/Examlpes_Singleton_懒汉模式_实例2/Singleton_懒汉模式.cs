using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_单例模式.Examlpes_Singleton_懒汉模式_实例2
{
    public class Singleton_懒汉模式
    {
        private static Singleton_懒汉模式 instance;
        private Singleton_懒汉模式() { }

        public static   Singleton_懒汉模式 getInstance()
        {
            if (instance == null)
            {
                instance = new Singleton_懒汉模式();
            }
            return instance;
        }
    }
}
