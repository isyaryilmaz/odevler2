// See https://aka.ms/new-console-template for more information
using Constructor_And_Composition;

Console.WriteLine("Hello, World!");


Kapı kapı = new Kapı { Sayisi = 4 };
Pencere pencere = new Pencere { Sayisi = 4 };
Kasa kasa = new Kasa { Tipi = "Sedan" };
Marka marka = new Marka { Isim = "BMW", Model = "X5" };
Araba araba = new Araba(kapı, pencere, kasa, marka, 2000000);
araba.ArabaBilgisiYazdır();