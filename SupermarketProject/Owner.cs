using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject
{
    class Owner : Employee
    {
        public double rent = 10000;
        public DateTime rentDueDate = new DateTime(2024,1,1);
        public double bills = 1000;
        public double gain = 0;

        public Owner(string firstname, string lastname, int age, string email, string phone_number, string address, string emID, double salary, string job_title, string employee_password) : base(firstname, lastname, age, email, phone_number, address, emID, salary, job_title, employee_password)
        {

        }

        public double CalculateGain()
        {
            gain = Manager.sales - rent - bills - Manager.totalSalaries;
            return gain;
        }
    }
}
