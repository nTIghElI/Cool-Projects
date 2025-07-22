namespace Secure_Password_Evaluator;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");




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
        Console.WriteLine(password);
        namespace Secure_Password_Evaluator;

        class Program
        {
            static void Main(string[] args)
            {
                // Console.WriteLine("Hello, World!");
                
                Console.WriteLine("Welcome to the great password security app in the world.");
                
                string password = Console.ReadLine();
                if (password == null)
                {
                    Console.WriteLine("Password cannot be empty or contain only spaces.");
                    return;
                }
                
                // Rules
                if (password.Length < 8)
                {
                    Console.WriteLine("Minimum length: 8 characters");
                }
                else if (!string.ContainsAny(password, "A", "B", "C"))
                {
                    Console.WriteLine("Must contain at least 1 uppercase letter");
                }
                else if (!string.ContainsAny(password, "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"))
                {
                    Console.WriteLine("Must contain at least 1 lowercase letter");
                }
                else if (!string.ContainsAny(password, "0"-"9"))
                {
                    Console.WriteLine("Must contain at least 1 number");
                }
                else if (!string.ContainsAny(password, "!@#$%^&*"))
                {
                    Console.WriteLine("Must contain at least 1 special character (!@#$%^&*, etc.)");
                }
                
                int strength = password
                {
                    Length,
                    Uppercase,
                    Lowercase,
                    Number,
                    SpecialCharacter
                };

                if (strength == 0)
                {
                    Console.WriteLine("Password is too weak.");
                }
            }
        }
        
    }
}
