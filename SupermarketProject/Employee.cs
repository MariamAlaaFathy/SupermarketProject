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
    internal class Employee:Person
    {
        int employeeID;
        double salary;
        string job_title;
        string employee_password;
        static int numberOfEmployees=0;

        public string EmployeePassword
        {
            get
            {
                return employee_password;
            }
            set
            {
                employee_password = value;
            }
        }

        public int EmployeeID
        {
            get
            {
                return employeeID;
            }
            set
            {
                employeeID = value;
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
        public Employee():base()
        {
            numberOfEmployees ++;
            employeeID = 0;
            salary = 0;
            job_title = "";
            employee_password = "";
        }
        public Employee(int emID, double salary, string job_title, string employee_password,int numofemp) : base(name, age, email, phone_number, address)
        {
            employeeID = emID;
            this.salary = salary;
            this.job_title = job_title;
            this.employee_password = employee_password;
            numofemp=numberOfEmployees++;
        }

    }
}
