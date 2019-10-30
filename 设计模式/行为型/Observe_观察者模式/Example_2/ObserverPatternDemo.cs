using System;
using System.Collections.Generic;
using System.Text;

namespace Observe_观察者模式.Example_2
{
    public class ObserverPatternDemo
    {
        public static void test() {
            WeatherData weather = new WeatherData();

            CurrentConditionDisplay _互联网 = new CurrentConditionDisplay(weather);
            CurrentConditionDisplay _手机端 =new CurrentConditionDisplay(weather);
            CurrentConditionDisplay _广播站 = new CurrentConditionDisplay(weather);
            CurrentConditionDisplay _报业 = new CurrentConditionDisplay(weather);
            CurrentConditionDisplay _广告商 = new CurrentConditionDisplay(weather);

            weather.SetMeasurements(40, 100, 9);

            weather.MeasurementsChanged();
        }
    }
}
