namespace ClassroomA
{
    public class Car
    {
        private string _licensePlate;
        private int _price;
        private bool _readyForSale;

        public Car(string licensePlate, int price)
        {
            _licensePlate = licensePlate;
            _price = price;
            _readyForSale = false;
        }

        public string LicensePlate
        {
            get { return _licensePlate; }
        }

        public int Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public bool ReadyForSale
        {
            get { return _readyForSale; }
            set { _readyForSale = value; }
        }

        public override string ToString()
        {
            return $"{LicensePlate}, price is {Price}, ready for sale: {ReadyForSale}";
        }
    }
}