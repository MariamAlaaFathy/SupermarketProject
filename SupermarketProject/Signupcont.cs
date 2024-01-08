using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        private int customerId;
        public Signupcont()
        {
            InitializeComponent();
             customerId = CalculateCustomerId();
            label2.Text = "Customer ID: " + customerId;
           //  label2.Text = label2.Text + Customer.customerNo;
           // CalculateCustomerId();
        }
        private int CalculateCustomerId()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=shahd;Initial Catalog=customerform;Integrated Security=True;"))
                {
                    con.Open();

                    // Generate a unique customer ID using ROW_NUMBER
                    int uniqueCustomerId = 0;
                    using (SqlCommand generateIdCmd = new SqlCommand("SELECT TOP 1 ROW_NUMBER() OVER (ORDER BY (SELECT NULL)) AS CustomerID FROM [dbo].[signup] ORDER BY CustomerID DESC", con))
                    {
                        var result = generateIdCmd.ExecuteScalar();
                        if (result != null && result != DBNull.Value)
                        {
                            uniqueCustomerId = Convert.ToInt32(result);
                        }
                    }

                    return uniqueCustomerId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while generating customer ID: " + ex.Message);
                // Handle the error according to your needs
                return -1; // or any default value indicating an error
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }
    }
}
