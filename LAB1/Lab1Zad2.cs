namespace Lab2Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczby");
            string liczby = Console.ReadLine();
            liczby = liczby + " ";
            List<int> lLiczb = new List<int>();
            string liczbaS = "";
            try
            {
                for (int i = 0; i < liczby.Length; i++)
                {
                    if (liczby[i] != ',' && i + 1 < liczby.Length)
                    {
                        liczbaS = liczbaS + liczby[i];
                    }
                    else
                    {
                        int liczba = int.Parse(liczbaS);
                        lLiczb.Add(liczba);
                        liczbaS = "";
                    }
                }

                Console.WriteLine("Unikalne: ");
                int unikalne = 0;
                for (int i = 0; i < lLiczb.Count; i++)
                {
                    bool unikalna = true;
                    for (int j = 0; j < lLiczb.Count; j++)
                    {
                        if (i != j)
                        {
                            if (lLiczb[i] == lLiczb[j])
                            {
                                unikalna = false;
                            }
                        }
                    }
                    if (unikalna)
                    {
                        unikalne++;
                    }
                }
                Console.WriteLine(unikalne);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Podano niepoprawne dane!");
            }

            Console.ReadKey();
        }
    }
}