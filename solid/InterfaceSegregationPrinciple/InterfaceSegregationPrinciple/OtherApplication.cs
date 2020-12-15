using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceSegregationPrinciple;

namespace InterfaceSegregationPrinciple_App2
{
    class OtherApplication
    {
        public void DoWork()
        {
            var impl = new Implementation2();
            var app = new Application(impl);
            app.DoOtherWork();
        }
    }

    class Implementation2 : GeneralInterface
    {
        public List<string> getListTweets()
        {
            return new List<string>();
        }

        public string getWeatherForecast()
        {
            throw new NotImplementedException();
        }
    }
}
