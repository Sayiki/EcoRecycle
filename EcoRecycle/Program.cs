using System;
using System.Collections.Generic;
using TUBES_KPL_2023;

class Program
{   
        static void Main(string[] args)
        {
        // Membuat objek MaterialCounter
        MaterialCounter counter = new MaterialCounter();

        // Meminta pengguna memasukkan sampah, ketik 'exit' untuk keluar
        string ans = "";
        while (ans != "exit")
        {
            
            Console.Write("Masukkan sampah (ketik 'exit' untuk keluar): ");
            ans = Console.ReadLine();

            if (ans != "exit")
            {
                // Memanggil method Count pada objek MaterialCounter
                counter.Count(ans);
            }
        }

        // Menampilkan hasil jumlah sampah
        counter.Display();



        // Tunggu user menekan tombol sebelum menutup program
        Console.ReadKey();
            Logout logout = new Logout();
                string input;

            do
            {
                Console.Write("Masukkan input: ");
                input = Console.ReadLine();
                logout.ProcessInput(input);

            } while (logout.currentState != Logout.State.LoggingOut);
                Console.ReadLine();
        }
        
}

