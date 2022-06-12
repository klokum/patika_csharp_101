internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("**** While ****");

        //1 den başlayarak consoledan girilen sayıya kadar (sayı dahil) ort. hepsalayıp console'a yazdır.
        Console.WriteLine("Lütfen bir sayı giriniz: ");
        int sayi = int.Parse(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;
        while(sayac <= sayi)
        {
            toplam += sayac;
            sayac ++;    
        }

        Console.WriteLine(toplam/sayi);

        // 'a' dan 'z' 'ye kadar tüm harfleri console'a yazdır.
        char character = 'a';
        while(character <= 'z')
        {
            Console.Write(character);
            Console.Write(" ");
            character ++;      
        }

        Console.WriteLine(" ");

        Console.WriteLine("**** Foreach ****");

        string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};
        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
}