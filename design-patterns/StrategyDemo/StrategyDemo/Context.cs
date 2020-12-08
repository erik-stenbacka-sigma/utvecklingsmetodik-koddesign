using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDemo
{
    class Context
    {
        public Strategy strategy;

        public int execute(String line)
        {
            var numbers = line.Substring(2).Split(' ');
            return strategy.execute(Int32.Parse(numbers[0]), Int32.Parse(numbers[1]));
        }
    }
}
