internal class Program
{
    private static void Main(string[] args)
    {
        string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
        string degisken2 = "Dersimiz CSharp";
        string degisken3 = "dersimiz CSharp, Hoşgeldiniz!";

        //Length
        Console.WriteLine(degisken.Length);

        //ToUpper, ToLower
        Console.WriteLine(degisken.ToUpper());
        Console.WriteLine(degisken.ToLower());

        //Concat
        Console.WriteLine(String.Concat(degisken," Merhaba!"));

        //Compare / CompareTo
        Console.WriteLine(degisken.CompareTo(degisken2));   //Karakter sayıları karşılaştırılır (degisken-degisken2). 1,0,-1 şeklinde dönüş sağlar.
        Console.WriteLine(String.Compare(degisken, degisken3, true));
        Console.WriteLine(String.Compare(degisken, degisken3, false));

        //Contains
        Console.WriteLine(degisken.Contains(degisken2));

        Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));

        Console.WriteLine(degisken.StartsWith("Merhaba"));

        //IndexOf
        Console.WriteLine(degisken.IndexOf("CS")); //CS'yi arar C'yi bulduğunda da onun index numarasını döner. Bulamazsa -1 döner.
        Console.WriteLine(degisken.IndexOf("Kaan"));

        Console.WriteLine(degisken.LastIndexOf("i")); //En son olan "i"'nin index numarasını getirir.

        //Insert
        Console.WriteLine(degisken.Insert(0,"Merhaba! "));

        //PadLeft, PadRight
        Console.WriteLine(degisken + degisken2.PadLeft(30));    //degisken2'nin soluna 30 karaktere tamamlayacak kadar boşluk ekler.
        Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));   //degisken2'nin soluna 30 karaktere tamamlayacak kadar * ekler.

        Console.WriteLine(degisken.PadRight(50) + degisken2);
        Console.WriteLine(degisken.PadRight(50,'-') + degisken2);

        //Remove
        Console.WriteLine(degisken.Remove(10)); //10.indexden sonrasını siler.
        Console.WriteLine(degisken.Remove(5,3));  //5.indexden başla 3 karakter sil.
        Console.WriteLine(degisken.Remove(0,1));

        //Replace
        Console.WriteLine(degisken.Replace("CSharp","C#"));
        Console.WriteLine(degisken.Replace(" ","*")); 

        //Split
        Console.WriteLine(degisken.Split(' ')[1]);

        //Substring
        Console.WriteLine(degisken.Substring(4));   //4.indexten başlar sonuna kadar getirir.
        Console.WriteLine(degisken.Substring(4,6));    //4.indexden başlar 6 karakter getirir. 

    



    }
}