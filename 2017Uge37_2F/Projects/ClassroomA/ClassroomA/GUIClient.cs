using System;

namespace ClassroomA
{
    public class GUIClient
    {
        private string _message;

        public GUIClient(string message)
        {
            _message = message;
        }

        // Matches type of TemperatureMonitor.TemperatureChanged
        public void TemperatureHasChanged(double temperature)
        {
            Console.WriteLine($"{_message} : {temperature:0.00}");
        }

        public void TemperatureHasChanged2(int temperature)
        {
            Console.WriteLine($"{_message} : {temperature:0.00}");
        }
    }
}