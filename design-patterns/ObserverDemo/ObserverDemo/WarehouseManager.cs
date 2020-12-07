using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    class WarehouseManager : Subscriber
    {
        private void BuyNewProduct(String name)
        {
            Console.WriteLine($"I need to buy new {name}");
        }
        public void InventityChange(string wareName, int newQuantity)
        {
            if (newQuantity < 10)
            {
                BuyNewProduct(wareName);
            }
        }
    }
}
