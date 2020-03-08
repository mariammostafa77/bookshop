using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShop
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnlogIn_Click(object sender, EventArgs e)
        {

            
             
                if (string.IsNullOrEmpty(txtEmail2.Text))
                {
                    errorProvider1.SetError(txtEmail2, "Email required!");
                }
                else
                {
                    errorProvider1.SetError(txtEmail2, null);
                }
                if (string.IsNullOrEmpty(txtPass2.Text))
                {
                    errorProvider1.SetError(txtPass2, "Password required!");
                }
                else
                {
                    errorProvider1.SetError(txtPass2, null);
                try
                {
                    string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";


                    bool isEmailValid = Regex.IsMatch(txtEmail2.Text, emailPattern);


                    if (!isEmailValid)
                    {
                        MessageBox.Show("Please enter a valid email");

                    }
                    else
                    {
                        SqlConnection cn = new SqlConnection(@"Server=DESKTOP-7C8TE05;DataBase=BookShop;Integrated Security=true");
                        string query = "select * from users where Email='" + txtEmail2.Text.Trim() + "' and UserPassword='" + txtPass2.Text.Trim() + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(query, cn);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count == 1)
                        {
                            Home home = new Home();
                            this.Hide();
                            home.Show();
                        }
                        else
                        {
                            MessageBox.Show("check your email or password");
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("errror");
                }
            }

           
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
