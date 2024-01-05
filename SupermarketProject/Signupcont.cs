using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketProject
{
    public partial class Signupcont : Form
    {
        Customer [] customer=new Customer[3];
        private static int counter;
        public Signupcont()
        {
            customer[0]=new Customer("hh", "mohamed", "ayman", 2, "ayman@gmail.com", "0122", "elekbal");
            customer[1]=new Customer("hh", "moh", "aymn", 2, "ayman1@gmail.com", "01232", "elekbaql");
            customer[2]=new Customer("hh", "mohameds", "aymans", 2, "ayman3@gmail.com", "01222", "elekbal");
            counter=customer.Length+1;
           
            InitializeComponent();
            int newId = GenerateId();
            string r = "Generated ID: " + newId;
            label2.Text = r;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }
        

        public static int GenerateId()
        {
            return counter++;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
