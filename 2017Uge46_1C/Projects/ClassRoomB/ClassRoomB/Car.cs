namespace ClassRoomB
{
    public class Car
    {
        #region Instance fields
        private string _brand;
        private string _imageSource;
        private string _licensePlate;

        private string _color;
        private int _seats;
        private int _price;
        #endregion

        #region Constructor
        public Car(string licensePlate, string brand, string imageSource, string color, int seats, int price)
        {
            _brand = brand;
            _imageSource = imageSource;
            _color = color;
            _seats = seats;
            _price = price;
            _licensePlate = licensePlate;
        }
        #endregion

        #region Properties
        public string Brand
        {
            get { return _brand; }
        }

        public string ImageSource
        {
            get { return _imageSource; }
        }

        public string Color
        {
            get { return _color; }
        }

        public int Seats
        {
            get { return _seats; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public string LicensePlate
        {
            get { return _licensePlate; }
        } 
        #endregion
    }
}