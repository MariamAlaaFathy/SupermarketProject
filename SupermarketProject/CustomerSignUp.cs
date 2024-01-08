using Microsoft.VisualBasic.ApplicationServices;
using SupermarketProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Data.SqlClient;
using System.Net;



namespace SupermarketProject
{
    public partial class CustomerSignUp : Form
    {

        /* static Customer customer1 = new Customer("Shahd", "Alaa", 2, "shahdalaa@gmail.com", "0122", "elekbal", "shahd1234");
         static Customer customer2 = new Customer("Ahmed", "Abdelrahman", 2, "ahmed@gmail.com", "01232", "elekbaql", "ahmed123");
         static Customer customer3 = new Customer("mohamed", "ayman", 2, "ayman2@gmail.com", "01222", "elekbal", "mohamed123");
         public static List<Customer> customers = [customer1, customer2, customer3]; */

        public CustomerSignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.Show();
            this.Hide();
        }

        private void Lastname_TextChanged(object sender, EventArgs e)
        {
            string lastname = Lastname.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*   string email = Email.Text;


               if (IsUsernameTaken(email))
               {
                   MessageBox.Show("Email is already taken. Please use another email.");
                   return;
               }
               Customer newCustomer = new Customer("mohamed", "ayman", 5, "ayman@gmail.com", "0122", "elekbal", "hh")
               {
                   Email = email,

                   // Add other user properties as needed
               };
               customers.Add(newCustomer);

               MessageBox.Show("Account created successfully!");

               // Optionally, you can close the signup form or navigate to another form
               this.Close();

               Signupcont signupcont = new Signupcont();
               signupcont.Show();
               this.Hide(); */

            /*  {
                  SqlConnection con = new SqlConnection("Data Source=shahd;Initial Catalog=customerform;Integrated Security=True;Trust Server Certificate=True");
                  SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[customerform]
                  ([firstname]
                  , [lastname]
                  , [age]
                  , [email]
                  , [telephone]
                  , [address]
                  , [password])
                  VALUES('" + Firstname.Text + "', '" + Lastname.Text + "', '" + Email.Text + "', '" + Password.Text + "', '" + Age.Text + "', '" + Address.Text + "', '" + Mobile.Text  + "')", con);
              con.Open();
                  cmd.ExecuteNonQuery();
                  con.Close();
                  MessageBox.Show("welcome");

              } */
            string email = Email.Text;

            if (IsUsernameTaken(email))
            {
                MessageBox.Show("Email is already taken. Please use another email.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=shahd;Initial Catalog=customerform;Integrated Security=True;"))
                {
                    con.Open();
                   /* int customerCount;
                    using (SqlCommand countCmd = new SqlCommand("SELECT COUNT(*) FROM [dbo].[signup]", con))
                    {
                        customerCount = (int)countCmd.ExecuteScalar();
                    }

                    // Generate a customer ID based on the count
                    int newCustomerId = customerCount + 1; */

                    using (SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[signup]
                        ([firstname]
                        , [lastname]
                        , [age]
                        , [email]
                        , [telephone]
                        , [address]
                        , [password])
                        VALUES(@FirstName, @LastName, @Age, @Email, @Mobile, @Address, @Password)", con))
                    {
                        // Use parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@FirstName", Firstname.Text);
                        cmd.Parameters.AddWithValue("@LastName", Lastname.Text);
                        cmd.Parameters.AddWithValue("@Age", Age.Text);
                        cmd.Parameters.AddWithValue("@Email", Email.Text);
                        cmd.Parameters.AddWithValue("@Mobile", Mobile.Text);
                        cmd.Parameters.AddWithValue("@Address", Address.Text);
                        cmd.Parameters.AddWithValue("@Password", Password.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Account created successfully!");
                    Signupcont signupcont = new Signupcont();
                    signupcont.Show();
                    this.Hide(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }

        private void Firstname_TextChanged(object sender, EventArgs e)
        {
            string firstname = Firstname.Text;
            button1.Enabled = !string.IsNullOrEmpty(Firstname.Text);
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            string email = Email.Text;
            button1.Enabled = !string.IsNullOrEmpty(Email.Text);
        }

        private void Age_TextChanged(object sender, EventArgs e)
        {
            string age = Age.Text;
            button1.Enabled = !string.IsNullOrEmpty(Age.Text);
        }

        private void Address_TextChanged(object sender, EventArgs e)
        {
            string address = Address.Text;
            button1.Enabled = !string.IsNullOrEmpty(Address.Text);
        }

        private void Mobile_TextChanged(object sender, EventArgs e)
        {
            string mobile = Mobile.Text;
            button1.Enabled = !string.IsNullOrEmpty(Mobile.Text);
        }
        /* private bool IsUsernameTaken(string email)
          {
              // Check if the username already exists in the list

              return customers.Any(c => c.Email == email);
          } */

        private void showbutton_Click(object sender, EventArgs e)
        {
            Password.PasswordChar = Password.PasswordChar == '\0' ? '*' : '\0';
        }

        private void Password_TextChanged_1(object sender, EventArgs e)
        {
            Password.PasswordChar = '*';
            button1.Enabled = !string.IsNullOrEmpty(Password.Text);
        }
        private bool IsUsernameTaken(string email)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=shahd;Initial Catalog=customerform;Integrated Security=True;"))
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [dbo].[signup] WHERE [email] = @Email", con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        int count = (int)cmd.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while checking if email is taken: " + ex.Message);
                return false; // Handle the error according to your needs
            }
        }

        private void Lastname_TextChanged_1(object sender, EventArgs e)
        {
            string lastname = Lastname.Text;
            button1.Enabled = !string.IsNullOrEmpty(Lastname.Text);
        }
    }
}
