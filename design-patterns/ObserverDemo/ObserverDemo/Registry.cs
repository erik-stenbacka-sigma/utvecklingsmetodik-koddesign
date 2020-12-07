using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    class Registry: Subscriber
    {
        public void InventityChange(string wareName, int newQuantity)
        {
            PrintWareQuanty(wareName, newQuantity);
        }

        public void PrintWareQuanty(String name, int count)
        {
            Console.WriteLine($"Ware {name} has quanty {count}");
        }
    }
}
