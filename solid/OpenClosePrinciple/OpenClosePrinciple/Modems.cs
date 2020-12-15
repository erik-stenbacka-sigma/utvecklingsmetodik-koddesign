using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    enum Modems
    {
        hayes, courrier, ernie, abc
    }

    interface Modem
    {
        void Dial(String username);
    }

    class Hayes : Modem
    {
        public Modems type = Modems.hayes;

        public void Dial(string username)
        {
            Console.WriteLine("Dialing hayes");
        }
    }

    class Courrier : Modem
    {
        public Modems type = Modems.courrier;

        public void Dial(string username)
        {
            Console.WriteLine("Dialing courrier");
        }
    }

    class Ernie : Modem
    {
        public Modems type = Modems.ernie;

        public void Dial(string username)
        {
            Console.WriteLine("Dialing ernie");
        }
    }

    class Abc : Modem
    {
        public Modems type = Modems.abc;

        public void Dial(string username)
        {
            Console.WriteLine("Dialing abc");
        }
    }
}
