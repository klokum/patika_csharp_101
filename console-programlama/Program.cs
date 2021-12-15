using System;

namespace console_programlama
{
    class Program
    {
        //Main metodu Default public gelir.
        //static keyword'ü bir nesnesi yaratılmadan bu main metoduna ulaşabileceğimizi belirtir.
        //void ise bu metodun geri dönüş tipidir. Void olması bu metodun geriye değer döndürmeyen metot olduğunu gösterir.
        //Main tanınabilir bir fonsiyon syntaxıdır.
        //(string[] args) -> string dizi tipindede argüman listesi aldığını gösterir. Komut satırı argümanlarını içeri almak için kullanılmaktadır. Komut satırından siz bu programı çalıştırırken bir input vermek istiyorsanız (string[] args) ifadesi ile bunları içeri alabiliriz.

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); //Console -> System namespace'i/kütüphanesi altında bir classdır. Yukarıdan using System; 'i silersek bunu göremez. O zaman şu şekilde çağırıp kullanabiliriz. -> System.Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi Giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı Giriniz:");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);
            Console.ReadLine();

            //launch.json -> "console": "integratedTerminal" or "externalTerminal"           
        }
    }
}
