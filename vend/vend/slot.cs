using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vend
{
    internal class slot
    {
        public double total;
        public slot() { }
        public void slotclear()
        {
            total = 0;
        }
        public void insertcoin(object coin)
        { 
            if (coin == "quarter") total += 0.25;
            if (coin == "dime") total += 0.10;
            if (coin == "nickel") total += 0.05;
            if (coin == "penny") total += 0.01;
        }
        public double totaltotal() { return total; }
        public void buy(double p)
        {
            total -= p;
        }
    }
}
