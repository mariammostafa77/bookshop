using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class ConcreateFactoryBookRomantic:Factory
    {
        public override BooksAbstract GetProduct()
        {
            return new RomanticBooksAbstract();
        }
    }
}
