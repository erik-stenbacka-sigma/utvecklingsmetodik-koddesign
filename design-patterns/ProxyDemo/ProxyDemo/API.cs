using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ProxyDemo
{
    interface IAPI
    {
        String getData(String id);
    }

    class API : IAPI
    {
        public String getData(String id)
        {
            Thread.Sleep(5000);
            return $"some data {id}";
        }
    }
}
