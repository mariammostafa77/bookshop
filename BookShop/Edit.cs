using System;
using System.Collections.Generic;
using System.Collections;
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
    public partial class Edit : Form
    {
       
        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-7C8TE05;DataBase=BookShop;Integrated Security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        public Edit()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            cmd = new SqlCommand("select Name,Price,Quantity from BookDetails where ID='" + txtID.Text+"'",cn);
            cn.Open();
            dr = cmd.ExecuteReader();
            dr.Read();
            txtName.Text = dr["Name"].ToString();
            txtPrice.Text = dr["Price"].ToString();
            txtQuantity.Text = dr["Quantity"].ToString();
            dr.Close();
            cn.Close();
            }
            catch
            {
                MessageBox.Show("Not Found");
            }
            finally
            {
                dr.Close();
                cn.Close();
            }
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
            
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            cmd = new SqlCommand("update BookDetails set Name='" + txtName.Text + "' , price='"+txtPrice.Text+"',Quantity='"+txtQuantity.Text+"' where ID='"+txtID.Text+"'",cn);
            cn.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated successfully");
                txtID.Text = "";
                txtName.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "";

            }
            catch
            {
                MessageBox.Show("some thing is wrong");
            }
            finally
            {
                cn.Close();
            }


        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
