using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace BookShop
{
    public partial class insert : Form
    {
        public insert()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-7C8TE05;DataBase=BookShop;Integrated Security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        getbookdata bb = new BookDetails();
        getbookdata b = new Proxy();
        private void button1_Click(object sender, EventArgs e)
        {
            //cmd = new SqlCommand("select Name from BookDetails", cn);
            cn.Open();
            //dr = cmd.ExecuteReader();
            //dr.Read();




            string query = "select * from BookDetails";
            SqlDataAdapter sda = new SqlDataAdapter(query, cn);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            foreach (DataRow dr in dt.Rows) {
                listBox1.Items.Add(b.getbookName(dr["Name"].ToString())+"  "+b.getbookName(dr["Price"].ToString()));
                //listBox1.Items.Add(b.getbookName(dr["Price"].ToString()));
                //listBox1.Items.Add(dr["Quantity"].ToString());
            }


            //listBox1.Text = b.getbookName(dr["Name"].ToString());
            //label1.Text = b.getbookName(dr["Name"].ToString());
            //label2.Text =b.getbookPrice(dr[Price].ToString());

           
            //dr.Close();
            cn.Close();
        }
       

        private void insert_Load(object sender, EventArgs e)
        {
            




        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameRepository n = new NameRepository();
            for (Iterator iterator = n.getIterator(); iterator.hasNext();)
            {
                listBox2.Items.Add((string)iterator.next());
            } 

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
