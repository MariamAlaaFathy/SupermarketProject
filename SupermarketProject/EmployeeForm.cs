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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void ManagerButton_Click(object sender, EventArgs e)
        {
            ManagerForm managerform = new ManagerForm();
            managerform.Show();
            this.Hide();
        }

        private void CashierButton_Click(object sender, EventArgs e)
        {
            CashierForm cashierForm = new CashierForm();
            cashierForm.Show();
            this.Hide();
        }

        private void OwnerButton_Click(object sender, EventArgs e)
        {
            OwnerForm ownerForm = new OwnerForm();
            ownerForm.Show();
            this.Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            OpeningForm openingForm = new OpeningForm();
            openingForm.Show();
            this.Hide();
        }
    }
}
