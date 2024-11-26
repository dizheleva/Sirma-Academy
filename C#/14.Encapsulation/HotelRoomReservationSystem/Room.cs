namespace HotelRoomReservationSystem
{
    public class Room
    {
        private int number;
        private RoomType type;
        private double price;
        private double cancelationFee;
        private bool isAvailable;

        public Room(int number, string type, double price, double cancelationFee)
        {
            this.Number = number;
            this.Type = type;
            this.Price = price;
            this.CancelationFee = cancelationFee;
            this.isAvailable = true;
        }

        public int Number
        {
            get => this.number;
            private set
            {
                if (value < 0 || value > 1000)
                {
                    throw new ArgumentException("Room number should be between 0 and 1000.");
                }
                this.number = value;
            }
        }

        public string Type
        {
            get => this.type;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A type should not be empty.");
                }
                this.type = value;
            }
        }

        public double Price
        {
            get => this.price;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price per night should be positive.");
                }
                this.price = value;
            }
        }

        public double CancelationFee
        {
            get => this.cancelationFee;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cancelation fee should be positive.");
                }
                this.cancelationFee = value;
            }
        }

        public bool IsAvailable
        {
            get => this.isAvailable;
            private set
            {                
                this.isAvailable = value;
            }
        }
    }
}
//Room number
// Type (e.g., Deluxe, Suite)
// Price per night
// Cancellation fee
// Status (e.g., available, booked)