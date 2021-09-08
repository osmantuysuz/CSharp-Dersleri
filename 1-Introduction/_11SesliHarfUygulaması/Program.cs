using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11SesliHarfUygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sesli Harf Bulma Uygulaması

            //1. Adım: Kullanıcıdan bir kelime istenmeli ve bu kelime bir değişkende tutulmalı.
            Console.WriteLine("Kelime: ");
            string kelime = Console.ReadLine();

            char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };

            int sayac = 0;
            foreach (char harf in kelime)
            {
                if (sesliHarfler.Contains(harf))
                    sayac++;
            }


            Console.WriteLine("{0} adet sesli harf içermektedir.", sayac);
            Console.ReadLine();
        }
    }
}
