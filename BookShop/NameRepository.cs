using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class NameRepository : Container
    {
        insert insert = new insert();
       
       public static string []names = { "Secret Message", "Cendrela Secrete", "Boys Over Flowers", "BTS"};
        


      //  public static string[] names = { "select Name,Price from BooksDetails" };
        public Iterator getIterator()
        {
            return new NameIterator();
        }
        private class NameIterator:Iterator
        {
            int index;

            public bool hasNext()
            {
                if(index < names.Length)
                { return true; }
                return false;
            }

            public object next()
            {
              if(this.hasNext())
                { return names[index++]; }
                return null;
            }
        }
    }
    
}
