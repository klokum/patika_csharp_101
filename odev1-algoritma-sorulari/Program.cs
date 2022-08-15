internal class Program
{
    private static void Main(string[] args)
    {
        /*
        1-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın
        2-Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
        3-Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
        4-Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.
        */

        Methods methods = new Methods();

        // methods.EvenNumbers();
        // methods.FulDividend();
        // methods.ReverseWrite();
        methods.NumberOfWordAndLetter();

        
        
    }
}

public class Methods
{
    public void EvenNumbers()
    {
        Console.Write("Kaç sayı girmek istersiniz : ");
        string quantity = Console.ReadLine();

        List<int> evenNumbers = new List<int>();

        for (int i = 0; i < int.Parse(quantity); i++)
        {
            Console.Write("Sayı Giriniz...");
            int number = int.Parse(Console.ReadLine());
            
            if (number % 2 == 0) 
                evenNumbers.Add(number);
        }

        foreach (var item  in evenNumbers)
        {
            Console.WriteLine(item);
        }
    }

    public void FulDividend()
    {
            Console.Write("Bolunen sayıyı giriniz : ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Sayı adedini giriniz : ");
            int n = int.Parse(Console.ReadLine());

            List<int> nums = new List<int>();

            for (int i=0; i<n; i++)
            {
                Console.Write("Sayi Giriniz : ");
                int num = int.Parse(Console.ReadLine());
                if (m % num == 0) nums.Add(num);
            }

            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
    }

    public void ReverseWrite()
    {
        Console.Write("Kelime adedi giriniz : ");
        int n = int.Parse(Console.ReadLine());

        List<string> words = new List<string>();

        for (int i = 0; i < n; i++)
        {
            Console.Write("Kelime Giriniz : ");
            string word = Console.ReadLine();
            words.Add(word);
        }
        for (int i = n - 1; i >= 0; i--)
        {
            Console.WriteLine(words[i]);
        }
    }

    public void NumberOfWordAndLetter()
    {
        Console.Write("Cümle Giriniz : ");
        string sentence = Console.ReadLine();
        string[] wordsInSentence = sentence.Split(' ');
        Console.WriteLine("Kelime Sayisi : {0}", wordsInSentence.Count());
        //Regex r = new Regex(@"\w");
        //Match m = r.Match(sentence);
        Console.WriteLine("Harf Sayisi : {0}", sentence.Count());
    }
}