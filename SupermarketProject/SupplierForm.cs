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
    public partial class SupplierForm : Form
    {
        public SupplierForm()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OpeningForm openingForm = new OpeningForm();
            openingForm.Show();
            this.Hide();
        }

        private void DetailsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
