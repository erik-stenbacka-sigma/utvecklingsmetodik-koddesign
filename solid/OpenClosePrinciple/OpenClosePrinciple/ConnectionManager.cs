using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    class ConnectionManager
    {
        public void LogOn(Modems type, String username, String pw)
        {
            if (type == Modems.hayes)
            {
                DialHayes(username, pw);
            }
            else if (type == Modems.courrier)
            {
                DialCourrier(username, pw);
            }
            else if (type == Modems.ernie)
            {
                DialErnie(username, pw);
            }
        }

        private void DialHayes(String username, String pw)
        {
            // Do stuff
        }

        private void DialCourrier(String username, String pw)
        {
            // Do stuff
        }

        private void DialErnie(String username, String pw)
        {
            // Do stuff
        }
    }

    class ConnectionManager2
    {
        public void LogOn(Modem modem, String username, String pw)
        {
            modem.Dial(username);
            // more logOn related logic
        }
    }
}
