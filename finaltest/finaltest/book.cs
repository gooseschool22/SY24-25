using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finaltest
{
    internal class book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string ISBN { get; set; }
        public int publicationyear { get; set; }
        public bool isavailable { get; set; }

        public book(string title, string author, string iSBN, int publicationyear, bool isavailable)
        {
            this.title = title;
            this.author = author;
            ISBN = iSBN;
            this.publicationyear = publicationyear;
            this.isavailable = isavailable;
        }
        public void displaybookinfo()
        {
            string yesno;
            if (isavailable == true) { yesno = "Yes"; } else yesno = "No";
            Console.WriteLine("Title: " + title + ", Author: " + author + ", ISBN: " + ISBN + ", Year: " + publicationyear + ", Available: " + yesno);
        }
        public void checkout()
        {
            
            if (isavailable == false)
            {
                Console.WriteLine(title + " is already checked out");
            }
            if (isavailable == true) 
            { 
                Console.WriteLine(title + " was checked out successfully");
                isavailable = false;
            }
        }
        public void returnbook()
        {
            if (isavailable == true) { Console.WriteLine(title + " is already available"); }
            
            if (isavailable == false)
            {
                Console.WriteLine(title + " returned successfully");
                isavailable = true;
            }
        }
    }
}
