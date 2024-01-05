using Microsoft.VisualBasic.ApplicationServices;
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

namespace SupermarketProject
{
    public partial class CustomerSignUp : Form
    {
        private List<Customer> customers = new List<Customer>();



        public CustomerSignUp()
        {
            customers.Add(new Customer("hh", "mohamed", "ayman", 2, "ayman@gmail.com", "0122", "elekbal"));
            customers.Add(new Customer("hh", "moh", "aymn", 2, "ayman1@gmail.com", "01232", "elekbaql"));
            customers.Add(new Customer("hh", "mohameds", "aymans", 2, "ayman2@gmail.com", "01222", "elekbal"));
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerForm form = new CustomerForm();
            form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Lastname_TextChanged(object sender, EventArgs e)
        {
            string lastname = Lastname.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CustomerSignUp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = Email.Text;

            if (IsUsernameTaken(username))
            {
                MessageBox.Show("Username is already taken. Please choose another username.");
                return;
            }
            Customer newCustomer = new Customer("hh", "mohamed", "ayman", 5, "ayman@gmail.com", "0122", "elekbal")
            {
                Email = username,

                // Add other user properties as needed
            };
            customers.Add(newCustomer);

            MessageBox.Show("Account created successfully!");

            // Optionally, you can close the signup form or navigate to another form
            this.Close();

            Signupcont signupcont = new Signupcont();
            signupcont.Show();
            this.Hide();
        }

        private void Firstname_TextChanged(object sender, EventArgs e)
        {
            string firstname = Firstname.Text;
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            string email = Email.Text;
        }

        private void Age_TextChanged(object sender, EventArgs e)
        {
            string age = Age.Text;
        }

        private void Address_TextChanged(object sender, EventArgs e)
        {
            string address = Address.Text;
        }

        private void Mobile_TextChanged(object sender, EventArgs e)
        {
            string mobile = Mobile.Text;
        }
        private bool IsUsernameTaken(string email)
        {
            // Check if the username already exists in the list

            return customers.Any(c => c.Email == email);
        }

        private void showbutton_Click(object sender, EventArgs e)
        {
            Password.PasswordChar = Password.PasswordChar == '\0' ? '*' : '\0';
        }

        private void Password_TextChanged_1(object sender, EventArgs e)
        {
            Password.PasswordChar = '*';
        }
    }
}
