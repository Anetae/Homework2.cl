using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2.cl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            //int[] bars = { 3, 3, 3, 3, 4, 3, 3, 3, 3, 3, 3, 3, };
            //var result = Find(bars);
            //Console.WriteLine($"fake bar {result}");
            //Console.ReadLine();


            // Task 2
            //List<int> num = new List<int>() { 1, 2, 3, 4, 5, 6, };
            //List<int> list = Middle(num);
            //foreach(var i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            // Task 3
            List<int> list = new List<int>() { 11, 45, 67, 89, 17, };
            int find = FindLargest(list);
            Console.WriteLine(find);
            Console.ReadLine();

        }

        // Task 1
        //static int Find(int[] bars)
        //{

        //   int size = bars.Length/3;
        //    int bars1 = Sum(bars, 0, size);
        //    int bars2 = Sum(bars, size,2*size);

        //    if (bars1 == bars2)
        //    {
        //        return bars.Length - 1;
        //    }
        //    else if (bars1 < bars2)
        //    {
        //        return bars1;
        //    }
        //    else
        //    {
        //        return bars2;
        //    }
        //}


        //static int Sum(int[] bars, int a, int b)
        //{
        //    int sum = 0;
        //    for (int i = a; i < b; i++)
        //    {
        //        sum += bars[i];
        //    }
        //    return sum;
        //}




        //// Task 2
        ////static List<int> Middle(List<int> list)
        ////{
        ////    int lenght = list.Count;
        ////    int a = lenght / 2;

        ////    if (lenght % 2 == 0)
        ////    {
        ////        return new List<int> { list[a - 1], list[a] };
        ////    }
        ////    else
        ////    {
        ////        return new List<int> { list[a] };
        //    }
        //}



        // Task 3
        static int FindLargest(List<int> list)
        {
            if (list.Count == 0) return 0;

            int largest = 0;
            foreach (int i in list)
            {
                if (i > largest)
                    largest = i;
            }
            return largest;
        }


    }
}
