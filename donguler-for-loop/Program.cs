internal class Program
{
    private static void Main(string[] args)
    {
        //Ekrandan girilen sayıya kadar olan tek sayıları cosnole'a yazdır.
        Console.WriteLine("Lütfen bir sayı giriniz.");
        int sayac = int.Parse(Console.ReadLine());
        for (int i = 0; i < sayac; i++)
        {
            if(i % 2 == 1)
            {
                Console.WriteLine(i);
            }
        }

        //1 ile 1000 arasındaki tek ve çift sayılarının toplamlarını hesapla ve console'a ayrı ayrı yazdır.
        int tekToplam = 0;
        int ciftToplam = 0;
        for (int i = 0; i <= 1000; i++)
        {
            if (i%2 == 1)
                tekToplam += i; //tekToplam = tekToplam + i;
            else
                ciftToplam += i;
        }
        Console.WriteLine("Tek Toplam: " + tekToplam);
        Console.WriteLine("Çift Toplam: " + ciftToplam);

        //break(Döngü sonlansın istersek), continue(O şartı sağladığında döngü ondan sonraki kod satırını atlar ve döngü diğer aşamadan devam eder.)

        for (int i = 1; i < 10; i++)
        {
            if(i==4) 
                break;  // i == 4 olduğunda döngü sonlanır.
            Console.WriteLine(i);
        }

        for (int i = 1; i < 10; i++)
        {
            if(i==4) 
                continue;  // i == 4 olduğunda döngü 4ü yazdırmaz ve atlar.
            Console.WriteLine(i);
        }

        for (;;)    //Sonsuz Döngü --> Mümkün olduğunca kullanma.
        {
            Console.WriteLine("Hello World");
        }
    }
}