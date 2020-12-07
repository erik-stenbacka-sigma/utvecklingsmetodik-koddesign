using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDemo
{
    interface Subscriber
    {
        void InventityChange(String wareName, int newQuantity);
    }

    class Warehouse
    {
        private Dictionary<String, int?> wares;
        private List<Subscriber> subscribers;

        public Warehouse()
        {
            this.wares = new Dictionary<string, int?>();
            this.subscribers = new List<Subscriber>();
        }

        public void subscribe(Subscriber s)
        {
            subscribers.Add(s);
        }

        public void unsubscribe(Subscriber s)
        {
            subscribers.Remove(s);
        }

        private void notify(String wareName, int quantity)
        {
            subscribers.ForEach(s => s.InventityChange(wareName, quantity));
        }

        public void addWare(String name, int quantity)
        {
            var ware = this.wares.ContainsKey(name) ? this.wares[name] : null;
            if (ware == null)
            {
                this.wares[name] = quantity;
            }
            else
            {
                this.wares[name] += quantity;
            }
            notify(name, (int)wares[name]);
        }

        public void removeWare(String name, int quantity)
        {
            var ware = this.wares[name];
            if (ware == null)
            {
                throw new Exception("Requested ware does not exist");
            }
            else
            {
                this.wares[name] -= quantity;
            }
            notify(name, (int)wares[name]);
        }

        public void Describe()
        {
            Console.WriteLine($"Warehouse inventory: {wares}");
        }
    }
}
