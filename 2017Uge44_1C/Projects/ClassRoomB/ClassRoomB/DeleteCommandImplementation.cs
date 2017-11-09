using System;
using System.Windows.Input;

namespace ClassRoomB
{
    public class DeleteCommandImplementation : ICommand
    {
        private CarCollection _carCollection;

        public DeleteCommandImplementation(CarCollection carCollection)
        {
            _carCollection = carCollection;
        }

        public bool CanExecute(object parameter)
        {
            return _carCollection.SelectedCar != null;
        }

        public void Execute(object parameter)
        {

            _carCollection.DeleteCar(_carCollection.SelectedCar.LicensePlate);
        }

        public event EventHandler CanExecuteChanged;

    }
}