internal class Program
{
    private static void Main(string[] args)
    {
        //**Recursive Metotlar - Öz Yinelemeli Fonk. --> Kendi kendini çağıran fonk.
        
        //3^4 hesaplaması? Önce for ile yapalım, sonra recursive func. ile.
        //3*3*3*3
        
        //for ile

        int result = 1; 
        for (int i = 1; i < 5; i++)
        {
            result = result * 3;    
        }        
        Console.WriteLine(result);

        //recursive

        İslemler islemler = new İslemler();
        Console.WriteLine(islemler.Expo(3, 4));

        //**Extension Metotlar
        //*Extension Classlar ve Metotlar static olmalıdır. --> Çünkü nesnesi olmadan erişilebilir olmaları gerekir.

        string ifade = "Kaan Lokum";
        bool sonuc = ifade.CheckSpaces();
        Console.WriteLine(sonuc); 

        if(sonuc)
        {
            Console.WriteLine(ifade.RemoveWhiteSpaces());
        }
        Console.WriteLine(ifade.MakeUpperCase());
        Console.WriteLine(ifade.MakeLowerCase());

        int[] dizi = {9,3,6,2,1,5,0};
        dizi.SortArray();
        dizi.EkranaYazdir();

        int sayi = 5;
        Console.WriteLine(sayi.IsEvenNumber());

        Console.WriteLine(ifade.GetFirstChar());
            
    }
}

public class İslemler
{
    public int Expo(int sayi, int üs)
    {
        if (üs < 2)
            return sayi;

        return Expo(sayi, üs-1)*sayi;
    }

    //Expo(3,4);
    //Expo(3,4) * 3;
    //Expo(3,4) * 3 * 3;
    //Expo(3,4) * 3 * 3 * 3;
    // 3 * 3 * 3 * 3 = 3^4
}

public static class Extensions
{
    public static bool CheckSpaces(this string param)   //this ile extension metot haline getirdik. Buradaki this'den sonraki veri tipi ne ise sadece o tipler için bu extension metotlar uygulanabilir.
    {
        return param.Contains(" ");
    }

    public static string RemoveWhiteSpaces(this string param)
    {
        string[] dizi = param.Split(" ");
        return string.Join("",dizi);
    }
     
    public static string MakeUpperCase(this string param)
    {
        return param.ToUpper();
    }

    public static string MakeLowerCase(this string param)
    {
        return param.ToLower();
    }

    public static int[] SortArray(this int[] param)
    {
        Array.Sort(param);
        return param;
    }

    public static void EkranaYazdir(this int[] param)
    {
        foreach (var item in param)
        {
            Console.WriteLine(item);
        }
    }

    public static bool IsEvenNumber(this int param)
    {
        return param % 2 == 0;
    }

    public static string GetFirstChar(this string param)
    {
        return param.Substring(0,1);
    }
}