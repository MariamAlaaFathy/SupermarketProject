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



namespace SupermarketProject
{
    public partial class CustomerSignUp : Form
    {

        static Customer customer1 = new Customer("Shahd", "Alaa", 2, "shahdalaa@gmail.com", "0122", "elekbal", "shahd1234");
        static Customer customer2 = new Customer("Ahmed", "Abdelrahman", 2, "ahmed@gmail.com", "01232", "elekbaql", "ahmed123");
        static Customer customer3 = new Customer("mohamed", "ayman", 2, "ayman2@gmail.com", "01222", "elekbal", "mohamed123");
        public static List<Customer> customers = [customer1, customer2, customer3];

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
            string email = Email.Text;

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
