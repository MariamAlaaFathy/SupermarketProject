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
    public partial class FruitsDetailsForm : Form
    {
        Supplier[] suppliers = new Supplier[4];
        string[] fruitsStock;
        public FruitsDetailsForm()
        {
            suppliers[0] = new Supplier("Orchard Delights", "Fruits", 1000);
            suppliers[1] = new Supplier("Veggie Visions", "Vegetables", 1000);
            suppliers[2] = new Supplier("Liquid Refreshing", "Drinks", 1000);
            suppliers[3] = new Supplier("Boundless Milk", "Dairy", 1000);
            suppliers[SupplierForm.index].Stock = Convert.ToInt32(SupplierForm.newstock);
            InitializeComponent();
        }

        private void FBackButton_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.Show();
            this.Hide();
        }

        private void FDoneButton_Click(object sender, EventArgs e)
        {
            fruitsStock = [ApplesTextBox.Text, OrangesTextBox.Text, GrapesTextBox.Text, SBTextBox.Text, GuavasTextBox.Text, WMTextBox.Text, PATextBox.Text, MangoesTextBox.Text, BananasTextBox.Text, PearsTextBox.Text];
            int totalstock = 0;
            for(int i = 0; i < 10; i++)
            {
                totalstock += Convert.ToInt32(fruitsStock[i]);
            }
            if(totalstock == suppliers[SupplierForm.index].Stock) {

                MessageBox.Show("Stock is Saved!");
                OpeningForm openingForm = new OpeningForm();
                openingForm.Show();
                this.Hide();
            } else
            {
                
                if(MessageBox.Show("This stock is not equal to the original stock.\nDo you want to change the stock?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    suppliers[SupplierForm.index].Stock = totalstock;
                    MessageBox.Show("Stock is Saved!");
                    OpeningForm openingForm = new OpeningForm();
                    openingForm.Show();
                    this.Hide();
                } else
                {
                    MessageBox.Show("Stock was not Changed.");
                    OpeningForm openingForm = new OpeningForm();
                    openingForm.Show();
                    this.Hide();
                }
            }
        }
    }
}
