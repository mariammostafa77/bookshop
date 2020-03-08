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
    public partial class Home : Form
    {
        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-7C8TE05;DataBase=BookShop;Integrated Security=true");
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        SqlCommandBuilder cmdb;
        private object name;

        public Home()
        {
            InitializeComponent();
            da = new SqlDataAdapter("select ID,Name,Price,Section,Quantity from BookDetails", cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;



        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click_1(object sender, EventArgs e)
        {
          
            Edit edit = new Edit();
            this.Hide();
            edit.Show();

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            this.Hide();
            add.Show();
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
         
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            dt.Clear();
            da = new SqlDataAdapter("select ID,Name,Price,Section,Quantity from BookDetails", cn);
            da.Fill(dt);
             dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Sure you wanna delete?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                    {
                        dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                    }
                    cmdb = new SqlCommandBuilder(da);
                    da.Update(dt);



                }


            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            //    Products.Items.Add(row.Cells["NAME"].Value.ToString());
            //    Prices.Items.Add(row.Cells["PRICE"].Value.ToString());

            //}
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int x = comboBox1.SelectedIndex;
            Factory[] objFactories = new Factory[1];
            switch (x)
            {
                case 0:
                    dataGridView1.DataSource = null;
                    da = new SqlDataAdapter("select ID,Name,Price,Section,Quantity from BookDetails", cn);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    break;
                /*case 1:
                    dataGridView1.DataSource = null;
                    objFactories[0] = new ConcreateFactoryBookHorror();
                    foreach (Factory ob in objFactories)
                    {
                        BooksAbstract objProduct = ob.GetProduct();
                        objProduct.GetDetails();
                    }
                    dataGridView1.DataSource = objFactories[0];
                    break;
                case 2:
                    dataGridView1.DataSource = null;
                    objFactories[1] = new ConcreateFactoryBookRomantic();
                    foreach (Factory ob in objFactories)
                    {
                        BooksAbstract objProduct = ob.GetProduct();
                        objProduct.GetDetails();
                    }
                    break;*/
                case 1:
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = "";
                    BooksAbstract v = new RomanticBooksAbstract();
                    da = new SqlDataAdapter("select ID,Name,Price,Section,Quantity from BookDetails where Section='Romantic'", cn);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;

                    break;
                case 2:
                    dataGridView1.DataSource = null;
                    BooksAbstract b = new HorrorBooksAbstract();
                    da = new SqlDataAdapter("select ID,Name,Price,Section,Quantity from BookDetails where Section='Horror'", cn);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    break;

                default:
                    {
                        MessageBox.Show("***");
                        break;
                    }
            }


        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        
        }

        private void Home_Load(object sender, EventArgs e)
        {
            disp_data();
        }
        public void disp_data()
        {
            cn.Open();
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from BookDetails";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            cn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                Products.Items.Add(row.Cells["NAME"].Value.ToString());
                Prices.Items.Add(row.Cells["PRICE"].Value.ToString());



            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            double c = 0;
            for (int i = 0; i < Prices.Items.Count; i++)
            {
                double a = Convert.ToDouble(Prices.Items[i].ToString());
                double b = 0;
                if (i == 0)
                {

                    b = a * Convert.ToDouble(textBox1.Text);
                }
                else if (i == 1)
                {
                    b = a * Convert.ToDouble(textBox2.Text);
                }
                else if (i == 2)
                {
                    b = a * Convert.ToDouble(textBox3.Text);
                }
                else if (i == 3)
                {
                    b = a * Convert.ToDouble(textBox4.Text);
                }
                else if (i == 4)
                {
                    b = a * Convert.ToDouble(textBox5.Text);
                }
                else if (i == 5)
                {
                    b = a * Convert.ToDouble(textBox6.Text);
                }
                else if (i == 6)
                {
                    b = a * Convert.ToDouble(textBox7.Text);
                }
                else if (i == 7)
                {
                    b = a * Convert.ToDouble(textBox8.Text);
                }
                else if (i == 8)
                {
                    b = a * Convert.ToDouble(textBox9.Text);
                }
                c = c + b;
            }

            lt.Text = Convert.ToString(c) + "$";
        }

        private void invoice_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            if (Products.Items.Count == 10)
            {


                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Products.Items[3].ToString(), Products.Items[4].ToString(), Products.Items[5].ToString(), Products.Items[6].ToString(), Products.Items[7].ToString(), Products.Items[8].ToString(), Products.Items[9].ToString(), Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(), Prices.Items[3].ToString(), Prices.Items[4].ToString(), Prices.Items[5].ToString(), Prices.Items[6].ToString(), Prices.Items[7].ToString(), Prices.Items[8].ToString(), Prices.Items[9].ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text,lt.Text);
                r.ShowDialog();
                
            }
            if (Products.Items.Count == 9)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Products.Items[3].ToString(), Products.Items[4].ToString(), Products.Items[5].ToString(), Products.Items[6].ToString(), Products.Items[7].ToString(), Products.Items[8].ToString(), Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(), Prices.Items[3].ToString(), Prices.Items[4].ToString(), Prices.Items[5].ToString(), Prices.Items[6].ToString(), Prices.Items[7].ToString(), Prices.Items[8].ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, lt.Text);
                r.ShowDialog();
            }

            if (Products.Items.Count == 8)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Products.Items[3].ToString(), Products.Items[4].ToString(), Products.Items[5].ToString(), Products.Items[6].ToString(), Products.Items[7].ToString(), Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(), Prices.Items[3].ToString(), Prices.Items[4].ToString(), Prices.Items[5].ToString(), Prices.Items[6].ToString(), Prices.Items[7].ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, lt.Text);
                r.ShowDialog();
            }

            if (Products.Items.Count == 7)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Products.Items[3].ToString(), Products.Items[4].ToString(), Products.Items[5].ToString(), Products.Items[6].ToString(), Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(), Prices.Items[3].ToString(), Prices.Items[4].ToString(), Prices.Items[5].ToString(), Prices.Items[6].ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, lt.Text);
                r.ShowDialog();
            }
            if (Products.Items.Count == 6)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Products.Items[3].ToString(), Products.Items[4].ToString(), Products.Items[5].ToString(),  Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(), Prices.Items[3].ToString(), Prices.Items[4].ToString(), Prices.Items[5].ToString(),  textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, lt.Text);
                r.ShowDialog();
            }
            if (Products.Items.Count == 5)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Products.Items[3].ToString(), Products.Items[4].ToString(),  Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(), Prices.Items[3].ToString(), Prices.Items[4].ToString(), textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, lt.Text);
                r.ShowDialog();
            }
            if (Products.Items.Count == 4)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Products.Items[3].ToString(),  Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(), Prices.Items[3].ToString(),  textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, lt.Text);
                r.ShowDialog();
            }
            if (Products.Items.Count == 3)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Products.Items[2].ToString(), Prices.Items[0].ToString(), Prices.Items[1].ToString(), Prices.Items[2].ToString(),  textBox1.Text, textBox2.Text, textBox3.Text, lt.Text);
                r.ShowDialog();
            }
            if (Products.Items.Count == 2)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(), Products.Items[1].ToString(), Prices.Items[0].ToString(), Prices.Items[1].ToString(), textBox1.Text, textBox2.Text, lt.Text);
                r.ShowDialog();
            }
            if (Products.Items.Count == 1)
            {
                Invoice r = new Invoice(Products.Items[0].ToString(),  Prices.Items[0].ToString(), textBox1.Text, lt.Text);
                r.ShowDialog();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
