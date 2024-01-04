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
    public partial class FullTimeCashier : Form
    {
        public FullTimeCashier()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            CashierForm cashierForm = new CashierForm();
            cashierForm.Show();
            this.Hide();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Hide();
        }
    }
}
