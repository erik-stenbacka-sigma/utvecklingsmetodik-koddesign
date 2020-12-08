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
        static void PerformActionSimple(int count)
        {
            var result = "";
            for (var i = 0; i < count; i++)
            {
                Thread.Sleep(10);
                result += i;
            }
            Console.WriteLine($"Result is {result.Length}");
        }

        static void PerformActionComplex(int count)
        {
            var result = "";
            for (var i = 0; i < count; i++)
            {
                for (var j = 0; j < count; j++)
                {
                    Thread.Sleep(10);
                    result += i;
                }
            }
            Console.WriteLine($"Result is {result.Length}");
        }

        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            PerformActionSimple(100);
            stopWatch.Stop();
            Console.WriteLine($"It took: {stopWatch.ElapsedMilliseconds} ms");

            var stopWatch2 = new Stopwatch();

            stopWatch2.Start();
            PerformActionComplex(100);
            stopWatch2.Stop();
            Console.WriteLine($"It took: {stopWatch2.ElapsedMilliseconds} ms");

            Console.Read();
        }
    }
}

