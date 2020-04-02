using System;

namespace IBubbleSort
{
    class Program
    {
        public class Data
        {
            public void Swap(int i, int j)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;

            }
            public int[] a = new int[10] { 3, 0, 1, 8, 7, 2, 5, 4, 6, 9 };
        }

        static void Main(string[] args)
        {
            Data Ex = new Data();

            DateTime DT = DateTime.Now;
            int swap = 0;
            //выведем на экран исходный массив
            for (int i = 0; i < Ex.a.Length; i++)
                Console.Write(Ex.a[i]+", ");
            //сортировка пузырьком
                for (int i = 0; i < Ex.a.Length-1; i++)
                {
                    for (int j = i+1; j < Ex.a.Length; j++)
                    {
                        if (Ex.a[i] > Ex.a[j])
                        Ex.Swap(i, j);
                        swap++ ;      
                    }  
                    if (swap == 0)
                    break;
                }
                //выводим результат массив
            Console.WriteLine();

            for (int i = 0; i < Ex.a.Length; i++)
                Console.Write(Ex.a[i] + ", ");

            //Dim sw = new Stopwatch();
            //sw.Start();
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed.ToString());
            DateTime LT=DateTime.Now;
            Console.WriteLine(Convert.ToString((LT)- (DT)));
        }
    }
}
