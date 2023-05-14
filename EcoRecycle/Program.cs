// See https://aka.ms/new-console-template for more information
using ArzaqLibrary;
using System.Linq;
using System.Runtime.CompilerServices;

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

        Console.WriteLine("");

        // Register user
        regForm.RegisterUser();

        // Membuat list material
        List<string> materials = new List<string>();

        // Membuat new variable materialInput
        MaterialInput materialInput = new MaterialInput();

        // Memanggil method InputMaterial
        materialInput.InputMaterial();

        Console.WriteLine("");

        // Print list
        materialInput.PrintMaterialList();

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();





    }
}
