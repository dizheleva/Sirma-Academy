namespace HotelRoomReservationSystem
{
    using System;

    public abstract class User
    {
        private string username;
        private string password;
        public User(string username, string password) 
        {
            this.Username = username;
            this.Password = password;
        }

        public string Username
        {
            get => this.username;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A type should not be empty.");
                }
                this.username = value;
            }
        }

        public string Password
        {
            get => this.password;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A type should not be empty.");
                }
                this.password = value;
            }
        }
    }
}
