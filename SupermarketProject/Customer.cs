using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject
{
    class Customer:Person
    {
        int customerID = 0;
        string password;
        double receipt; 
        public int CustomerID
        {
            get { 
                return customerID;
            }
        }
        public string Password
        {
            get { 
                return password; 
            }
        }
        public double Receipt
        {
            get
            {
                    return receipt;
            }
            set
            {
                receipt = value;
            }
        }
        public Customer(string password, string firstname, string lastname, int age, string email, string phone_number,string address) : base( firstname, lastname, age,  email,  phone_number,address)
        {
            this.password = password;
            customerID++;
            
        }

        
    }
}
