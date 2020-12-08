using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    interface Command
    {
        void execute();
    }

    class WebRequestCommand : Command
    {
        private String line;
        API api;

        public WebRequestCommand(API api, String line)
        {
            this.line = line;
            this.api = api;
        }

        public void execute()
        {
            var data1 = api.getData(line);
            Console.WriteLine($"Got data: {data1}");
        }
    }
}
