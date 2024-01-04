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
    }
}
