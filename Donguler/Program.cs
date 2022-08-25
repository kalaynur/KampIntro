using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlama başlangıç için temel kurs";
            string kurs3 = "Java";

            //array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlama başlangıç için temel kurs", "Java","C#" };
            
            

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs + " " + "kurs ilerlemesi");
            }
            Console.WriteLine("SAYFA SONU - footer");
        }
    }

}