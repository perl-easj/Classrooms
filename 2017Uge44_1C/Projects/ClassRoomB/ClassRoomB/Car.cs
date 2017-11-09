namespace ClassRoomB
{
    public class Car
    {
        private string _brand;
        private string _imageSource;
        private string _licensePlate;

        private string _color;
        private int _seats;
        private int _price;

        public Car(string licensePlate, string brand, string imageSource, string color, int seats, int price)
        {
            _brand = brand;
            _imageSource = imageSource;
            _color = color;
            _seats = seats;
            _price = price;
            _licensePlate = licensePlate;
        }

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

        public override string ToString()
        {
            return $"{Brand} costs {Price}, has {Seats} seats";
        }
    }
}