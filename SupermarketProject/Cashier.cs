using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject
{
    class Cashier : Employee
    {
        int NoOfCostumers;

        public Cashier(string firstname, string lastname, int age, string email, string phone_number, string address, string emID, double salary, string job_title, string employee_password) : base(firstname, lastname, age, email, phone_number, address, emID, salary, job_title, employee_password)
        {
        }

        public int NOOFCOST
        {
            set { NoOfCostumers = value; }
            get { return NoOfCostumers; }
        }
    }
}
