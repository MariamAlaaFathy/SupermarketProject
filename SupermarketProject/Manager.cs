using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject
{
    class Manager : Employee
    {
        public static double sales;
        public static double totalSalaries = 0;
        static double bonus;

        public Manager(string firstname, string lastname, int age, string email, string phone_number, string address, string emID, double salary, string job_title, string employee_password) : base(firstname, lastname, age, email,phone_number, address, emID, salary, job_title, employee_password)
        {
            totalSalaries += Employee.numberOfEmployees * salary;
        }

        public double Bonus
        {
            set { bonus = value; }
            get { return bonus; }
        }
        public void GiveBonus(string id, Cashier[] cashiers)
        {
            for(int i = 0; i < cashiers.Length; i++)
            {
                if(id == cashiers[i].EmployeeID)
                {
                    cashiers[i].Salary += bonus;
                    break;
                }
            }
        }
    }
}
