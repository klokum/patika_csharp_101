internal class Program
{
    private static void Main(string[] args)
    {
        //--out Parametreler--

        string sayi = "999";
        //int outSayi;

        bool sonuc = int.TryParse(sayi, out int outSayi);
        if(sonuc)
        {
            Console.WriteLine("Başarılı");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Başarısız");
        }

        Metotlar metotlar = new Metotlar();
        metotlar.Topla(2,3, out int Top);
        Console.WriteLine(Top);

        //--Metot Overloading-- (Metot Aşırı Yükleme) --> Bir metodun imzasını değiştirerek aynı fonk. farklı farklı şekillerde kullanabiliriz.
        //Metot imzası --> MetotAdi + Parametre Sayisi + Parametreler 'i içerir

        int ifade = 999;
        metotlar.EkranaYazdir(Convert.ToString(ifade));
        metotlar.EkranaYazdir(ifade);
        metotlar.EkranaYazdir("Kaan ","Lokum");
    }
}

class Metotlar
{
    public void Topla(int a, int b, out int toplam)
    {
        toplam = a + b;
    }

    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(int veri) // Metot Overloading
    {
        Console.WriteLine(veri);
    }

    public void EkranaYazdir(string veri1, string veri2) // Metot Overloading
    {
        Console.WriteLine(veri1 + veri2);
    }
}