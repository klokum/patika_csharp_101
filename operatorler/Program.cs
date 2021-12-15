using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve işlemli atama
            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y); //Output = 5
            y += 2; //İşlemli atama
            Console.WriteLine(y); //Output = 7
            y /= 1;
        Console.WriteLine(y); //Output = 7
            x *= 2;
            Console.WriteLine(x); //Output = 6

            // Mantıksal Operatörler
            // ||, &&, !

            bool isSucces = true; //bool true veya false döndürür.
            bool isCompleted = false;

            if(isSucces && isCompleted) //T&&F = False
                Console.WriteLine( "Perfect!"); //False geldiği için "if" içine girmedi ve bu satırı yazdırmadı.

            if(isSucces || isCompleted) //T||F = True
                Console.WriteLine( "Great!"); //Output = Great!

            if(isSucces && !isCompleted) //T && T = True 
                Console.WriteLine( "Perfect!"); //Output = Perfect!

            //İlişkisel Operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;
            bool sonuc = a<b;
            Console.WriteLine(sonuc); //True
            sonuc = a>b;
            Console.WriteLine(sonuc); //False
            sonuc = a>=b;
            Console.WriteLine(sonuc); //False
            sonuc = a<=b;
            Console.WriteLine(sonuc); //True
            sonuc = a==b;
            Console.WriteLine(sonuc); //False
            sonuc = a!=b;
            Console.WriteLine(sonuc); //True

            //Aritmetik Operatorler
            // /, *, +, -

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1); //Output : 2
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1); //Output : 50
            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1); //Output : 15
            sayi1++;
            Console.WriteLine(sayi1); //Output : 11

            // ile % mod alır. Mod alındıktan sonra kalanı getiren ifadedir.
            int sonuc2 = 20 % 3;
            Console.WriteLine(sonuc2); //Output: 2               
        }
    }
}
