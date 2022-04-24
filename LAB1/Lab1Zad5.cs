namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Podaj liczbę");
            int n = Convert.ToInt32(Console.ReadLine());
            int pierwiastek = (int) Math.Floor(Math.Sqrt(n));
            int pomocnicza = 0;
            
            if(n == 2)
                Console.WriteLine("Podana liczba to liczba pierwsza");
            else if(n % 2 == 0 || n <= 1)
                Console.WriteLine("Podana liczba nie jest liczbą pierwsza");
            else
            {   
                for (int i = 2; i <= pierwiastek; ++i)
                {
                    if (n % i == 0)
                    { 
                        Console.WriteLine("Podana liczba nie jest liczbą pierwsza");
                        pomocnicza = 1;
                    }
                }
                if(pomocnicza == 0)
                Console.WriteLine("Podana liczba jest liczbą pierwsza");
            }
        }
    }
}