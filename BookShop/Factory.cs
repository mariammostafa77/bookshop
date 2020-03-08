using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
     abstract class Factory
    {
        public abstract BooksAbstract GetProduct();
    }
}
