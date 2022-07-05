internal class Program
{
    private static void Main(string[] args)
    {
        //Sort --> Sıralar
        int[] sayiDizisi = {23, 12, 4, 86, 72, 3, 11, 17};

        Console.WriteLine("**** Sırasız Dizi ****");
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        Console.WriteLine("**** Sıralı Dizi ****");
        Array.Sort(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //Clear --> Verdiğimiz dizi içerisinde, verdiğimiz indexden başlayarak, verdiğimiz eleman sayısı kadar değeri sıfır değeri atar..
        Console.WriteLine("**** Array Clear ****");
        Array.Clear(sayiDizisi,2,2);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //Reverse --> Ayna görevi gibi tersine döner. İlk eleman son eleman olur. Son eleman ilk eleman olur.
        Console.WriteLine("**** Array Reverse ****");
        Array.Reverse(sayiDizisi);
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }

        //IndexOf --> Verdiğimiz dizi üzerinde verdiğimiz eleman, Eğer dizi içerisinde varsa onun indexini bize döner.
        Console.WriteLine("**** Array IndexOf ****");      
        Console.WriteLine(Array.IndexOf(sayiDizisi,23));

        //Resize --> Diziyi yeniden boyutlandır.
        Console.WriteLine("**** Array Resize ****");
        Array.Resize<int>(ref sayiDizisi,9);
        sayiDizisi[8] = 99;
        foreach (var sayi in sayiDizisi)
        {
            Console.WriteLine(sayi);
        }



    }
}