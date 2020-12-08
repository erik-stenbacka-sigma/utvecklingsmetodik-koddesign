using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = Worker.StartWorker();
            var api = new API();

            String line;
            while ((line = Console.ReadLine()) != "") {
                Console.WriteLine($"Fetching data for {line}");
                var command = new WebRequestCommand(line);
                worker.AddCommand(command);
            }

            Console.Read();
            worker.keepRunning = false;
        }
    }
}
