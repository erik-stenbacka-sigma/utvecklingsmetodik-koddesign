using InterfaceSegregationPrinciple_App1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var implementation1 = new Implementation1();
            var app1 = new Application(implementation1);
            app1.DoWork();


        }
    }

    class Application
    {
        private GeneralInterface api;

        public Application(GeneralInterface api)
        {
            this.api = api;
        }

        public void DoWork()
        {
            api.getWeatherForecast();
        }

        public void DoOtherWork()
        {
            api.getListTweets();
        }
    }
}
