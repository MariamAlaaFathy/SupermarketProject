namespace SupermarketProject
{
    public partial class OwnerForm : Form
    {
        Owner[] owners = new Owner[3];
        public OwnerForm()
        {
            owners[0] = new Owner("Mariam", "Mohamed", 20, "mariammohamed@gmail.com", "01234", "alex", "own1", 100000, "Owner", "mariam123");
            owners[1] = new Owner("Maram", "Khaled", 20, "maramkhaled@gmail.com", "5678", "alex", "own2", 100000, "Owner", "maram123");
            owners[2] = new Owner("Shahd", "Ahmed", 20, "shahdahmed@gmail.com", "9123", "alex", "own3", 100000, "Owner", "shahd123");
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (ownerID.Text == owners[i].EmployeeID && ownerPassword.Text == owners[i].EmployeePassword)
                {
                    // Successfully logged in, you can perform actions here.
                    MessageBox.Show("Login successful!");
                    OwnerDetail ownerDetail = new OwnerDetail();
                    ownerDetail.Show();
                    this.Hide();
                    return;
                }
            }

            // If the loop completes without finding a match, login failed.
            MessageBox.Show("Invalid credentials. Please try again.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
            this.Hide();
        }
    }
}
