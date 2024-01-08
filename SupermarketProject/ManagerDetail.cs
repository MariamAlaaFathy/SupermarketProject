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
    public partial class ManagerDetail : Form
    {
        public ManagerDetail()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            ManagerForm managerForm = new ManagerForm();
            managerForm.Show();
            this.Hide();
        }

        private void give_bonus_Click(object sender, EventArgs e)
        {
            double sales = Convert.ToDouble(totalsales.Text);
            if(sales > 1000)
            {
                Manager.GiveBonus(givebonusto_ID.Text, CashierForm.cashiers);
                MessageBox.Show("Bonus was given to employee " + givebonusto_ID.Text);
                return;
            }

            MessageBox.Show("Cant't give bonus. Sales are low");
        }
    }
}
