using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincple
{
    class FacebookAPI : IAPI
    {
        public void share(String title, String message)
        {
            Console.WriteLine($"Sharing article to Facebook. {title} - {message}");
        }
    }
}
