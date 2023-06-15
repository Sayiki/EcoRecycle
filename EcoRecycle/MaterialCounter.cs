using System;
using System.Collections.Generic;

public class MaterialCounter
{
    // Dictionary untuk menyimpan jumlah sampah
    private Dictionary<string, int> jumlahSampah = new Dictionary<string, int>();

    // Konstruktor
    public MaterialCounter()
    {
        // Menambahkan entri "total" dengan nilai awal 0
        jumlahSampah.Add("total", 0);
    }

    // Method untuk menghitung jumlah sampah
    public void Count(string jenisSampah)
    {
        // Jika jenis sampah sudah ada di dalam tabel, tambahkan 1 ke jumlahnya
        if (jumlahSampah.ContainsKey(jenisSampah))
        {
            jumlahSampah[jenisSampah]++;
        }
        // Jika jenis sampah belum ada di dalam tabel, tambahkan jenis sampah dan set jumlahnya ke 1
        else
        {
            jumlahSampah.Add(jenisSampah, 1);
        }

        // Tambahkan 1 ke total jumlah sampah
        jumlahSampah["total"]++;
    }

    // Method untuk menampilkan hasil jumlah sampah
    public void Display()
    {
        Console.WriteLine("\nJumlah Sampah:");
        foreach (KeyValuePair<string, int> item in jumlahSampah)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    public object GetJumlahSampah()
    {
        throw new NotImplementedException();
    }
}
