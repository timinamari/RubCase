namespace RubCase
{
    public class RubCase
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = "рублей";
            if (n % 10 == 1) s = "рубль";
            if (n % 10 >= 2 && n % 10 <= 4) s = "рубля";
            if (n % 100 >= 11 & n % 100 <= 20) s = "рублей";
            Console.WriteLine("{0} {1}", n, s);

            Console.ReadKey();
        }
    }
}