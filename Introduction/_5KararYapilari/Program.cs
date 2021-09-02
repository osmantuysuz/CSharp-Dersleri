using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             Karar Yapıları:

            1- İf - Else: bool değer döndürür buna göre işlem yapılır.
            2- Switch - Case: İf - Else yapısından daha yeteneksizdir.
             */

            //İf-Else Örnek
            string kullaniciAdi = "Admin";
            string parola = "123";

            Console.Write("Kullanıcı Adı Giriniz: ");
            string ka = Console.ReadLine();
            Console.Write("Parola Giriniz: ");
            string prl = Console.ReadLine();

            if (ka == kullaniciAdi && prl == parola)
                Console.WriteLine("Başarılı bir şekilde giriş yapıldı. \nHoşgeldin {0}", ka);
            else
                Console.WriteLine("Kullanıcı adı veya parola yanlış.");

            Console.Clear();


            //Girilen iki sayıdan hangisinin küçük olduğunu gösteren program
            int sayi1, sayi2;
            Console.Write("İlk sayıyı giriniz: ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı giriniz: ");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            if (sayi1>sayi2)
                Console.WriteLine("{0} sayısı {1} sayısından büyüktür.", sayi1,sayi2);
            else if(sayi1 == sayi2)
                Console.WriteLine("{0} sayısı {1} sayısına eşittir.", sayi1, sayi2);
            else
                Console.WriteLine("{0} sayısı {1} sayısında. büyüktür.", sayi2, sayi1);

            Console.Clear();

            // Switch - Case Örnek
            // Kullanıcının girdiği mevsimde bulunan ayları listeleyen uygulamayı yazınız.
            Console.Write("Hangi mevsimdesiniz: ");
            string mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "yaz": Console.WriteLine("Haziran Temmuz Ağustos"); break;
                case "ilkbahar": Console.WriteLine("Mart Nisan Mayıs"); break;
                case "sonbahar": Console.WriteLine("Eylül Ekim Kasım"); break;
                case "kış": Console.WriteLine("Aralık Ocak Şubat"); break;
                default: Console.WriteLine("Geçerli bir mevsim girmediniz!!!"); break;
            }

            Console.ReadKey();
        }
    }
}
