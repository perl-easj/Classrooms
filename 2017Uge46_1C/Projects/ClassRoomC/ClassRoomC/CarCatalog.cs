using System.Collections.Generic;

namespace ClassRoomC
{
    public class CarCatalog
    {
        private List<Car> _cars;

        public List<Car> All
        {
            get { return _cars; }
        }

        public CarCatalog()
        {
            _cars = new List<Car>();
            _cars.Add(new Car("AX 32 501", "BMW", "318i", "Assets\\Cars\\BMW.jpg", 120000));
            _cars.Add(new Car("CP 73 001", "Volvo", "X40", "Assets\\Cars\\Volvo.jpg", 90000));
            _cars.Add(new Car("BK 55 734", "Opel", "Astra", "Assets\\Cars\\Opel.jpg", 65000));
            _cars.Add(new Car("AZ 60 922", "Toyota", "Auris", "Assets\\Cars\\Toyota.jpg", 75000));
        }

        public void Delete(string licensePlate)
        {
            for (int i = 0; i < _cars.Count; i++)
            {
                if (_cars[i].LicensePlate == licensePlate)
                {
                    _cars.RemoveAt(i);
                    return;
                }
            }
        }
    }
}