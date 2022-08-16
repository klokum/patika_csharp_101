﻿internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("****DATETIME KÜTÜPHANESİ****");
        //--DATETIME--

        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date);
        Console.WriteLine(DateTime.Now.Day);
        Console.WriteLine(DateTime.Now.Month);
        Console.WriteLine(DateTime.Now.Year);
        Console.WriteLine(DateTime.Now.Hour);
        Console.WriteLine(DateTime.Now.Minute);
        Console.WriteLine(DateTime.Now.Second);

        Console.WriteLine(DateTime.Now.DayOfWeek);  //Haftanın gününü string halde getirir.
        Console.WriteLine(DateTime.Now.DayOfYear);  //İçinde bulunulan yılın kaçıncı günü?

        Console.WriteLine(DateTime.Now.ToLongDateString());
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.ToLongTimeString());
        Console.WriteLine(DateTime.Now.ToShortTimeString());

        Console.WriteLine(DateTime.Now.AddDays(2));
        Console.WriteLine(DateTime.Now.AddHours(3));
        Console.WriteLine(DateTime.Now.AddSeconds(30));
        Console.WriteLine(DateTime.Now.AddMonths(5));
        Console.WriteLine(DateTime.Now.AddYears(10));
        Console.WriteLine(DateTime.Now.AddMilliseconds(50));

        //DateTime Format
        Console.WriteLine(DateTime.Now.ToString("dd"));    //16
        Console.WriteLine(DateTime.Now.ToString("ddd"));    //Tue
        Console.WriteLine(DateTime.Now.ToString("dddd"));   //Tuesday

        Console.WriteLine(DateTime.Now.ToString("MM"));    //08
        Console.WriteLine(DateTime.Now.ToString("MMM"));    //Aug
        Console.WriteLine(DateTime.Now.ToString("MMMM"));   //August
 
        Console.WriteLine(DateTime.Now.ToString("yy"));    //22
        Console.WriteLine(DateTime.Now.ToString("yyyy"));    //2022

        Console.WriteLine("****MATH KÜTÜPHANESİ****");
        //--MATH--

        Console.WriteLine(Math.Abs(-25));   //Mutlak Değer > 25
        Console.WriteLine(Math.Sin(10));    //Sinüs alır.
        Console.WriteLine(Math.Cos(10));
        Console.WriteLine(Math.Tan(10));

        Console.WriteLine(Math.Ceiling(22.3));  //23 (Verilen Sayıdan sonraki en büyük sayıya yuvarlar. YUKARI YUVARLAR)
        Console.WriteLine(Math.Round(22.3));    //22 (Hangi sayıya daha yakınsa ona yuvarlar.)
        Console.WriteLine(Math.Floor(22.7));    //22 (Verilen Sayıdan önceki en küçük sayıya yuvarlar. AŞAĞI YUVARLAR)

        Console.WriteLine(Math.Max(2,6));   //6
        Console.WriteLine(Math.Min(2,6));   //2

        Console.WriteLine(Math.Pow(3,4));   //3^4'ü verir. 81
        Console.WriteLine(Math.Sqrt(9));    //Karekök alır. 3
        Console.WriteLine(Math.Log(9));     //9'un e tabanındaki logaritmik karşılığı
        Console.WriteLine(Math.Exp(3));     //e^3'ü verir.
        Console.WriteLine(Math.Log10(10));  //10 sayısının logaritma 10 tabanındaki karşılığını verir.
        
    }
}