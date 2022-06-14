internal class Program
{
    private static void Main(string[] args)
    {
        //Dizi Tanımlama
        string[] renkler = new string[5];

        string[] hayvanlar = {"kedi", "köpek", "kuş", "maymun"};

        int[] dizi;
        dizi = new int[5];

        //Dizilere Değer Atama ve Erişim
        renkler[0] = "Mavi";
        dizi[3] = 10;

        Console.WriteLine(hayvanlar[0]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        //Döngülerde dizi kullanımı
        //Klavyeden girilen n tane sayının ort. hesaplayan program.

        Console.WriteLine("Lütfen dizinin eleman sayısını giriniz.");
        int diziUzunlugu = int.Parse(Console.ReadLine());
        int[] sayiDizisi = new int[diziUzunlugu];

        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.WriteLine("Lütfen {0}. sayıyı giriniz : ", i+1);
            sayiDizisi[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;

        foreach (var sayi in sayiDizisi)
        {
            toplam += sayi;
        }

        Console.WriteLine("ortalama : " + toplam/diziUzunlugu);


    }
}