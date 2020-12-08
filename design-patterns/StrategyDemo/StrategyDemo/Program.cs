using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDemo
{
    class Program
    {
        static Strategy getStrategy(String line)
        {
            if (line.StartsWith("+"))
            {
                return new PlusStrategy();
            }
            else if (line.StartsWith("-"))
            {
                return new MinusStrategy();
            }
            else
            {
                return null;
            }
        }

        static void Main(string[] args)
        {
            String line;
            var context = new Context();
            while ((line = Console.ReadLine()) != "")
            {
                String output;
                Console.WriteLine($"Provide expression:");
                context.strategy = getStrategy(line);
                output = "" + context.execute(line);
                Console.WriteLine($"Result: {output}");
            }
        }
    }
}
