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
    public partial class CashierForm : Form
    {
        public static Cashier[] cashiers = new Cashier[4];
        public CashierForm()
        {
            cashiers[0] = new Cashier("Youmna", "Yasser", 20, "youmnayasser@gmail.com", "01101011865", "alex", "f1", 5000, "Fulltime", "youmna123");
            cashiers[1] = new PartTime("Nada", "Khaled", 20, "nadakhaled@gmail.com", "01234567891", "alex", "p1", 2000, "Parttime", "nada1234", 8);
            cashiers[2] = new Cashier("Alaa", "Fathy", 20, "alaafathy@gmail.com", "01101011865", "alex", "f2", 5000, "Fulltime", "alaa123");
            cashiers[3] = new PartTime("Mohamed", "Khaled", 20, "mohamedkhaled@gmail.com", "01234567891", "alex", "p2", 2000, "Parttime", "mohamed1234", 8);
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (CashierID.Text == cashiers[i].EmployeeID && CashierPassword.Text == cashiers[i].EmployeePassword)
                {
                    if (cashiers[i].EmployeeID.StartsWith('f'))
                    {
                        FullTimeCashier fullTimeCashier = new FullTimeCashier();
                        fullTimeCashier.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        PartTimeCashier partTimeCashier = new PartTimeCashier();
                        partTimeCashier.Show();
                        this.Hide();
                        return;
                    }
                }
            }

            MessageBox.Show("Wrong Employee ID or Password.");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Hide();
        }
    }
}
