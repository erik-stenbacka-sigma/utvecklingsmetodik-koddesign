using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincple
{
    class TwitterAPI : IAPI
    {
        public void share(string title, string message)
        {
            Console.WriteLine($"Sharing article to Twitter. {title} - {message}");
        }
    }
}
