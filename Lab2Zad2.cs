// public class Lab2Zad2{

//     public static void Main(string[] args){
// //1
//         Console.WriteLine("Podaj długość tablicy");
//         int dlugosc = Convert.ToInt32(Console.ReadLine());
        
//         double[] tablica = new double[dlugosc];
//         Random rand = new Random();
// //2
//         double[] liczby = { 2, 3, 3.5, 4, 4.5, 5 };
//         for (int i = 0; i < dlugosc; i++){
//                 tablica[i] = liczby[rand.Next(liczby.Length)];
//             }
// //3
//         double sum = 0;
//         foreach(double d in tablica){
//             sum += d;
//         }
//         double srednia = sum/dlugosc;

//         Console.WriteLine("średnia wartośc wylosowanych elementów tablicy: " + srednia);
// //4
//         double min = 100;
//         double max = 0;
//         for(int i=1; i<dlugosc; i++) {
//              if(tablica[i]>max) {
//                 max = tablica[i];
//             }  
//              if(tablica[i]<min) {
//                 min = tablica[i];
//              }
//         }
//         Console.WriteLine("wartość minimum to: " + min);
//         Console.WriteLine("wartość maksimum to: " + max);
// //5
//         double[] tab;
//         tab = new double[dlugosc];
//         int w = 0;
//         int m = 0;
//         for (int i = 0; i < dlugosc; i++){
//             if (tablica[i] < srednia){
//                 tab[m] = tablica[i];
//                 m++;
//                 }
//             }

//         System.Console.WriteLine("Wartosci mniejsze niz srednia:");
//         for (int i = 0; i < tab.Length; i++){
//             if (tablica[i] < srednia)
//                 System.Console.WriteLine(tablica[i]);
//             }

//         for (int i = 0; i < tablica.Length; i++){
//             if (tablica[i] > srednia){
//                 tab[w] = tablica[i];
//                 w++;
//                 }
//             }

//         System.Console.WriteLine("Wartosci większe niz srednia:");
//         for (int i = 0; i < tab.Length; i++){
//             if (tablica[i] > srednia)
//                 System.Console.WriteLine(tablica[i]);
//             }
// //6
//         for (int i = 0; i < dlugosc; i++){
//             tablica[i] = Math.Pow(tablica[i], 2);
//             }

//         double wyniksumypotegi = 0;
//         for (int i = 0; i < dlugosc; i++){
//             wyniksumypotegi = wyniksumypotegi + tablica[i];
//             }

//             double wynikdzielenia = wyniksumypotegi / dlugosc;
//             double wynikwariancji = wynikdzielenia - (Math.Pow(srednia, 2));
//             double wynikodchylenia = Math.Sqrt(wynikwariancji);
//             System.Console.WriteLine("Wynik odchylenia:" + wynikodchylenia);
//     }
// }
