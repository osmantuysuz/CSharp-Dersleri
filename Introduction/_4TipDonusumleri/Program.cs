using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Tip Dönüşümleri: Bir tipteki değeri balka bir tiper dönüştürmeyi saplar. 

            1- Cast:
                1.1 Implicit Cast: Kendi kendine dönüşüm işlemi yapar. Bizim ayrıca dönüşüm işlemi yapmamıza gerek yoktur. 
                    Not: Kesinlikle bir tip diğer tipin içerisinde barınabiliyorsa işlem gerçekleşir.
                    short a = 350;
                    int b = a; Burada hata vermez. İnt daha büyük bir alana sahiptir ve short a değişkenini içerinde barındırabilir. 
                1.2 Explicit Cast: Benzer tipler arasında dönüşüm yapmayı sağlar. Bu kez dönüşüm işlemini biz yaparız.
                    int sayi = 214;
                    byte  c = sayi;  //Burada hata verir. O yüzden alttaki kodu yazarız.
                    byte c = (byte)214; //Bu şekilde hata vermez. Ama 214'ün değerini byte olarak alır. 0-255 arasında alıyordu. İçerisinde barınabilir.
            
            2- Convert ve Parse: Cast işleminin yetersiz olduğu durumlarda kullanılır. Metinsel bir ifadeyi cast yöntemi ile bir tipe dönüştüremeyiz.
                2.1 Parse: Sadece string bir değeri başka bir tipe dönüştürmeyi sağlar. Her tipin içerisinde Parse metodu bulunur. Convert'e göre daha performanslıdır fakat daha yetersizdir. 
                    string metin = "5";
                    int sayi = metin; //Hata verir.
                    int sayi = (int)metin; //Cast yöntemi yetersiz kalır. 
                    int sayi = int.Parse(metin); //Parse ile string olan metin değişkenini int olarak değiştirdik.
                2.2 Convert: Herhangi bir tipi herhangi bir tipe dönüştürür. Parse göre daha yetenekli fakat daha performanssızdır. 
                    decimal sayi1 = 10.85m;
                    int sayi2 = sayi1; //Hata verir. 
                    int sayi2 = Convert.ToInt32(sayi1); // Başarılı. Dönüşüm tamam. 
             */

            //Kullanıcıdan alacağımız iki sayının toplamını bulan program yazalım.
            string sayi1, sayi2;
            int toplam, s1, s2;

            Console.Write("1. Sayıyı Giriniz: ");
            sayi1 = Console.ReadLine();
            Console.Write("2. Sayıyı Giriniz: ");
            sayi2 = Console.ReadLine();

            s1 = int.Parse(sayi1);
            s2 = Convert.ToInt32(sayi2); //Hem parse ile hem convert ile string olan sayıları int'e çevirdik.

            toplam = s1 + s2;

            Console.Write("Sayıların Toplamı: " + toplam);
            Console.ReadLine();
        }
    }
}
