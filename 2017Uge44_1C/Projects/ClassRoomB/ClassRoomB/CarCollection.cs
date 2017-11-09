using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ClassRoomB
{
    public class CarCollection :INotifyPropertyChanged
    {
        private List<Car> _cars;
        private Car _selectedCar;
        private ICommand _deleteCommand;

        public CarCollection()
        {
            _cars = new List<Car>();

            _cars.Add(new Car("A1", "BMW", "Assets\\Cars\\BMW.jpg", "Black", 4, 240000));
            _cars.Add(new Car("B1", "Opel", "Assets\\Cars\\Opel.jpg", "Red", 5, 85000));
            _cars.Add(new Car("C1", "Toyota", "Assets\\Cars\\Toyota.jpg", "Blue", 5, 120000));
            _cars.Add(new Car("D1", "Volvo", "Assets\\Cars\\Volvo.jpg", "Blue", 5, 180000));

            _deleteCommand = new DeleteCommandImplementation(this);
        }

        public List<Car> Cars
        {
            get { return _cars; }
        }

        public ICommand DeleteCommand
        {
            get { return _deleteCommand; }
        }

        public Car SelectedCar
        {
            get { return _selectedCar; }
            set
            {
                _selectedCar = value;
                OnPropertyChanged();
            }
        }

        public void DeleteCar(string licensePlate)
        {
            // Delete car logic
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}