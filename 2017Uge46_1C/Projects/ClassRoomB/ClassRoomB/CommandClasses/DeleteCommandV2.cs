namespace ClassRoomB
{
    public class DeleteCommandV2 : CommandBase
    {
        private CarCatalog _carCatalog;

        public DeleteCommandV2(CarCatalog carCatalog)
        {
            _carCatalog = carCatalog;
        }

        public override bool CanExecute(object parameter)
        {
            return _carCatalog.SelectedCar != null;
        }

        public override void Execute(object parameter)
        {
            _carCatalog.Delete(_carCatalog.SelectedCar.LicensePlate);
        }
    }
}