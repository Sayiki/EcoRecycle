﻿public class Program
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

        try
        {
            Console.WriteLine("Masukkan nomor menu : ");
            string inputMenu = Console.ReadLine();
            int inputMenuInt = Convert.ToInt32(inputMenu);
            switch (inputMenuInt)
            {
                case 1:
                    Console.WriteLine("Jenis sampah di vending machine");
                    break;
                case 2:
                    Console.WriteLine("Edit profil");
                    break;
                case 3:
                    Console.WriteLine("Lihat poin");
                    break;
                default:
                    Console.WriteLine("Nomor menu tidak tersedia");
                    break;
            }
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}