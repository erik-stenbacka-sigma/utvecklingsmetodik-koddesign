using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IAPI api = new CachingProxy(new API());

            String line;
            while ((line = Console.ReadLine()) != "")
            {
                var result = api.getData(line);
                Console.WriteLine($"Result: {result}");
            }
        }
    }
}
