using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Book
    {
        private String name;
        private int id;

        public Book(String name)
        {
            this.name = name;
            this.id = IdGenerator.getInstance().nextId();
        }

        public void PrintDescription()
        {
            Console.WriteLine($"Book: {name} with id {id}");
        }
    }
}
