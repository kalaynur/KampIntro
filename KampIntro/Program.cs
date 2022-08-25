using System;

namespace KampIntro
{
    class Program
    {

        static void Main(string[] args)
        {
            //type safety c sharp gibi dillerde çok önemli bir noktalı virgül yokedeiblir

            string kategoriEtiketi = "Kategoriler";

            //bunu böyle tanımlamak her zaman daha iyi çünkü büyük bir projede 30 farklı yerde kategori olabilir
            //usta bunu değiştir dediğinde sıkıntı olabililr

            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }




            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


        }
    }

    }