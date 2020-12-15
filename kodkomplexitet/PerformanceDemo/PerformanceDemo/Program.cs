using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace PerformanceDemo
{
    class Program
    {
        static void ConstansTimeExample(List<String> list)
        {
            Console.WriteLine($"The length of the list is {list.Count}");
            Thread.Sleep(10); // included to make time measurement easier
        }

        static void LinearTimeExample(List<String> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine($"Item value: {item}");
                Thread.Sleep(10); // included to make time measurement easier
            }
        }

        static String LogarithmicTimeExample(List<String> list)
        {
            if (list.Count == 1)
            {
                Thread.Sleep(10); // included to make time measurement easier
                return list[0];
            }
            else
            {
                Thread.Sleep(10); // included to make time measurement easier
                return LogarithmicTimeExample(list.GetRange(0, (int)Math.Ceiling(list.Count / 2.0)));
            }
        }

        static void QuadraticTimeExample(List<String> list)
        {
            foreach (var item in list)
            {
                foreach (var otherItem in list)
                {
                    Console.WriteLine($"Some computation on {item} and {otherItem}");
                    Thread.Sleep(10); // included to make time measurement easier
                }
            }
        }


        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            var list = new List<string> { "item-1", "item-2", "item-3", "item-1", "item-2", "item-3", "item-1", "item-2", "item-3" };

            stopWatch.Start();
            ConstansTimeExample(list);
            stopWatch.Stop();
            var constantTime = stopWatch.ElapsedMilliseconds;
            stopWatch.Reset();

            stopWatch.Start();
            LogarithmicTimeExample(list);
            stopWatch.Stop();
            var logTime = stopWatch.ElapsedMilliseconds;
            stopWatch.Reset();

            stopWatch.Start();
            LinearTimeExample(list);
            stopWatch.Stop();
            var linearTime = stopWatch.ElapsedMilliseconds;
            stopWatch.Reset();

            stopWatch.Start();
            QuadraticTimeExample(list);
            stopWatch.Stop();
            var quaricTime = stopWatch.ElapsedMilliseconds;
            stopWatch.Reset();

            Console.WriteLine();
            Console.WriteLine($"Constant time: {constantTime} ms");
            Console.WriteLine($"Logaritmic time: {logTime} ms");
            Console.WriteLine($"Linear time: {linearTime} ms");
            Console.WriteLine($"Quadratic time: {quaricTime} ms");

            Console.Read();
        }
    }
}

