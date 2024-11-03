namespace _02.CarConstructors
{

    public class Car
    {
        private string brand;
        private string model = "unknown";
        private int horsePower = -1;

        public string Brand
        {
            get => model;
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

        public Car(string brand)
        {
            this.brand = brand;
        }

        public Car(string brand, string model)
        {
            this.brand = brand;
            this.model = model;
        }

        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }

        public string CarInfo()
        {
            return $"The car is: {this.brand} {this.model} – {this.horsePower} HP.";
        }
    }
}
