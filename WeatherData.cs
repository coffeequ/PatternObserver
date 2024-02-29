using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PatternObserver
{
    class WeatherData : ISubject
    {
        private List<IObserver> observers;

        private float temperature;

        private float humidity;

        private float pressure;

        private bool IsMagneticStorm;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void registerObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void notifyObserver()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                IObserver observer = observers[i];
                observer.update(temperature, humidity, pressure, IsMagneticStorm);
            }
        }

        private void getTemperature()
        {
            MessageBox.Show(temperature.ToString());
        }

        private void getHumidity()
        {
            MessageBox.Show(humidity.ToString());
        }

        private void getPressure()
        {
            MessageBox.Show(pressure.ToString());
        }

        private void measurementsChanged()
        {
            notifyObserver();
        }

        public void setMeasurements(float temperature, float humidity, float pressure, bool IsMagneticStorm)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            this.IsMagneticStorm = IsMagneticStorm;
            measurementsChanged();
        }
    }
}
