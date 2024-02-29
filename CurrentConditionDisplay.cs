using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PatternObserver
{
    class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private float temperature;

        private float humidity;

        private float pressure;

        private bool IsMagneticStorm;

        private ISubject weatherData;

        public CurrentConditionDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void display()
        {
            MessageBox.Show($"Текущая температура: {temperature} F градусов и {humidity}% влажности, давление составит: {pressure}, магнитная буря: {IsMagneticStorm}");
        }

        public void update(float temp, float humidity, float pressure, bool IsMagneticStorm)
        {
            temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            this.IsMagneticStorm = IsMagneticStorm;
            display();
        }
    }
}
