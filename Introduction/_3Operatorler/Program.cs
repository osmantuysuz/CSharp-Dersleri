using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Operatörler

            1- Matematiksel Operatörler:
                * / - + Temel matematik işlemleri
                ++ Bir arttırma
                -- Bir azaltma
                % mod alma
                -= 
                += 
                /= 
                *= 
                Not: ++ veya -- operatörü değişkenin önünde(solunda) ise değişkeni önce işleme sokar daha sonra kullanırız. 
                Not: ++ veya -- operatörü değişkenin arkasında(sağında) ise değişkeni kullanır daha sonra işleme sokar.
             */

            int a = 5;
            int b = 0;
            b = ++a;
            Console.WriteLine(a);
            Console.WriteLine(b);
            //Sonuçlar a=6 b=6

            a = 5;
            b = 0;
            b = a++;
            Console.WriteLine(a);
            Console.WriteLine(b);
            //Sonuçlar a=6 b=5
            //Yani yukarıda yazdığımız nota bakarsak ilk kısımda a'yı bir arttırıp b'ye atadı. Ancak ikinci kısımdan önce a'yı b'ye atadı daha sonra a'nın değerini değiştirdi.

            int c = 100;
            c += 10;
            Console.WriteLine(c);
            c -= 10;
            Console.WriteLine(c);
            c /= 10;
            Console.WriteLine(c);
            c *= 10;
            Console.WriteLine(c);
            //Sonuçlar 110, 100, 10, 100

            a = 5;
            a = a++ + --a;
            Console.WriteLine(a);
            //Sonuç a = 10


            /*
            2- İlişkisel Operatörler:

            ! değil
            == eşit midir?
            != eşit değil değil mi?
            < Küçük mü 
            > Büyük mü
            <= Küçük eşit mi
            >= Büyük eşit mi
            !> Büyük değil mi
            !< Küçük değil mi
            
             
            3- Mantıksal Operatörler
            
            && ve
            || veya

             */


            Console.ReadLine();
        }
    }
}
