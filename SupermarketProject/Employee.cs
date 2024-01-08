using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace SupermarketProject
{
    public class Employee:Person
    {
        string employeeID;
        double salary;
        string job_title;
        string employee_password;
        public static int numberOfEmployees=0;

        public string EmployeePassword
        {
            get
            {
                return employee_password;
            }
        }

        public string EmployeeID
        {
            get
            {
                return employeeID;
            }
        }
        public string JobTitle
        {
            get
            {
                return job_title;
            }
            set
            {
                job_title = value;
            }
        }
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public Employee(string firstname, string lastname,int age, string email, string phone_number, string address ,string emID, double salary, string job_title, string employee_password) : base(firstname, lastname,age, email, phone_number, address)
        {
            employeeID = emID;
            this.salary = salary;
            this.job_title = job_title;
            this.employee_password = employee_password;
            numberOfEmployees++;
        }

    }
}
