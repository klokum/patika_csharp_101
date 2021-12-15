using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implict Conversion (Bilinçsiz Dönüşüm) -> Düşük kapasiteli bir değişkenin kendinden daha yüksek kapasiteli değişkene atama  işlemidir.
 
            Console.WriteLine("**** Implicit Conversion ****");
 
            byte a = 5;
            sbyte b = 30;
            short c = 10;
 
            int d = a+b+c;  //integerın kapasitesi yukarıdaki veri tiplerinden daha fazladır.
            Console.WriteLine("d: " + d);
 
            long h = d;   //longun kapasitesi de int'den fazladır.
            Console.WriteLine("h: " + h);
 
            float i = h;
            Console.WriteLine("i: " + i);
 
            string e = "Kaan";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine("g: " + g); //Tüm veri tipleri object'den türemiştir. Hepsinden daha yüksek kapasiteli veri tipi. 
 
            //Explicit Conversion (Bilinçli Dönüşüm) -> csharp'ın kendi kendine yapamadığı > Convert, Parse, ToString
 
            Console.WriteLine("**** Explict Conversion ****");
            int x = 4;
            byte y = (byte)x; //Byte int'den daha küçük kapasiteli bir veri tipidir. Dönüşümü cast ederek yaptık. Cast işlemi > Parantezin  sağındaki veriyi parantez içerisindekine dönüştürmeye çalışır.
            Console.WriteLine("y: " + y);
 
            int z  = 100;
            byte t  = (byte)z;
            Console.WriteLine("t: " + t);      
 
            float w = 10.3F;
            byte v = (byte)w;
            Console.WriteLine("v: " + v);
 
            //**** ToString Metodu ****
            Console.WriteLine("**** ToString Methodu ****");
            int xx = 6;
            string yy = xx.ToString();   //Yukarıdaki int değeri string çevirdik.  
            Console.WriteLine("yy: " + yy);
 
            string zz = 12.5f.ToString(); //??
            Console.WriteLine("zz: " + zz);    
 
            //System.Convert      
            Console.WriteLine("**** System.Convert Class ****");
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;
            
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
 
            Toplam = sayi1 + sayi2;
            Console.WriteLine("Toplam: " + Toplam);
 
            //Parse
            Console.WriteLine("**** Parse Methodu ****"); //String bir değişkeni Parse kullanarak başka değişken tiplerine çevirebiliriz. Parse her zaman string alır.
            ParseMethod();

        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10,25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("rakam1 : " + rakam1);
            Console.WriteLine("double1 : " + double1);           
        }
    }
}
