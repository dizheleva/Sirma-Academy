﻿namespace _02.OpenClosedPriciple.Discount
{
    public abstract class User
    {       
        public string UserName { get; set; }
        public string Password { get; set; }

        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public abstract double GetDiscount();
    }
}
