using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class Proxy : getbookdata
    {



        public string getbookName(string name)
        {
            BookDetails bk=new BookDetails();
            return bk.getbookName(name);
        }

        public int getbookPrice(int price)
        {
            BookDetails bk = new BookDetails();
            return bk.getbookPrice(price);
        }
    }
}
