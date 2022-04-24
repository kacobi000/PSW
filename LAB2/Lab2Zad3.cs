public class Lab2Zad3{

    public static void Main(string[] args){

        Console.WriteLine("Podaj wymiary macierzy:");
        int wymiar = Convert.ToInt32(Console.ReadLine());

        Random rand = new Random();

        int[,] m1 = new int[wymiar, wymiar];
        int[,] m2 = new int[wymiar, wymiar];
        int[,] m1m2 = new int[wymiar, wymiar];

        for (int i = 0; i < wymiar; i++){
                for (int a = 0; a < wymiar; a++){
                    m1[i, a] = rand.Next(-10, 10);
                    }

            }

        for (int i = 0; i < wymiar; i++){
            for (int a = 0; a < wymiar; a++){
                m2[i, a] = rand.Next(-10, 10);
                }
            }

//Dodawanie macierzy
        Console.WriteLine("\nDodanie macierzy: ");
        for (int i = 0; i < wymiar; i++)
            for (int j = 0; j < wymiar; j++){
                m1m2[i, j] = m1[i, j] + m2[i, j];
                }
 
        Console.WriteLine("\nM1 + M2:");
        for (int i = 0; i < wymiar; i++){
            for (int j = 0; j < wymiar; j++){
                Console.Write("{0} ", m1m2[i, j]);
                }
            Console.WriteLine("");
            }    


//Mnożenie Macierzy
        Console.WriteLine("\nMnozenie macierzy:");
        for (int i = 0; i < wymiar; i++){
            for (int k = 0; k < wymiar; k++){
                for (int j = 0; j < wymiar; j++){
                    m1m2[i, k] += m1[i, j] * m2[j, k];
                    }
                }
            }
 
        Console.WriteLine("\nM1 x M2: ");
        for (int i = 0; i < wymiar; i++){
            for (int k = 0; k < wymiar; k++){
                Console.Write("{0} ", m1m2[i, k]);
                }
            Console.WriteLine("");
            }


// Odejmowanie macierzy
        Console.WriteLine("\nOdejmowanie macierzy: ");
        for (int i = 0; i < wymiar; i++)
            for (int j = 0; j < wymiar; j++){
                m1m2[i, j] = m1[i, j] - m2[i, j];
                }
            Console.WriteLine("\nM1 - M2:");
            for (int i = 0; i < wymiar; i++){
                for (int j = 0; j < wymiar; j++){
                    Console.Write("{0} ", m1m2[i, j]);
                    }
                Console.WriteLine("");
                } 
    }
}