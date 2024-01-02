namespace SupermarketProject
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerLogin customerlogin = new CustomerLogin();
            customerlogin.Show();
            this.Hide();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerSignUp customerSignUp = new CustomerSignUp();
            customerSignUp.Show();
            this.Hide();    
        }
    }
}
