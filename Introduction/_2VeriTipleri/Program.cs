using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2VeriTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Veri Tipleri

            1- Tamsayı Veri Tipleri: İçersinde sadece tamsayı barındıran tiplerdir.
                1.1 byte:0 ile 255 arasında değer alır. Ram'de 1 byte yer tutar. En küçük tamsayı tipidir. 
                1.2 sbyte: -128 ile 127 arasında değer alır. Ram'de 1 byte yer tutar.  
                1.3 short: -32768 ile 32767 arasında değer alır. Ram'de 2 byte yer tutar.
                1.4 ushort: 0 ile 65535 arasında değer tutar.
                1.5 int: -1.14 milyar ile 1.14 milyar arasında değer alır. Ram'de 4 byte yer tutar. Varsayılan tamsayı tipidir. 
                1.6 uint: 0 ile 2.28 milyar arasında değer alır. Ram'de 4 byte yer tutar. 
                1.7 long: -çok ile +çok araında değer alır. Ram'de 8 byte yer tutar. Tamsayı tiplerinin en büyüğüdür.
                1.8 ulong: 0 ile +çok araında değer alır. Ram'de 8 byte yer tutar. 

            2- Ondalıklı Veri Tipleri
                2.1 float: En küçük ondalıklı tiptir. Uzunluk, ölçü birimlerinde kullanılır. 
                2.2 double: Matematiksel işlemlerde kullanılır. Varsayılan ondalıklı tipidir. 
                2.3 decimal: Ondalıklı sayıların en büyüğüdür. Parasal işlemlerde kullanılır. Ram'de 16 byte yer tutar. 

            3- Mantıksal Veri Tipi
                3.1 bool: Ram'de 1 bitlik yer kaplar. İçerisinde sadece 1 veya 0 barındırır. True ya da false.

            4- Metinsel Veri Tipleri
                4.1 char: İçerisinde sadece bir karakter barındırır. 'A', '7', 'Z' gibi örneklerdir. 
                4.2 string: En çok kullanılan tiptir. İçerisinde metinsel ifade barındırır. "Merhaba Dünya", "Osman TÜYSÜZ"

            5- Object(Nesne) Veri Tipi
                5.1 object: Özel bir tiptir. Bütün tipleri içerisinde barındırabilir.
            
            Peki object bütün veri tiplerini tutabilirken biz sadece object veri tipini kullanmıyor. Optimizasyon için. Uygulamaları sadece Object veri tipi ile yazarsak depolamada fazla alan kullanırız. Her veriyi ona uygun veri tipi ile tutmalıyız ki belleği en optimum şekilde kullanabilelim.
            
            Değişken Tanımlama
                veriTipi degiskenAdı = değer; olarak kullanılır.
            */

            //Örnek değişken tanımlamaları
            byte sayi = 5;
            char karakter = 'a';
            bool mantiksal = false;
            double ondalikli = 14.5;
            string isim = "osman TÜYSÜZ";
            object nesne1 = 4;
            object nesne2 = 'A';
            object nesne3 = false;
            object nesne4 = 14.5;
            object nesne5 = "Osman TÜYSÜZ";
        }
    }
}
