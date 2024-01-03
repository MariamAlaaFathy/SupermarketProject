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
    public partial class VegetablesDetailsForm : Form
    {
        public VegetablesDetailsForm()
        {
            InitializeComponent();
        }

        private void VBackButton_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.Show();
            this.Hide();
        }

        private void VDoneButton_Click(object sender, EventArgs e)
        {
            OpeningForm openingForm = new OpeningForm();
            openingForm.Show();
            this.Hide();
        }
    }
}
