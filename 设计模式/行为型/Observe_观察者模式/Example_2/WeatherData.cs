using System;
using System.Collections.Generic;
using System.Text;

namespace Observe_观察者模式.Example_2
{
    /// <summary>
    /// 天气
    /// </summary>
    public class WeatherData : ISubject
    {
        private List<IObserver> observersList;
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData()
        {
            observersList = new List<IObserver>();
        }
        public void RegisterObserver(IObserver obs)
        {
            observersList.Add(obs);
        }
        public void RemoveObserver(IObserver obs)
        {
            int index = observersList.IndexOf(obs);
            if (index >= 0)
            {
                observersList.RemoveAt(index);
            }
        }
        public void MeasurementsChanged()
        {
            Console.WriteLine("There is new data available...");
            NotifyObservers();
        }
        public void NotifyObservers()
        {
            foreach (IObserver observer in observersList)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
