using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketProject
{
    public partial class ProductForm : Form
    {
        public static double cart = 0;
        public ProductForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Fruits fruits = new Fruits();
            fruits.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VegetablesDesign design = new VegetablesDesign();
            design.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DrinksDesign drinkdesign = new DrinksDesign();
            drinkdesign.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dairy dairy = new Dairy();
            dairy.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy();
            buy.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OpeningForm openingForm = new OpeningForm();
            openingForm.Show();
            this.Hide();
        }
    }
}
