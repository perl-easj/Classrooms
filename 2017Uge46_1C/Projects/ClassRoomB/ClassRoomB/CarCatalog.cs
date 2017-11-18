using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace ClassRoomB
{
    public class CarCatalog : INotifyPropertyChanged
    {
        #region Instance fields
        private ObservableCollection<Car> _cars;
        private Car _selectedCar;
        private DeleteCommand _deleteCommand;
        #endregion

        #region Constructor
        public CarCatalog()
        {
            _cars = new ObservableCollection<Car>();

            _cars.Add(new Car("A1", "BMW", "Assets\\Cars\\BMW.jpg", "Black", 4, 240000));
            _cars.Add(new Car("B1", "Opel", "Assets\\Cars\\Opel.jpg", "Red", 5, 85000));
            _cars.Add(new Car("C1", "Toyota", "Assets\\Cars\\Toyota.jpg", "Blue", 5, 120000));
            _cars.Add(new Car("D1", "Volvo", "Assets\\Cars\\Volvo.jpg", "Blue", 5, 180000));;

            _deleteCommand = new DeleteCommand(this);
        }
        #endregion

        #region Properties

        public ICommand DeletionCommand
        {
            get { return _deleteCommand; }
        }

        public ObservableCollection<Car> Cars
        {
            get { return _cars; }
        }

        public Car SelectedCar
        {
            get { return _selectedCar; }
            set
            {
                _selectedCar = value;
                OnPropertyChanged();
                _deleteCommand.RaiseCanExecuteChanged();
            }
        }
        #endregion

        #region Methods
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
        #endregion

        #region Code for OnPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}