using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Donguler_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Foreach döngüsü
            iki önemli kuralı vardır. 
            1- Sadece ileri gider.
            2- Readonly'dir. Sadece okunabilir. Yani koleksiyon içerisindeki elemana değer ataması yapılamaz. Dizi içerisinde gezmeye yarar.

            Yazılışı
            foreach(elemanTipi degiskenİsmi in kolleksiyon)
            {
                işlemler
            }
             */

            char[] karakterler = { 'o', 's', 'm', 'a', 'n' };

            foreach (var karakter in karakterler)
            {
                Console.Write(karakter);
            }


            //Kullanıcıdan belirttiği sayıda isimler girmesini sağlayalım. Daha sonra bir ismi aradığında girdiği veriler arasında kaç tane olduğunu gösterelim.
            int girilenSayi, sayac=0;
            string aranacakIsim;
            
            Console.Write("Kaç adet isim girmek istiyorsunuz: ");
            girilenSayi = int.Parse(Console.ReadLine());
            Console.WriteLine("Şimdi {0} ismi girmeye başlıyoruz.", girilenSayi);

            string[] isimler = new string[girilenSayi];

            for (int i = 0; i < isimler.Length; i++)
            {
                Console.Write("{0}. ismi giriniz: ", i+1);
                isimler[i] = Console.ReadLine();
            }

            Console.Write("Şimdi ise arayacağınız ismi girin: ");
            aranacakIsim = Console.ReadLine();

            foreach (var isim in isimler)
            {
                if (isim == aranacakIsim)
                {
                    sayac++;
                }
            }

            Console.WriteLine("{0} ismi girdiğiniz listede {1} adet vardır.", aranacakIsim, sayac);

            Console.ReadLine();
        }
    }
}
