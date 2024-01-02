using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject
{
    class PartTime : Cashier
    {
        double hoursworked;

        public PartTime(string firstname, string lastname, int age, string email, string phone_number, string address, string emID, double salary, string job_title, string employee_password, double hoursworked) : base(firstname, lastname, age, email, phone_number, address, emID, salary, job_title, employee_password)
        {
            this.hoursworked = hoursworked;
        }
    }
}
