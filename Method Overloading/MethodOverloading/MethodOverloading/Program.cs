// See https://aka.ms/new-console-template for more information
using MethodOverloading;
using System;

Console.WriteLine("Hello, World!");


Matematik m = new Matematik();

// İNTEGER TOPLAMA İŞLEMİNİN ÇIKTILARI
Console.WriteLine(" int 2 parametre:" + m.Topla(4, 6));
Console.WriteLine(" int 3 parametre:" + m.Topla(4, 6, 3));


//DOUBLE TOPLAMA İŞLEMİNİN ÇIKTILARI
Console.WriteLine(" double 2 parametre: " + m.Topla(5.2, 7.3));
Console.WriteLine(" double 3 parametre: " + m.Topla(5.8, 7.4, 3.9));




//İNTEGER ÇARPMA İŞLEMİNİN ÇIKTILARI
Console.WriteLine("int 2 parametre: " + m.Carp(2, 7));
Console.WriteLine("int 3 parametre: " + m.Carp(2, 7, 3));


//DOUBLE ÇARPMA İŞLEMİNİN ÇIKTILARI
Console.WriteLine("double 2 parametre: " + m.Carp(3.7, 4.2));
Console.WriteLine("double 3 parametre: " + m.Carp(3.7, 4.2, 2.1));





//GARBAGE COLLECTOR(GC) NEDİR?
//Garbage Collector (GC), C# gibi managed dillerde (yönetilen dillerde) bellek yönetimini otomatik olarak gerçekleştiren bir sistemdir. Garbage Collector, programın çalışması sırasında gereksiz hale gelmiş veya kullanılmayan nesneleri tespit eder ve bu nesnelerin bellek alanlarını serbest bırakır. Bu sayede geliştiriciler, bellek yönetimi ile ilgili karmaşık işleri düşünmek zorunda kalmazlar. Garbage Collection, .NET Framework ve C# gibi dillerde, bellek yönetimini otomatikleştiren önemli bir özelliktir.



//GC NASIL ÇALIŞIR?
//Garbage Collector (GC) iki temel görevi yerine getirir:
// 1 :Nesneleri Takip Etme (Tracking Objects): GC, bellek tahsisi yapılan nesneleri sürekli olarak izler. Nesneler, bir değişken ya da bir nesne referansı ile ilişkilendirilmiş olduğunda "erişilebilir" olarak kabul edilir. Eğer bir nesne, programın çalışma süresi boyunca herhangi bir yerden erişilemiyorsa (örneğin, artık bir referansa sahip değilse), GC bu nesnenin kullanılmadığını ve belleği serbest bırakmak gerektiğini anlar.

// 2 :Belleği Temizleme(Memory Cleanup): GC, kullanılmayan nesneleri otomatik olarak bellekten temizler. Bu işlem, GC döngüsü sırasında gerçekleşir ve bu sayede bellekteki "çöpler" temizlenmiş olur. Çöp temizliği, bellek tıkanıklığını önler ve performansın düşmesini engeller.






//GENERİC CLASSLAR

//Generic Class'lar ve Generic Method'lar
//Generic yapılar, C#'ta belirli türlerle çalışırken, belirli bir veri türünü sabitlemeden daha esnek ve yeniden kullanılabilir kod yazmayı sağlar. Generic Class'lar ve Generic Method'lar, tür parametreleri kullanarak esnek programlama yapılmasına olanak tanır. Ayrıca Boxing ve Unboxing gibi kavramlarla da ilişkilidir.

//Generic Yapıların Avantajları
//Tür Güvenliği (Type Safety): Generic sınıflar ve metotlar, çalışma zamanında hataların oluşmasını engellemek için türlerin derleme zamanında doğruluğunu kontrol eder. Örneğin, bir List<int> sınıfı yalnızca int türünde öğeler alır ve tür uyumsuzluğu hatalarını derleme zamanında tespit edebiliriz.

//Kodun Yeniden Kullanılabilirliği: Generic yapılar, belirli bir türle sınırlı kalmaksızın aynı kodu farklı türlerle çalışacak şekilde yeniden kullanmanıza olanak tanır. Bu, kodun genel yapısının sadeleşmesini ve bakımının kolaylaşmasını sağlar.

//Performans İyileştirmeleri: Generic türler ile çalışma, Boxing ve Unboxing gibi işlemleri ortadan kaldırarak daha yüksek performans elde etmenize yardımcı olabilir. Çünkü tür dönüştürmeleri olmadığı için işlem daha hızlı gerçekleşir.

//İyi Dokümantasyon ve Okunabilirlik: Generic yapılar kullanarak, türlerin ne amaçla kullanıldığını belirleyebilirsiniz, böylece kodunuzun okunabilirliği artar.

//Generic Sınıf ve Metodlarla Esnek Programlama
//Generic Class: Tür parametreleri alabilen sınıflardır. Bu, farklı türlerle çalışmanıza imkan tanır.

//Generic Method: Tür parametreleri alabilen metotlardır. Bir metot, bir tür parametresi alır ve bu türle çalışarak esnek bir çözüm sağlar.