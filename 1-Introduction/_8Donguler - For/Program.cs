using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Donguler___For
{
    class Program
    {
        static void Main(string[] args)
        {
            //For döngüsü bir başlangıç, bitiş ve artış miktarı olarak yazılan bir döngüdür.

            //Kullanıcının girdiği sayının faktöriyelini hesaplayan program yazalım. 
            int girilenSayi, faktoriyel = 1;

            Console.Write("Pozitif bir sayı giriniz: ");
            girilenSayi = int.Parse(Console.ReadLine());

            if(girilenSayi==0)
                Console.WriteLine("0 sayısının faktöriyeli: 1");
            else
            {
                for (int i = girilenSayi; i > 0; i--)
                {
                    faktoriyel *= i;
                }
                Console.WriteLine("{0} sayısının faktöriyeli: {1}", girilenSayi, faktoriyel);
            }
       
            Console.ReadLine();
        }
    }
}