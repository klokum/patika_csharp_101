internal class Program
{
    private static void Main(string[] args)
    {
        //List<T> class
        //System.Collections.Generic
        //T -> object türündedir. Genericliği belirtir.

        List<int> sayiListesi = new List<int>();
        
        sayiListesi.Add(23);
        sayiListesi.Add(10);
        sayiListesi.Add(4);
        sayiListesi.Add(5);
        sayiListesi.Add(92);
        sayiListesi.Add(34);

        List<string> renkListesi = new List<string>();

        renkListesi.Add("Kırmızı");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Sarı");
        renkListesi.Add("Yeşil");

        //Count
        Console.WriteLine(sayiListesi.Count);
        Console.WriteLine(renkListesi.Count);

        foreach (var sayi in sayiListesi)
        {
            Console.WriteLine(sayi);
        }

        foreach (var renk in renkListesi)
        {
            Console.WriteLine(renk);
        }

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        //Listeden eleman çıkarma
        sayiListesi.Remove(4);
        renkListesi.Remove("Yeşil");

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        sayiListesi.RemoveAt(0);    //0. indexdeki elemeanı çıkarır.
        renkListesi.RemoveAt(1);

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        //Liste içerisinde arama
        if(sayiListesi.Contains(10))
        {
            Console.WriteLine("10 liste içerisinde bulundu.");
        }

        //Eleman ile index'e erişme
        Console.WriteLine(renkListesi.BinarySearch("Turuncu"));

        //Diziyi List'e çevirme
        string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};

        List<string> hayvanListesi = new List<string>(hayvanlar);

        //Listeyi nasıl temizlerim?
        hayvanListesi.Clear();

        //Liste içerisinde nesne tutmak
        List<Kullanıcılar> kullaniciListesi = new List<Kullanıcılar>();

        Kullanıcılar kullanici1 = new Kullanıcılar();
        kullanici1.Isim = "Kaan";
        kullanici1.Soyisim = "Lokum";
        kullanici1.Yas = 29;

        Kullanıcılar kullanici2 = new Kullanıcılar();
        kullanici2.Isim = "Tarık";
        kullanici2.Soyisim = "Kural";
        kullanici2.Yas = 23;

        kullaniciListesi.Add(kullanici1);
        kullaniciListesi.Add(kullanici2);

        List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
        yeniListe.Add(new Kullanıcılar(){
            Isim = "Batuhan",
            Soyisim = "Sofu",
            Yas = 29
        });

        foreach (Kullanıcılar kullanici in kullaniciListesi)
        {
            Console.WriteLine("Kullanici Adı: " + kullanici.Isim);
            Console.WriteLine("Kullanici Soyadı: " + kullanici.Soyisim);
            Console.WriteLine("Kullanici Yaşı: " + kullanici.Yas);
        }

        yeniListe.Clear();


    }

    public class Kullanıcılar
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}