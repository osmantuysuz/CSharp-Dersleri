using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Diziler:
            Aynı iş veya aynı amaç için içerisinde birden fazla değer barındırmayı sağlayan yapılardır.
            Diziler tanımlanırken ne kadar yer kaplayacakları yani içerisinde kaç tane eleman barındıracakları belli olsun diye tanımlama sırasında adet verilir.
            Her tipin dizisi olabilir. 
            Herhangi bir tipi dizi haline getirmek için tipin sonuna [] konulur. 
            Faydası ise aynı isim altında aynı tipe ait birden fazla değer tutabilir. 
            Dizilerde numaralandırma index olarak adlandırılır ve 0'dan başlar. Yani 1. sıradaki elemanın index numarası 0'dır.
            
            Tanımlama şekli 
            string[] isim = new string[değer];
            */

            string[] isimler = new string[10];
            int[] sayilar = new int[5];

            //Diziye nasıl değer atanır.
            isimler[4] = "Osman";
            sayilar[0] = 7;

            //Bir diğer atama yöntemi. 
            //Object Initilazier
            char[] karakterler = { 'o', 's', 'm', 'a', 'n', '7' };

            //Dizilerin boyutu nasıl arttırılır.
            Array.Resize(ref karakterler, 10);

            //Dizilerin boyutune öğrenmek.
            Console.WriteLine(karakterler.Length);

            //Herhangi bir dizinin boyutunu var olan boyutundan bir arttırmak istersenek ne yapmalıyız.
            Array.Resize(ref karakterler, karakterler.Length + 1);
            Console.WriteLine(karakterler.Length);

            //Kullanıcı bir sayı versin. Verdiği sayı kadar bir dizi tanımlayalım. Verdiği sayı adeti kadar değer girmesini sağlayıp bu değerleri ekranda gösterelim.
            int girilenSayi;

            Console.Write("Kaç adet veri gireceksiniz: ");
            girilenSayi = int.Parse(Console.ReadLine());

            string[] dizi = new string[girilenSayi];

            Console.WriteLine("Verilerinizi girmeye başlayabilirsiniz.");

            for (int i = 0; i <= dizi.Length - 1; i++)
            {
                Console.Write("{0}. veriyi giriniz:  ", i + 1);
                dizi[i] = Console.ReadLine();
            }

            Console.WriteLine("Veri girişi tamamlandı. Şimdi verilerini gösteriyorum.");

            for (int i = 0; i <= dizi.Length - 1; i++)
            {
                Console.WriteLine("{0}. eleman: {1}", i + 1, dizi[i]);
            }

            Console.ReadLine();
        }
    }
}
