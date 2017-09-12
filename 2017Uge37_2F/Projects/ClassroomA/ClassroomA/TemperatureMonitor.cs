using System;

namespace ClassroomA
{
    public class TemperatureMonitor
    {
        private Random _rng;
        private double _temperature;

        // Clients can attach a function to this event
        public event Action<double> TemperatureChanged;

        public TemperatureMonitor()
        {
            _rng = new Random();
            _temperature = 20.0;
            TemperatureChanged = null;

            MonitorDevice();
        }

        public void Poke()
        {
            MonitorDevice();
        }

        private void MonitorDevice()
        {
            // We assume GetTemperatureFromDevice retrieves
            // an actual temperature from some device, and
            // keep doing so at regular intervals
            double newTemperature = GetTemperatureFromDevice();

            if (Math.Abs(newTemperature - _temperature) > 0.1)
            {
                _temperature = newTemperature;
                OnTemperatureChanged();
            }
        }

        // Performs the actual invocation of delegates
        private void OnTemperatureChanged()
        {
            // If TemperatureChanged is not null, Invoke all of them
            TemperatureChanged?.Invoke(_temperature);
        }

        // Generate a new temperature randomly
        private double GetTemperatureFromDevice()
        {
            return _temperature + (_rng.NextDouble() * 20 - 10);
        }
    }
}