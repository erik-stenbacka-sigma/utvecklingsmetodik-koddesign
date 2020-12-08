using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyDemo
{
    class CachingProxy : IAPI
    {
        private API realService;
        private Dictionary<String, String> cache = new Dictionary<String, String>();

        public CachingProxy(API api)
        {
            this.realService = api;
        }

        public string getData(string id)
        {
            if (cache.ContainsKey(id))
            {
                return cache[id];
            }
            else
            {
                var result = realService.getData(id);
                cache[id] = result;
                return result;
            }
        }
    }
}
