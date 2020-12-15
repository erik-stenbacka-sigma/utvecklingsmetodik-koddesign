using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class Program
    {
        private static Modem currentModem = new Abc();

        static void Main(string[] args)
        {
            var connectionManager = new ConnectionManager2();
            connectionManager.LogOn(currentModem, "username", "password");

            Console.Read();
        }
    }
}
