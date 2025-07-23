namespace Secure_Password_Evaluator;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        string specialChars = "!@#$%^&*";
        string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string lowerCase = "abcdefghijklmnopqrstuvwxyz";
        string numbers = "0123456789";
        int strength = 0;



        Console.WriteLine("Welcome to the great password security app in the world.\n");

        //Takes a password as input
        Console.WriteLine(@"Please type in your password:
    Be aware that your password must include the following:
    // Minimum length: 8 characters
    // Contains at least 1 uppercase letter
    // Contains at least 1 lowercase letter
    // Contains at least 1 number
    // Contains at least 1 special character (!@#$%^&*, etc.)");
        string password = Console.ReadLine();
        bool hasUpper = password.Any(char.IsUpper);
        bool hasLower = password.Any(char.IsLower);
        bool hasNumber = password.Any(char.IsDigit);
        bool hasSpecial = password.Any(c => specialChars.Contains(c));
        bool hasSpace = password.Any(char.IsWhiteSpace);
        if (password == null)
        {
            Console.WriteLine("Password cannot be empty or contain only spaces.");
            return;
        }

        Console.WriteLine(password);
        // Rules
        if (password.Length < 8)
        {
            Console.WriteLine("Minimum length: 8 characters");
        }
        if (hasUpper == false)
        {
            Console.WriteLine("Must contain at least 1 uppercase letter");
        }
        if (hasLower == false)
            //password, "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"))
        {
            Console.WriteLine("Must contain at least 1 lowercase letter");
        }
        if (hasNumber == false )
        {
            Console.WriteLine("Must contain at least 1 number");
        }
        if (hasSpecial == false)
        {
            Console.WriteLine("Must contain at least 1 special character (!@#$%^&*, etc.)");
        }
        if (password.Length >= 8) strength++;
        if (hasUpper) strength++;
        if (hasLower) strength++;
        if (password.Any(char.IsDigit)) strength++;
        // etc.
        Console.WriteLine($"Password strength: {strength}/5");

        if (strength == 0)
        {
            Console.WriteLine("Password is too weak.");
        }
    }
}