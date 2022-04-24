namespace Lab1Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj strukturę binarną");
            String str = Console.ReadLine();
            bool czyStruktura = true;
            int dziury = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((!str[i].Equals('0')) && (!str[i].Equals('1')))
                {
                    czyStruktura = false;
                    break;
                }
            }

            if (czyStruktura)
            {
                bool czyPocz = false;
                bool czyDziura = false;
                for (int i = 0; i < str.Length; i++)
                {
                    if (!czyPocz)
                    {
                        if (str[i].Equals('1'))
                        {
                            czyPocz = true;
                        }
                    }
                    else
                    {
                        if (str[i].Equals('0'))
                        {
                            czyDziura = true;
                        }
                        else
                        {
                            if (czyDziura)
                            {
                                dziury++;
                            }
                            czyDziura = false;
                        }
                    }
                }
                Console.WriteLine("Dziury: " + dziury);
            }
            else
            {
                Console.WriteLine("Nie podano struktury");
            }

            Console.ReadKey();
        }
    }
}