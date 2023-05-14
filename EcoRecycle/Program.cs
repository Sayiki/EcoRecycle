using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

public class Program
{
    private static void Main(string[] args)
    {
        //homescreen
        Console.WriteLine("-----EcoRecycle-----");
        Console.WriteLine("Selamat Datang user");
        Console.WriteLine(" ");

        Console.WriteLine("Menu");
        Console.WriteLine("1.Jenis sampah di vending machine");
        Console.WriteLine("2.Edit profil");
        Console.WriteLine("3.Lihat Poin");
        Console.WriteLine("4.Kapasitas vending machine");
        Console.WriteLine("5.Logout");
    
        try
        {
            Console.WriteLine("Masukkan nomor menu : ");
            string inputMenu = Console.ReadLine();
            switch (inputMenu)
            {
                case "1":
                    Console.WriteLine("Jenis sampah di vending machine");
                    List<string> sampahList = new List<string> { "Organik", "Anorganik", "Sampah Berbahaya" };
                    foreach (string sampah in sampahList)
                    {
                        Console.WriteLine(sampah);
                    }
                    break;
                case "2":
                    Console.WriteLine("Edit profil");
                    EditProfil();
                    break;
                case "3":
                    Console.WriteLine("Lihat poin");
                    break;
                case "4":
                    Console.WriteLine("Kapasitas vending machine: ");
                    break;
                case "5":
                    Console.WriteLine("Logout");
                    break;
                default:
                    Console.WriteLine("Nomor menu tidak tersedia");
                    break;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void EditProfil()
    {
        try
        {
            // Load configuration from appsettings.json file
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            // Read current profile data from configuration
            string name = configuration.GetSection("Profile:Nama").Value;
            string email = configuration.GetSection("Profile:Email").Value;
            string password = configuration.GetSection("Profile:Password").Value;

            // Display current profile data
            Console.WriteLine("Profil kamu sekarang:");
            Console.WriteLine($"Nama: {name}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Password: {password}");

            // Prompt user to enter new profile data
            Console.Write("Masukkan nama baru: ");
            string newName = Console.ReadLine();
            Console.Write("Masukkan email baru: ");
            string newEmail = Console.ReadLine();
            Console.Write("Masukkan password baru: ");
            string newPassword = Console.ReadLine();

            // Update profile data in configuration
            configuration.GetSection("Profile:Name").Value = newName;
            configuration.GetSection("Profile:Email").Value = newEmail;
            configuration.GetSection("Profile:Password").Value = newPassword;

            // Save configuration changes to appsettings.json file
            var json = JsonConvert.SerializeObject(configuration.GetChildren().ToList(), Formatting.Indented);
            string path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");


            Console.WriteLine();
            Console.WriteLine("Data berhasil di ubah!");

            Console.WriteLine("Profil kamu sekarang:");
            Console.WriteLine($"Nama: {newName}");
            Console.WriteLine($"Email: {newEmail}");
            Console.WriteLine($"Password: {newPassword}");

            File.WriteAllText(path, json);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}