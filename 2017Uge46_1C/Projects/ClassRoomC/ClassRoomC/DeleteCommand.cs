using System;
using System.Windows.Input;

namespace ClassRoomC
{
    public class DeleteCommand : ICommand
    {
        private CarCatalog _catalog;
        private CarMasterDetailsViewModel _viewModel;

        public DeleteCommand(CarCatalog catalog, CarMasterDetailsViewModel viewModel)
        {
            _catalog = catalog;
            _viewModel = viewModel;
        }

        public bool CanExecute(object parameter)
        {
            return _viewModel.ItemViewModelSelected != null;
        }

        public void Execute(object parameter)
        {
            // Delete from catalog
            _catalog.Delete(_viewModel.ItemViewModelSelected.DomainObject.LicensePlate);

            // Set selection to null
            _viewModel.ItemViewModelSelected = null;

            // Refresh the item list
            _viewModel.Refresh();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;
    }
}