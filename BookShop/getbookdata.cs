using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    //proxy
    interface getbookdata
    {
       string getbookName(string name); 
       int getbookPrice(int price);
    }
}
