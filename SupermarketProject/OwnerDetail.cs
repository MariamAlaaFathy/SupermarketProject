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
    public partial class OwnerDetail : Form
    {
        Owner owner;
        public OwnerDetail()
        {
            InitializeComponent();
            owner = new Owner("Mariam", "Mohamed", 20, "mariammohamed@gmail.com", "01234", "alex", "own1", 100000, "Owner", "mariam123");
            label9.Text = Convert.ToString(owner.rent);
            label8.Text = Convert.ToString(owner.bills);
            label10.Text = Convert.ToString(owner.rentDueDate);
            GainLabel.Text = Convert.ToString(owner.gain);
        }

        private void rent_left_Click(object sender, EventArgs e)
        {
            double money = Convert.ToDouble(will_pay.Text);
            owner.CalculateGain();

            if (money > owner.rent)
            {
                RentLeft.Text = "0";
                money -= owner.rent;
                owner.gain += money;
                GainLabel.Text = Convert.ToString(owner.gain);
                return;
            }

            GainLabel.Text = Convert.ToString(owner.gain);
            RentLeft.Text = Convert.ToString(owner.rent - money);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Hide();
        }
    }
}
