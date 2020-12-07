using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class IdGenerator
    {
        private static IdGenerator instance;
        private int counter = 0;

        private IdGenerator()
        {
            // Prevent external instances
        }

        public int nextId()
        {
            return counter++;
        }

        public static IdGenerator getInstance()
        {
            if (instance == null)
            {
                instance = new IdGenerator();
            }
            return instance;
        }
    }
}
