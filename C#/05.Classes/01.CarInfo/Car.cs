namespace _01.CarInfo
{

    public class Car
    {
        private string brand;
        private string model;
        private int horsePower;

        public string Brand
        {
            get => brand;
            set => brand = value;
        }

        public string Model
        {
            get => model;
            set => model = value;
        }

        public int HorsePower
        {
            get => horsePower;
            set => horsePower = value;
        }

        public string CarInfo()
        {
            return $"The car is: {this.brand} {this.model} – {this.horsePower} HP.";
        }
    }
}
