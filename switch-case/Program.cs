internal class Program
{
    private static void Main(string[] args)
    {
        int month = DateTime.Now.Month;
        
        //Switch-case'de herhangi bir sırayı takip etmemize gerek yok.
        //Expression --> Kontrol etmek istediğimiz koşulu yazarız.
        switch (month)
        {
            case 6:
                Console.WriteLine("Haziran ayındasınız!");
                break;
            
            case 2:
                Console.WriteLine("Temmuz ayındasınız!");
                break;
            
            case 3:
                Console.WriteLine("Ağustos ayındasınız!");
                break;

            case 4:
                Console.WriteLine("Eylül ayındasınız!");
                break;
            
            default:  //hiç bir case'e uymazsa
                Console.WriteLine("Yanlış veri girişi.");
            break;  
        }

        //Birden fazla case ifadesi ile...
        switch (month)
        {

            case 12:
            case 1:
            case 2:
                Console.WriteLine("Kış");
                break;

            case 3:
            case 4:
            case 5:
                Console.WriteLine("İlkbahar");
                break;

            case 6:
            case 7:
            case 8:
                Console.WriteLine("Yaz");
                break;

            case 9:
            case 10:
            case 11:
                Console.WriteLine("Sonbahar");
                break;
        }
    }
}