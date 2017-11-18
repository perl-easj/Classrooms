using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClassRoomC
{
    public class CarDetailsViewModel : INotifyPropertyChanged
    {
        private Car _domainObject;

        public CarDetailsViewModel(Car domainObject)
        {
            _domainObject = domainObject;
        }

        public Car DomainObject
        {
            get { return _domainObject; }
        }

        public string LicensePlate
        {
            get { return _domainObject.LicensePlate; }
        }

        public string Brand
        {
            get { return _domainObject.Brand; }
        }

        public string Model
        {
            get { return _domainObject.Model; }
        }

        public string Heading
        {
            get { return $"A {Brand} {Model}, costs {Price } kr."; }
        }

        public int Price
        {
            get { return _domainObject.Price; }
            set
            {
                _domainObject.Price = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Heading));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}