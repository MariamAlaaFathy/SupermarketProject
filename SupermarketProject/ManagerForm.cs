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
using System.Xml.Linq;

namespace SupermarketProject
{
    public partial class ManagerForm : Form
    {
        Manager[] managers = new Manager[3];
        public ManagerForm()
        {
            InitializeComponent();
            managers[0] = new Manager("dareen", "moataz", 14, "dareenmoataz@gmail.com", "01145674329", "fleming", "1", 100.12, "cashier", "dareen123");
            managers[1] = new Manager("noureen", "shebl", 16, "noureenshebl@gmail.com", "01236759037", "sanstefano", "2", 145.2, "manager", "none1234");
            managers[2] = new Manager("khaled", "hamed", 24, "khaledhamed@gmail.com", "01157893526", "kafrabdo", "3", 200, "owner", "khela1234");

        }
        private void Login_Click(object sender, EventArgs e)
        {
            string enteredID = managerID.Text;
            string enteredPassword = ManagerPassword.Text;

            for (int i = 0; i < 3; i++)
            {
                if (enteredID == managers[i].EmployeeID && enteredPassword == managers[i].EmployeePassword)
                {
                    // Successfully logged in, you can perform actions here.
                    MessageBox.Show("Login successful!");
                    ManagerDetail managerform = new ManagerDetail();
                    managerform.Show();
                    this.Hide();
                    return;
                }
            }

            // If the loop completes without finding a match, login failed.
            MessageBox.Show("Invalid credentials. Please try again.");

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeform = new EmployeeForm();
            employeeform.Show();
            this.Hide();
        }
    }
}
