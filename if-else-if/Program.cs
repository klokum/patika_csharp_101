internal class Program
{
    private static void Main(string[] args)
    {
        int time = DateTime.Now.Hour; //O anki saati aldık.

        if(time >=6 && time < 11)
            Console.WriteLine("Günaydın!");
        else if (time <= 18)
            Console.WriteLine("İyi Günler!");
        else
            Console.WriteLine("iyi Geceler!");

        //Ternary If
        string sonuc = time <=18 ? "İyi Günler!" : "İyi Geceler!";
        Console.WriteLine(sonuc);
        
        //İki ternary if'i birleştirirsek --> Yukarıdaki gibi
        sonuc = time >= 6 && time < 11 ? "Günaydın!" : time <= 18 ? "İyi Günler!": "iyi Geceler!";
        Console.WriteLine(sonuc);
 
    }
}