using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quartet
{
    public class hand
    {
        List<carcard> carcards = new List<carcard>();
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
