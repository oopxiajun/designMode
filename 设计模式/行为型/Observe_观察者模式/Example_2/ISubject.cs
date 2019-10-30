using System;
using System.Collections.Generic;
using System.Text;

namespace Observe_观察者模式.Example_2
{
    public interface ISubject
    {
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="obs"></param>
        void RegisterObserver(IObserver obs);
        /// <summary>
        /// 移除
        /// </summary>
        /// <param name="obs"></param>
        void RemoveObserver(IObserver obs);
        /// <summary>
        /// 通知
        /// </summary>
        void NotifyObservers();
    }
}
