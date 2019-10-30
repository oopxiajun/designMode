using System;
using System.Collections.Generic;
using System.Text;

namespace Observe_观察者模式.Example_1
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state;

        public int GetState()
        {
            return state;
        }

        public void SetState(int state)
        {
            this.state = state;
            NotifyAllObservers();
        }
        /// <summary>
        /// 添加观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Add(Observer observer) => observers.Add(observer);

        /// <summary>
        /// 通知所有观察者
        /// </summary>
        public void NotifyAllObservers()
        {
            foreach (Observer observer in observers)

                observer.Update();

        }
    }
}
