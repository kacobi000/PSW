namespace Lab1Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            Random rnd = new Random();
            int liczba = rnd.Next(10);
            
        while(x == 1){    
            Console.WriteLine("Podaj liczbę");
            int y = Convert.ToInt32(Console.ReadLine());
            
            if(y > liczba){
                Console.WriteLine("Podana liczba jest większa niż liczba wygenerowana");
            }
            
            else if(y < liczba){
                Console.WriteLine("Podana liczba jest mniejsza niż liczba wygenerowana");
            }
            
            else{
            Console.WriteLine("Udało ci sie zgadnąć liczbę");
            x = 0;
            }
        }
            
        }
    }
}