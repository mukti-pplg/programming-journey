using System;

namespace array_contoh2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // membuat array 1 dimensi dua type data string dan integer
            // nama siswa dan umur

            string[] nama = new string[5];
            int[] umur = new int[5];

            // input data ke array
            Console.Write(" Input Nama Siswa ke 1:");
            nama[0] = Console.ReadLine();
            Console.Write(" Input umur siswa ke 1:");
            umur[0] = int.Parse(Console.ReadLine());
            Console.Write(" Input Nama Siswa ke 2:");
            nama[1] = Console.ReadLine();
            Console.Write(" Input umur siswa ke 2:");
            umur[1] = int.Parse(Console.ReadLine());
            Console.Write(" Input Nama Siswa ke 3:");
            nama[2] = Console.ReadLine();
            Console.Write(" Input umur siswa ke 3:");
            umur[2] = int.Parse(Console.ReadLine());
            Console.Write(" Input Nama Siswa ke 4:");
            nama[3] = Console.ReadLine();
            Console.Write(" Input umur siswa ke 4:");
            umur[3] = int.Parse(Console.ReadLine());
            Console.Write(" Input Nama Siswa ke 5:");
            nama[4] = Console.ReadLine();
            Console.Write(" Input umur siswa ke 5:");
            umur[4] = int.Parse(Console.ReadLine());

            // menampilkan data array
            Console.WriteLine("\n Data siswa yang telah diinputkan adalah :");
            // dalam bentuk tabel
            Console.WriteLine(" No\tNama\tUmur");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1.\t{0}\t{1}", nama[0], umur[0]); 
            Console.WriteLine("2.\t{0}\t{1}", nama[1], umur[1]);
            Console.WriteLine("3.\t{0}\t{1}", nama[2], umur[2]);
            Console.WriteLine("4.\t{0}\t{1}", nama[3], umur[3]);
            Console.WriteLine("5.\t{0}\t{1}", nama[4], umur[4]);











        }
    }
}
