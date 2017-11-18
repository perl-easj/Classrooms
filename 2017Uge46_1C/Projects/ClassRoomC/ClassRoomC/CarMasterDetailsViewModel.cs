using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClassRoomC
{
    public class CarMasterDetailsViewModel : INotifyPropertyChanged
    {
        private CarCatalog _catalog;
        private CarItemViewModel _itemViewModelSelected;
        private CarDetailsViewModel _detailsViewModel;

        public CarMasterDetailsViewModel()
        {
            _catalog = new CarCatalog();
            _itemViewModelSelected = null;
            _detailsViewModel = null;
        }

        public List<CarItemViewModel> ItemViewModelCollection
        {
            get { return CreateItemViewModelCollection(); }
        }

        public CarItemViewModel ItemViewModelSelected
        {
            get { return _itemViewModelSelected; }
            set
            {
                _itemViewModelSelected = value;

                if (_itemViewModelSelected == null)
                {
                    DetailsViewModel = null;
                }
                else
                {
                    DetailsViewModel = new CarDetailsViewModel(_itemViewModelSelected.DomainObject);
                }

                OnPropertyChanged();
            }
        }

        public CarDetailsViewModel DetailsViewModel
        {
            get { return _detailsViewModel; }
            private set
            {
                _detailsViewModel = value;
                OnPropertyChanged();
            }
        }

        public void Refresh()
        {
            OnPropertyChanged(nameof(ItemViewModelCollection));
        }

        private List<CarItemViewModel> CreateItemViewModelCollection()
        {
            List<CarItemViewModel> viewModels = new List<CarItemViewModel>();

            foreach (var c in _catalog.All)
            {
                viewModels.Add(new CarItemViewModel(c));
            }

            return viewModels;
        }

        #region OnPropertyChanged method
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        } 
        #endregion
    }
}