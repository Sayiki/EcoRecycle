﻿using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Reflection;

enum MenuState
{
    MainMenu,
    JenisSampahMenu
}

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
                    JenisSampahDiVendingMachine();
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

            // Display update profile data
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

    private static MenuState currentState = MenuState.MainMenu;
    private static void JenisSampahDiVendingMachine()
    {       
        // List jenis sampah di vending machine
        List<string> sampahList = new List<string> { "Organik", "Anorganik", "Sampah Berbahaya" };

        while (true)
        {
            Console.Clear();

            if (currentState == MenuState.MainMenu)
            {
                Console.WriteLine("Jenis sampah di vending machine:");
                for (int i = 0; i < sampahList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {sampahList[i]}");
                }
                Console.WriteLine("0. Kembali ke menu utama");
                Console.WriteLine();
                Console.Write("Pilih nomor jenis sampah: ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out int selectedOption))
                {
                    if (selectedOption >= 1 && selectedOption <= sampahList.Count)
                    {
                        Console.Clear();
                        Console.WriteLine($"Anda memilih jenis sampah: {sampahList[selectedOption - 1]}");
                        Console.WriteLine("Tekan Enter untuk kembali ke menu utama...");
                        Console.ReadLine(); // Tunggu input Enter
                    }
                    else if (selectedOption == 0)
                    {
                        break; // Keluar dari perulangan dan kembali ke menu utama
                    }
                    else
                    {
                        Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Input tidak valid. Silakan coba lagi.");
                    Console.ReadLine();
                }
            }
        }
    }

}