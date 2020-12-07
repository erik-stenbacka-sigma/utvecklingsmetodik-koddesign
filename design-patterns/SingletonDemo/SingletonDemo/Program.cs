using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Book>();
            list.Add(new Book("Book A"));
            list.Add(new Book("Book B"));
            list.Add(new Book("Book C"));

            list.ForEach(b => b.PrintDescription());
            Console.Read(); // prevent exit
        }
    }
}
