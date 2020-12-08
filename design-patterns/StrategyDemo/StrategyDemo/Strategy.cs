using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDemo
{
    interface Strategy
    {
        int execute(int n1, int n2);
    }

    class PlusStrategy : Strategy
    {
        public int execute(int n1, int n2)
        {
            return n1 + n2;
        }
    }

    class MinusStrategy : Strategy
    {
        public int execute(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
