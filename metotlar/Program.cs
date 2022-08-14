internal class Program
{
    private static void Main(string[] args)
    {
        //erisim_belirteci geri_donus_tipi metot_adi(parametreListesi/arguman)
        //{
            //komutlar;
            //return;
        //}

        int a = 2;
        int b = 3;

        Console.WriteLine(a+b);
        
        int sonuc = Topla(a, b);
        Console.WriteLine(sonuc);

        Metotlar metotlar = new Metotlar();
        metotlar.EkranaYazdir(Convert.ToString(sonuc));

        int sonuc2 = metotlar.ArttirVeTopla(ref a, ref b);  //ref ile çalışırsak orj. yapısına işlem yapar-değiştirir, kopyası ile yapmaz.
        metotlar.EkranaYazdir(Convert.ToString(sonuc2));
        Console.WriteLine(a + b);
    }
 
    static int Topla(int deger1, int deger2)
    {
        return (deger1 + deger2);
    }
}

class Metotlar
{
    public void EkranaYazdir(string veri)
    {
        Console.WriteLine(veri); 
    }

    public int ArttirVeTopla(ref int deger1, ref int deger2)
    {
        deger1+=1;
        deger2+=1;
        return deger1 + deger2;
    }
}