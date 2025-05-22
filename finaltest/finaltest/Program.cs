using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finaltest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            book wf = new book("White Fang", "Jack London", "978-1505313109", 2019, true);
            book fort = new book("Fortnite Battle Royale Hacks", "Jason Rich", "978-1234567897", 2018, true);
            fort.displaybookinfo();
            wf.displaybookinfo();
            wf.checkout();
            wf.checkout();
            wf.returnbook();
            wf.returnbook();
            wf.displaybookinfo();


            Console.ReadLine();
        }
    }
}
