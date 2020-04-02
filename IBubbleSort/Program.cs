using System;

namespace IBubbleSort
{
    class Program
    {
        static void Swap(int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
            
        }
        static int[] a = new int[10] { 3, 0, 1, 8, 7, 2, 5, 4, 6, 9 };


        static void Main(string[] args)
        {
            DateTime DT = DateTime.Now;
            int swap = 0;
            //выведем на экран исходный массив
            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i]+", ");
            //сортировка пузырьком
                for (int i = 0; i < a.Length-1; i++)
                {
                    for (int j = i+1; j < a.Length; j++)
                    {
                        if (a[i] > a[j])
                        Swap(i, j);
                        swap++ ;      
                    }  
                    if (swap == 0)
                    break;
                }
                //выводим результат массив
            Console.WriteLine();

            for (int i = 0; i < a.Length; i++)
                Console.Write(a[i] + ", ");

            //Dim sw = new Stopwatch();
            //sw.Start();
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed.ToString());
            DateTime LT=DateTime.Now;
            Console.WriteLine(Convert.ToString((LT)- (DT)));
        }
    }
}
