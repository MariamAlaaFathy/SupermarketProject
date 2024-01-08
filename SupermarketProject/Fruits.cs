using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketProject
{
    public partial class Fruits : Form
    {
        public Fruits()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] fruits = [Apples.Text, Oranges.Text, Grapes.Text, Strawberries.Text, Guavas.Text, Pineapple.Text, Pears.Text, Mangoes.Text, Banana.Text, Watermelon.Text];
            double[] prices = [2,4,6,10,5,30,3,40,40,40];
            try
            {
                for(int i = 0; i < fruits.Length; i++)
                {
                    ProductForm.cart += Convert.ToDouble(fruits[i]) * prices[i];
                }
                MessageBox.Show("Added to Cart!");
                ProductForm productForm = new ProductForm();
                productForm.Show();
                this.Hide();

            } catch(Exception ex)
            {
                MessageBox.Show("Wrong Inputs!");
            }
        }
    }
}
