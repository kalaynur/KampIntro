using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            //sayi1'in çıktısı 30 olur çünkü int deger tipidir sayi2 umrunda değildir
            // ona eşitlediğin sıradaki değeri önemlidir

            int[] sayilar1 = new int[] { 10, 20, 30, };
            int[] sayilar2 = new int[] { 100, 200, 300, };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] çıktısı 999 olur çünkü arrayler referans tipidir.
            //çünkü sayilar2, sayilar2 olarak değil bir adres olarak değerlendirir.
            //bir süre sonra garbage collector sayilar1 dizisini çöpe yollar.
            //çünkü hiçbir durumu yoktur.
            // int, decimal, float, double, bool(0,1)= deger tipleridir.
            // array, class, interface ise referans tipleridir.


        }
    }
}