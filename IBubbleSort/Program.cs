using System;
using System.Diagnostics;
//using System.Threading;

namespace IBubbleSort
{
    class Program
    {
        public abstract class Data
        {
            public virtual void Swap(int i, int j)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;

            }
            public int[] a = new int[10] { 3, 0, 1, 8, 7, 2, 5, 4, 6, 9 };
            //public int[] a = new int[10];
            //for(m=0;m<=a.Length;m++)
            //    {
            //    a[m]=random.Next(0, 100);
            //    }


        }
        public class Childrens:Data 
        {
            public override void Swap(int i, int j)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;

            }
        }

        static void Main(string[] args)
        {
            Childrens Ex = new Childrens();
            Stopwatch sw = new Stopwatch();

            sw.Start();

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
  
            TimeSpan ts = sw.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
        }
    }
}
