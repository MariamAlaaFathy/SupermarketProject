using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SupermarketProject
{
    public partial class DrinksDetailsForm : Form
    {
        Supplier[] suppliers = new Supplier[4];
        string[] drinksStock;
        public DrinksDetailsForm()
        {
            suppliers[0] = new Supplier("Orchard Delights", "Fruits", 1000);
            suppliers[1] = new Supplier("Veggie Visions", "Vegetables", 1000);
            suppliers[2] = new Supplier("Liquid Refreshing", "Drinks", 1000);
            suppliers[3] = new Supplier("Boundless Milk", "Dairy", 1000);
            suppliers[SupplierForm.index].Stock = Convert.ToInt32(SupplierForm.newstock);
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
            try
            {
                drinksStock = [WaterTextBox.Text, SWTextBox.Text, JuiceTextBox.Text, SodaTextBox.Text, TeaTextBox.Text, CoffeeTextBox.Text];
                int totalstock = 0;
                for (int i = 0; i < 6; i++)
                {
                    totalstock += Convert.ToInt32(drinksStock[i]);
                }
                if (totalstock == suppliers[SupplierForm.index].Stock)
                {

                    MessageBox.Show("Stock is Saved!");
                    OpeningForm openingForm = new OpeningForm();
                    openingForm.Show();
                    this.Hide();
                }
                else
                {

                    if (MessageBox.Show("This stock is not equal to the original stock.\nDo you want to change the stock?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        suppliers[SupplierForm.index].Stock = totalstock;
                        MessageBox.Show("Stock is Saved!");
                        OpeningForm openingForm = new OpeningForm();
                        openingForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Stock was not Changed.");
                        OpeningForm openingForm = new OpeningForm();
                        openingForm.Show();
                        this.Hide();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Input");
            }
        }
    }
}
