using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class BookDetails : getbookdata
    {
        //proxy
        public string getbookName(string name)
        {
            return name;
        }

        public int getbookPrice(int price)
        {
            return price;
        }
    }
}
