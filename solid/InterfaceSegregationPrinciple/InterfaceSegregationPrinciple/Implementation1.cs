using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceSegregationPrinciple;

namespace InterfaceSegregationPrinciple_App1
{
    internal class Implementation1 : GeneralInterface
    {
        public List<string> getListTweets()
        {
            return new List<String>();
        }

        public string getWeatherForecast()
        {
            return "sunny";
        }
    }
}
