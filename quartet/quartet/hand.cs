using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quartet
{
    internal class hand
    {
        List<carcard> carcards;
        public carcard topcard()
        {
            return carcards[0];
        }
        public void add(carcard carcard)
        {
            carcards.Add(carcard);
        }
    }
}
