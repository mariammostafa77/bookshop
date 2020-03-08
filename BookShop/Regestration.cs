using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookShop
{
    public partial class Regestration : Form
    {
        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-7C8TE05;DataBase=BookShop;Integrated Security=true");
        SqlCommand cmd;
        public Regestration()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Name required!");
            }
        
            else
            {
                errorProvider1.SetError(txtName, null);
            }
        
    }

        private void txtEmail1_Validating(object sender, CancelEventArgs e)

        {
           
            if (string.IsNullOrEmpty(txtEmail1.Text))
        {
            errorProvider1.SetError(txtEmail1, "Email required!");
        }
        else
        {
            errorProvider1.SetError(txtEmail1, null);
        }
    
}

        private void txtPass_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                errorProvider1.SetError(txtPass, "Password required!");
            }
            else
            {
                errorProvider1.SetError(txtPass, null);
            }
        }

        private void regester_Click(object sender, EventArgs e)
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
                if (string.IsNullOrEmpty(txtEmail1.Text))
                {
                    errorProvider1.SetError(txtEmail1, "Email required!");
                }
                else
                {
                    errorProvider1.SetError(txtEmail1, null);
                }
                if (string.IsNullOrEmpty(txtPass.Text))
                {
                    errorProvider1.SetError(txtPass, "Password required!");
                }
                else
                {
                    errorProvider1.SetError(txtPass, null);
                }
                string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";


                bool isEmailValid = Regex.IsMatch(txtEmail1.Text, emailPattern);


                if (!isEmailValid)
                {
                    MessageBox.Show("Please enter a valid email");

                }
                else
                {
                    cmd = new SqlCommand("Insert into users(Name, Email, UserPassword) values('" + txtName.Text + "', '" + txtEmail1.Text + "','" + txtPass.Text + "')", cn);
                    cn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("you are regester");
                    cn.Close();
                    LogIn log = new LogIn();
                    this.Hide();
                    log.Show();
                }
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

        private void exit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            this.Hide();
            log.Show();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            insert i = new insert();
            i.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            insert i = new insert();
            i.Show();
        }
    }
            
    }
