// public class Lab2Zad1{
//     public static void Main(string[] args){

//         int[] array = new int[6];
//         Console.WriteLine("Please Sir Enter 6 Floating numbers");
//         for (int i = 0; i < 6; i++){
//             array[i] = Convert.ToInt32(Console.ReadLine());
//             }
//         Console.WriteLine("Posortowany ciąg: ");
//         bubbleSort(array,6);
//         int a;
//         for(a = 0; a < 6; a++)
//         Console.Write(array[a]+"\t");
//         Console.ReadLine();
//         }
//     static void bubbleSort(int[] data, int n){
//         int a;
//         int b;
//         for(a = 0; a < n; a++)
//             for (b = n-1; b > a; b--)
//                 if (data[b] > data[b-1]){
//                     int temp = data[b];
//                     data[b]=data[b-1];
//                     data[b-1]=temp;
//                     }
//         }
// }