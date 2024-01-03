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
    public partial class DairyDetailsForm : Form
    {
        public DairyDetailsForm()
        {
            InitializeComponent();
        }

        private void D2BackButton_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.Show();
            this.Hide();
        }

        private void D2DoneButton_Click(object sender, EventArgs e)
        {
            OpeningForm openingForm = new OpeningForm();
            openingForm.Show();
            this.Hide();
        }
    }
}
