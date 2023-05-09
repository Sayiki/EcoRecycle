// See https://aka.ms/new-console-template for more information
using ArzaqLibrary;


class Program
{
    static void Main(string[] args)
    {
        // Get user input
        Console.WriteLine("Enter username: ");
        string username = Console.ReadLine();

        Console.WriteLine("Enter password: ");
        string password = Console.ReadLine();

        Console.WriteLine("Confirm password: ");
        string confirmPassword = Console.ReadLine();

        Console.WriteLine("Enter email: ");
        string email = Console.ReadLine();

        // Create registration form with appropriate data types
        Register<string> regForm = new Register<string>(username, password, confirmPassword, email);

        // Register user
        regForm.RegisterUser();

        // Wait for user input before closing console window
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
