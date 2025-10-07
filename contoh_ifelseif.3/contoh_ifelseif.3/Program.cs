using System;

namespace contoh_ifelseif._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan umur: ");
            int umur = int.Parse(Console.ReadLine());

            if (umur < 5)
            {
                Console.WriteLine("Tiket Gratis.");
            }
            else if (umur <= 12)
            {
                Console.WriteLine("Harga Tiket: Rp 20.000");
            }
            else if (umur <= 60)
            {
                Console.WriteLine("Harga Tiket: Rp 50.000");
            }
            else
            {
                Console.WriteLine("Harga Tiket: Rp 30.000 (Diskon Lansia)");
            }
        }
    }
}

