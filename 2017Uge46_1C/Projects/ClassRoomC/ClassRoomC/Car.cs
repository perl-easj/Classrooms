
namespace ClassRoomC
{
    public class Car
    {
        public Car(string licensePlate, string brand, string model, string imageSource, int price)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Model = model;
            ImageSource = imageSource;
            Price = price;
        }

        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string ImageSource { get; set; }
        public int Price { get; set; }
    }
}