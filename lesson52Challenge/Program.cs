namespace practice
{
    internal class program
    {
        private static string? username;
        private static string? password;

        private static void Main(string[] args)
        {
            Register();
            Login();
            Console.ReadKey();
        }

        private static void Register()
        {
            Console.WriteLine("To register, please enter a username.");
            username = Console.ReadLine();
            Console.WriteLine("Please enter a password.");
            password = Console.ReadLine();
            Console.WriteLine("Account created.");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++");
        }

        private static void Login()
        {
            Console.WriteLine("Please enter your username.");
            if (Console.ReadLine() != username)
            {
                Console.WriteLine("Username incorrect. Please restart the program.");
            }
            else
            {
                Console.WriteLine("Please neter your password.");
                if (Console.ReadLine() == password)
                {
                    Console.WriteLine($"Welcome, {username}.");
                }
                else
                {
                    Console.WriteLine("Incorrect password. Please restart the program.");
                }
            }
        }
    }
}