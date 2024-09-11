using System.Collections;

namespace WeatherStation_Observer_pattern_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class WeatherData : ISubject
    {
        private ArrayList observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
                observer.Update(temperature, humidity, pressure);
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        // Оповещение наблюдателей о появлении новых данных.
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }

    public interface ISubject
    {
        public void RegisterObserver(IObserver o);
        public void RemoveObserver(IObserver o);
        public void NotifyObservers();
    }

    public interface IObserver
    {
        // Данные передаваемые наблюдателям при изменении состояния субъекта.
        public void Update(float temp, float humidity, float pressure);
    }

    public interface IDisplayElement
    {
        public void Display();
    }
}
