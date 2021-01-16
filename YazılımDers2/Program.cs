using System;

namespace YazılımDers2
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //kategoriEtiketi - değer tutucu (alias)

            //string kategoriEtiketi = "Kategoriler";
            //int ogrenciSayisi = 32000; //tamsayi
            //double faizOrani = 1.45; //ondalikli sayi
            //bool sistemeGirisYapmisMi = true; //dogru-yanlis
            //if (sistemeGirisYapmisMi == true)
            //{
            //    Console.WriteLine("Kullanıcı Ayarları butonu");
            //}
            //else
            //{
            //    Console.WriteLine("Giriş yap butonu");
            //}


            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun) 
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun < dolarBugun) 
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }
            
            
            
            
            
          

        }
    }
}
