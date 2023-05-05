namespace KapasitasVendingMachine
{
    public class Kapasitas
    {
        public static int totalKapasitas<T, I>(T total, I max)
        {
            max = 6;
            total = 0;
            if (total < max)
            {
                total = total + 1;
            }
            else
            {
                Console.WriteLine("Vending machine penuh");
            }
            return total;
        }
    }
}