using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukan angka pertama: ");
        double angkaPertama = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Masukan angka kedua: ");
        double angkaKedua = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Masukan angka ketiga: ");
        double angkaKetiga = Convert.ToDouble(Console.ReadLine());

        double rataRata = (angkaPertama + angkaKedua + angkaKetiga) / 3;

        Console.WriteLine("Rata-rata nya ialah: " + rataRata);
    }
}
