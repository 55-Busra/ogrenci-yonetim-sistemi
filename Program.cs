using System;
using System.Collections.Generic;

class Program
{
    static List<string> ogrenciler = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1- Öğrenci Ekle");
            Console.WriteLine("2- Öğrencileri Listele");
            Console.WriteLine("3- Öğrenci Sil");
            Console.WriteLine("4- Çıkış");
            Console.Write("Seçiminiz: ");

            int secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    OgrenciEkle();
                    break;
                case 2:
                    Listele();
                    break;
                case 3:
                    Sil();
                    break;
                case 4:
                    return;
            }
        }
    }

    static void OgrenciEkle()
    {
        Console.Write("Öğrenci adı: ");
        string ad = Console.ReadLine();
        ogrenciler.Add(ad);
        Console.WriteLine("Eklendi!");
    }

    static void Listele()
    {
        Console.WriteLine("\nÖğrenciler:");
        foreach (var o in ogrenciler)
        {
            Console.WriteLine(o);
        }
    }

    static void Sil()
    {
        Console.Write("Silinecek öğrenci adı: ");
        string ad = Console.ReadLine();
        ogrenciler.Remove(ad);
        Console.WriteLine("Silindi!");
    }
}