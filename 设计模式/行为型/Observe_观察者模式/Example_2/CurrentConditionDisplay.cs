using System;
using System.Collections.Generic;
using System.Text;

namespace Observe_观察者模式.Example_2
{
    /// <summary>
    /// 观察者
    /// </summary>
    public class CurrentConditionDisplay : IObserver, IDisplay
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;
        public CurrentConditionDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            this.weatherData.RegisterObserver(this);
        }
        public string Display()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Welcome to Current Condition Display...");
            sb.AppendLine("温度："+this.temperature.ToString());
            sb.AppendLine("湿度：" + this.humidity.ToString());
            sb.AppendLine("气压：" + this.pressure.ToString());
            return sb.ToString();
        }
        public void Update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }
    }
}
