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
    public partial class DrinksDetatilsForm : Form
    {
        public DrinksDetatilsForm()
        {
            InitializeComponent();
        }

        private void DBackButton_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.Show();
            this.Hide();
        }

        private void DDoneButton_Click(object sender, EventArgs e)
        {
            OpeningForm openingForm = new OpeningForm();
            openingForm.Show();
            this.Hide();
        }
    }
}
