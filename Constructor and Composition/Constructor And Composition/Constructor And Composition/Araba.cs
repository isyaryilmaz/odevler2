using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_And_Composition
{
    public class Araba
    {
        public Kapı Kapı { get; set; }
        public Pencere Pencere { get; set; }
        public Kasa Kasa { get; set; }
        public Marka Marka { get; set; }
        public decimal Fiyat { get; set; }
        public Araba(Kapı kapı, Pencere pencere, Kasa kasa, Marka marka, decimal fiyat)
        {
            Kapı = kapı;
            Pencere = pencere;
            Kasa = kasa;
            Marka = marka;
            Fiyat = fiyat;
        }
        public void ArabaBilgisiYazdır()
        {
            Console.WriteLine($"Arabanın markası {Marka.Isim}, modeli {Marka.Model}, kapı sayısı {Kapı.Sayisi}, pencere sayısı {Pencere.Sayisi}, kasası {Kasa.Tipi}, fiyatı {Fiyat} TL’dir.");
        }

    }
}
