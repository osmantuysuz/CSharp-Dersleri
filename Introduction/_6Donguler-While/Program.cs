using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Donguler_While
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Döngüler: Belirli bir kod bloğunu belirli bir koşula göre tekrar tekrar çalıştırmayı sağlayan yapılardır.
            4 tane döngü çeşiti vardır. 

            1- While Döngüsü
            2- Do-While Döngüsü
            3- For Döngüsü
            4- Foreach Döngüsü             
             */

            //Ekrana 100 kere merhaba dünya yazdırma.
            int sayi = 100;
            while (sayi > 0)
            {
                Console.WriteLine("Merhaba Dünya - {0}", sayi);
                sayi--;
            }


            //1 ile 100 arasındaki çift sayıların toplamını ekrana yazdıran program
            int toplam = 0, sayi1 = 100;
            while (sayi1%2==0 && sayi1 > 0)
            {
                toplam = sayi1 + toplam;
                sayi1=sayi1-2;
            }
            Console.WriteLine("Toplam: {0}", toplam);
            Console.ReadLine();
        }
    }
}
