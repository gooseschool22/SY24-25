using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quartet
{
    internal class deck
    {
        List<carcard> carcards = new List<carcard>();
        public deck(List<carcard> carcards)
        {
            this.carcards = carcards;
        }
        public void shuffle()
        {
            int n = 0;
            Random rnd = new Random();
            carcard temp = null;
            for (int i = 0; i < carcards.Count; i++) 
            {
                temp = carcards[i];
                n = rnd.Next(carcards.Count);
                carcards[i] = carcards[n];
                carcards[n] = temp;
            }
        }
        public override string ToString()
        {
            string retVal = "Deck:\n";
            foreach (carcard card in carcards)
            {
                retVal += card.ToString();
            }
            return retVal;
        }
        public carcard getcard(int index)
        {
            carcard c = carcards[index];
            carcards.RemoveAt(index);
            return c;
        }

    }
}
