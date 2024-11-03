using _02.CarConstructors;

internal class Program
{
    private static void Main(string[] args)
    {
        int carsCount = int.Parse(Console.ReadLine());
        List<Car> cars = [];

        for (int i = 0; i < carsCount; i++)
        {
            Car car;

            string[] data = Console.ReadLine().Split(" ");
            string brand = data[0];

            if (data.Length > 1)
            {
                string model = data[1];
                if (data.Length > 2)
                {
                    int horsePower = int.Parse(data[2]);  
                    car = new Car(brand, model, horsePower);
                }
                else
                {
                    car = new Car(brand, model);
                }
            }
            else
            {
                car = new Car(brand);
            }            
            
            cars.Add(car);
        }
        
        foreach (Car car in cars)
        {
            Console.WriteLine(car.CarInfo());
        }
    }
}