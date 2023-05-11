using KapasitasVendingMachine;
using System.Configuration;
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

        try
        {
            Console.WriteLine("Masukkan nomor menu : ");
            string inputMenu = Console.ReadLine();
            switch (inputMenu)
            {
                case "1":
                    Console.WriteLine("Jenis sampah di vending machine");
                    List<string> sampahList = new List<string> { "Organik", "Anorganik", "Sampah Berbahaya" };
                    foreach(string sampah in sampahList)
                    {
                        Console.WriteLine(sampah);
                    }
                    break;
                case "2":
                    Console.WriteLine("Edit profil");
                    //EditProfile();
                    break;
                case "3":
                    Console.WriteLine("Lihat poin");
                    break;
                case "4":
                    Console.WriteLine("Kapasitas vending machine: ");
                    Sampah.inputSampah<string>();
                    Sampah.inputSampah<string>();
                    Sampah.inputSampah<string>();
                    Sampah.inputSampah<string>();
                    Sampah.inputSampah<string>();
                    Sampah.inputSampah<string>();
                    Kapasitas.totalKapasitas();
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

    class Sampah
    {
        public static void inputSampah<T>()
        {
            string masukkanSampah = Console.ReadLine();
        }
    }

    /*private static void EditProfile()
    {
        Console.WriteLine("Silahkan masukkan data baru");
        
        Console.WriteLine("Nama: ");
        string nama = Console.ReadLine();

        Console.WriteLine("Alamant: ");
        string alamat = Console.ReadLine();

        Console.WriteLine("Nomor Telepon: ");
        string nomorTelepon = Console.ReadLine();

        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.AppSettings.Settings["nama"].Value = nama;
        config.AppSettings.Settings["alamat"].Value = alamat;
        config.AppSettings.Settings["nomorTelepon"].Value = nomorTelepon;
        config.Save(ConfigurationSaveMode.Modified);

        Console.WriteLine("Data profil berhasil diubah");
    }*/
}