namespace SupermarketProject
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ManagerButton_Click(object sender, EventArgs e)
        {
            ManagerForm managerform = new ManagerForm();
            managerform.Show();
            this.Hide();
        }

        private void CashierButton_Click(object sender, EventArgs e)
        {

        }

        private void OwnerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
