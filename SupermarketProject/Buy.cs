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
    public partial class Buy : Form
    {
        public Buy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void no_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.Show();
            this.Hide();
        }

        private void yes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for purchasing!","Purchase complete");
            OpeningForm openingForm = new OpeningForm();
            openingForm.Show();
            this.Hide();
        }
    }
}
