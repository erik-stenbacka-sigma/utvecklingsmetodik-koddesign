using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    interface GeneralInterface
    {
        string getWeatherForecast();
        List<string> getListTweets();
    }
}
