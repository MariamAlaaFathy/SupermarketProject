using SupermarketProject;
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

        Supplier[] suppliers = new Supplier[4];
        public static int index;
        public static string newstock;
        public SupplierForm()
        {
            suppliers[0] = new Supplier("Orchard Delights", "Fruits", 1000);
            suppliers[1] = new Supplier("Veggie Visions", "Vegetables", 1000);
            suppliers[2] = new Supplier("Liquid Refreshing", "Drinks", 1000);
            suppliers[3] = new Supplier("Boundless Milk", "Dairy", 1000);
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
            FruitsDetailsForm fruits = new FruitsDetailsForm();
            VegetablesDetailsForm vegetables = new VegetablesDetailsForm();
            DrinksDetailsForm drinks = new DrinksDetailsForm();
            DairyDetailsForm dairy = new DairyDetailsForm();

            for(int i = 0; i < 4; i++)
            {
                if(NameTextBox.Text == suppliers[i].Name && TypeTextBox.Text == suppliers[i].TypeOfProduct)
                {
                    index = i;
                    newstock = StockTextBox.Text;
                    switch (suppliers[i].TypeOfProduct)
                    {
                        case "Fruits": fruits.Show(); this.Hide(); return;
                        case "Vegetables": vegetables.Show(); this.Hide(); return;
                        case "Drinks": drinks.Show(); this.Hide(); return;
                        case "Dairy": dairy.Show(); this.Hide(); return;
                    }
                }
            }
            MessageBox.Show("Wrong Company Name or Type of Product.");
        }
    }
}
