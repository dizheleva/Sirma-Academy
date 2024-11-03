internal class Program
{
    private static void Main(string[] args)
    {
        string password = Console.ReadLine();

        ValidatePassword(password);
    }

    private static void ValidatePassword(string password)
    {
        bool isValid = true;

        if (!HasValidCharacterLength(password))
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
            isValid = false;
        }

        if (!IsAlphanumeric(password))
        {
            Console.WriteLine("Password must contain only letters and digits");
            isValid = false;
        }

        if (!HasTwoDigits(password))
        {
            Console.WriteLine("Password must have at least 2 digits");
            isValid = false;
        }

        if (isValid)
        {
            Console.WriteLine("Password is valid");
        }
    }

    private static bool HasTwoDigits(string password)
    {
        int digitCount = 0;

        foreach (char character in password)
        {

            if (Char.IsDigit(character))
            {
                digitCount++;
            }
        }

        if (digitCount >= 2)
        {
            return true;
        }

        return false;
    }

    private static bool IsAlphanumeric(string password)
    {
        foreach (char character in password)
        {            
            if (!Char.IsLetterOrDigit(character))
            {
                return false;
            }
        }

        return true;
    }

    private static bool HasValidCharacterLength(string password)
    {
        if (password.Length < 6 || password.Length > 10)
        {
            return false;
        }

        return true;
    }
}