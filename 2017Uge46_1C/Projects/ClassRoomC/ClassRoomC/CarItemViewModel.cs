namespace ClassRoomC
{
    public class CarItemViewModel
    {
        private Car _domainObject;

        public CarItemViewModel(Car domainObject)
        {
            _domainObject = domainObject;
        }

        public Car DomainObject
        {
            get { return _domainObject; }
        }

        public string ImageSource
        {
            get { return _domainObject.ImageSource; }
        }

        public string Description
        {
            get
            {
                return $"{_domainObject.Brand} ({_domainObject.LicensePlate})";
            }
        }
    }

}