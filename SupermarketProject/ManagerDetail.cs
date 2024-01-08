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
        public static Cashier[] cashiers = new Cashier[4];
        Manager manager = new Manager("dareen", "moataz", 14, "dareenmoataz@gmail.com", "01145674329", "fleming", "1", 100.12, "cashier", "dareen123");
        public ManagerDetail()
        {
            InitializeComponent();
            cashiers[0] = new Cashier("Youmna", "Yasser", 20, "youmnayasser@gmail.com", "01101011865", "alex", "f1", 5000, "Fulltime", "youmna123");
            cashiers[1] = new PartTime("Nada", "Khaled", 20, "nadakhaled@gmail.com", "01234567891", "alex", "p1", 2000, "Parttime", "nada1234", 8);
            cashiers[2] = new Cashier("Alaa", "Fathy", 20, "alaafathy@gmail.com", "01101011865", "alex", "f2", 5000, "Fulltime", "alaa123");
            cashiers[3] = new PartTime("Mohamed", "Khaled", 20, "mohamedkhaled@gmail.com", "01234567891", "alex", "p2", 2000, "Parttime", "mohamed1234", 8);
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
                manager.GiveBonus(givebonusto_ID.Text, cashiers);
                MessageBox.Show("Bonus was given to employee " + givebonusto_ID.Text);
                return;
            }

            MessageBox.Show("Cant't give bonus. Sales are low");
        }
    }
}
