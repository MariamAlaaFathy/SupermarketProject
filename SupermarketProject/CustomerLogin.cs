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

namespace SupermarketProject
{
    public partial class CustomerLogin : Form
    {
        public CustomerLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*  for(int i = 0; i < 3; i++)
              {
                  if(customerID.Text == CustomerSignUp.customers[i].CustomorID.ToString() && Password2.Text == CustomerSignUp.customers[i].Password.ToString())
                  {
                      MessageBox.Show("Login Successfully!");
                      ProductForm productForm = new ProductForm();
                      productForm.Show();
                      this.Hide();
                      return;
                  } 
              }*/

            //MessageBox.Show("Wrong ID or Passowrd");
            string email = customerID.Text; // Assuming the input field is for the email
            string password = Password2.Text;

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=shahd;Initial Catalog=customerform;Integrated Security=True;"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [dbo].[signup] WHERE [email] = @Email AND [password] = @Password", con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Login Successfully!");
                            ProductForm productForm = new ProductForm();
                            productForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Email or Password");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            this.Hide();
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            Password2.PasswordChar = Password2.PasswordChar == '\0' ? '*' : '\0';
        }

        private void Password2_TextChanged(object sender, EventArgs e)
        {
            Password2.PasswordChar = '*';
        }
    }
}
