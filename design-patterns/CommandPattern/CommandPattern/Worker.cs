using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CommandPattern
{
    class Worker
    {
        private Queue<Command> queue = new Queue<Command>();
        public bool keepRunning = true;

        public void DoWork()
        {
            while (keepRunning)
            {
                if (queue.Count > 0)
                {
                    var command = queue.Dequeue();
                    command.execute();
                } else
                {
                    Thread.Sleep(500);
                }
            }
        }

        public void AddCommand(Command command)
        {
            queue.Enqueue(command);
        }

        public static Worker StartWorker()
        {
            var worker = new Worker();
            var thread = new Thread(new ThreadStart(worker.DoWork));
            thread.Start();
            return worker;
        }
    }
}
