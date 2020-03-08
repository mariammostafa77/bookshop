using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop
{
    class HorrorBooksAbstract : BooksAbstract
    {
        public void GetDetails()
        {
            SqlConnection cn = new SqlConnection(@"Server=DESKTOP-7C8TE05;DataBase=BookShop;Integrated Security=true");
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            SqlCommandBuilder cmdb;
            da = new SqlDataAdapter("select ID,Name,Price,Section,Quantity from BookDetails where Section='Horror'", cn);
            da.Fill(dt);
        }
    }
}
