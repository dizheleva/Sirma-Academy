internal class Program
{
    private static void Main(string[] args)
    {
        int floors = int.Parse(Console.ReadLine());
        int aparatments = int.Parse(Console.ReadLine());

        for (int f = floors; f > 0; f--)
        {
            string floor = "";

            for (int a = 0; a < aparatments; a++)
            {
                char type;

                if (f == floors)
                {
                    type = 'L';
                }
                else if (f % 2 == 0)
                {
                    type = 'O';
                }
                else
                {
                    type = 'A';
                }

                floor += $"{type}{f}{a} ";
            }

            Console.WriteLine(floor.Trim());
        }
    }
}