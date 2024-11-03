using _01.CarInfo;

internal class Program
{
    private static void Main(string[] args)
    {
        int carsCount = int.Parse(Console.ReadLine());
        Car[] cars = new Car[carsCount];

        for (int i = 0; i < carsCount; i++)
        {
            string[] data = Console.ReadLine().Split(" ");

            cars[i] = new Car();
            cars[i].Brand = data[0];
            cars[i].Model = data[1];
            cars[i].HorsePower = int.Parse(data[2]);
        }

        foreach (Car car in cars)
        {
            Console.WriteLine(car.CarInfo());
        }
    }
}