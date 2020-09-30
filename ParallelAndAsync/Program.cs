using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelAndAsync
{
    class Program
    {
        static void Main1()
        {
            // TPL - Task Parallel Library

            int[] numbers = { 23, 45, 12, 56, 78, 43, 54, 65, 32, 21 };
            Stopwatch stopwatch = new Stopwatch();
            //Sequential
            stopwatch.Start();
            foreach (var num in numbers)
            {
                Compute(num);
            }
            Console.WriteLine($"Time taken (Sequential): {stopwatch.ElapsedMilliseconds} ms");

            // Parallel
            stopwatch.Restart();
            Parallel.ForEach(numbers, num =>
            {
                Compute(num);
            });
            Console.WriteLine($"Time taken (Parallel): {stopwatch.ElapsedMilliseconds} ms");

        }

        static void Compute(int x)
        {
            Thread.Sleep(100);
            Console.WriteLine($"Computed for {x}");
        }

        static void main()
        {
            //Example :Making breakfast
            //Make Tea
            //-Turn on burner(2s)
            //-Put on kettle(2s)
            //-Add water(2s)
            //-Boil it(3min)
            //-Grind teas masala(10s)
            //Add sugar and masalas(2s)
            //-Add milk(2s)
            //-boil it (2 min)
        }

    }
}