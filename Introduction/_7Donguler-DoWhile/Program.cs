using System;

namespace _7Donguler_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // Koşul ne olursa olsun en az bir kere çalışır daha sonrasında koşula bakarak devam eder.
            // While'dan farkı while koşul sağlandıkça çalışır. Yanlış ise direk çıkar. Ama do While ile kod en az bir kere çalışır.


            //Sayı tahmin oyunu yapalım.
            Random random = new Random();

            int tutulanSayi = random.Next(1, 100), deneme=0, girilenDeger=0;
            Console.WriteLine("1 ile 100 arasında rastgele bir sayı tuttum. Bakalım kaç denemede tahmin edebileceksin.");

            do
            {
                Console.Write("Tahminin nedir: ");
                girilenDeger = int.Parse(Console.ReadLine());
                deneme++;
            } while (tutulanSayi != girilenDeger);

            Console.WriteLine("Tebrikler doğru tahmin ettin.");
            Console.WriteLine("{0}. denemede bildin!", deneme);
            Console.ReadLine();
        }
    }
}
