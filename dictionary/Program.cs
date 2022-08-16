internal class Program
{
    private static void Main(string[] args)
    {
        //system.collection.generic
        Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
        
        kullanicilar.Add(10,"Kaan Lokum");
        kullanicilar.Add(12,"Tarık Kural");
        kullanicilar.Add(18, "Batuhan Sofu");
        kullanicilar.Add(20, "Şahin Cihan");

        //Dizinin elemanlarına erişim
        Console.WriteLine("**** Elemanlara Erişim ****");
        Console.WriteLine(kullanicilar[12]);

        foreach (var item in kullanicilar)
        {
            Console.WriteLine(item);
        }

        //Count
        Console.WriteLine("**** Count ****");
        Console.WriteLine(kullanicilar.Count);

        //Contains
        Console.WriteLine("**** Contains ****");
        Console.WriteLine(kullanicilar.ContainsKey(12));
        Console.WriteLine(kullanicilar.ContainsValue("Kaan Lokum"));

        //Remove
        Console.WriteLine("**** Remove ****");
        kullanicilar.Remove(12);

        foreach (var item in kullanicilar)
            Console.WriteLine(item);

        //Keys
        Console.WriteLine("**** Keys ****");
        foreach (var item in kullanicilar.Keys)
            Console.WriteLine(item);
        //Values
        Console.WriteLine("**** Values ****");
        foreach (var item in kullanicilar.Values)
            Console.WriteLine(item);


    }
}