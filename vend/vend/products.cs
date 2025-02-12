using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vend
{
    internal class products
    {
        public slot cs = new slot();
        Dictionary<string, int> merch = new Dictionary<string, int>();
        public void addproduct(string product, int count)
        {
            merch.Add(product, count);
        }
        public bool buy(string product, double price) 
        {
            if (cs.totaltotal() > price)
            {
                cs.buy(price);
                merch[product]--;
            }
            return merch[product] > 0;
        }
    }
}
