namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance;

        private static bool isConnected;

        private static readonly object padlock = new object();

        private Singleton()
        {
            Console.WriteLine("Instance is created.");
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }

                return instance;
            }
        }

        public void Connect()
        {
            if (!isConnected)
            {
                Console.WriteLine("Connected to the database.");
                isConnected = true;
            }
            else
            {
                Console.WriteLine("Already connected to the database.");
            }
        }

        public void Disconnect()
        {
            if (isConnected)
            {
                Console.WriteLine("Disconnected from the database.");
                isConnected = false;
            }
            else
            {
                Console.WriteLine("Already disconnected from the database.");
            }
        }
    }
}
