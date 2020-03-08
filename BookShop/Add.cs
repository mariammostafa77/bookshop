using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class Add : Form
    {
        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-7C8TE05;DataBase=BookShop;Integrated Security=true");
        SqlCommand cmd;
        Home home = new Home();
        public Add()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text))
                {
                    errorProvider1.SetError(txtName, "Name required!");
                }
                else
                {
                    errorProvider1.SetError(txtName, null);
                }
                if (string.IsNullOrEmpty(txtPrice.Text))
                {
                    errorProvider1.SetError(txtPrice, "Price required!");
                }
                else
                {
                    errorProvider1.SetError(txtPrice, null);
                }
                if (string.IsNullOrEmpty(txtQuantity.Text))
                {
                    errorProvider1.SetError(txtQuantity, "Quantity required!");
                }
                else
                {
                    errorProvider1.SetError(txtQuantity, null);
                }
                cmd = new SqlCommand("Insert into BookDetails(Name, Price, Quantity) values('" + txtName.Text + "', '" + txtPrice.Text + "','" + txtQuantity.Text + "')", cn);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("added successfuly");
                txtName.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "";


            }
            catch
            {
                MessageBox.Show("some error was occured");
            }
            finally
            {
                cn.Close();
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
