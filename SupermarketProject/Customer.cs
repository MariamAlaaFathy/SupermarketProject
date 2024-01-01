using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject
{
    class Customer:Person
    {
        int customerID;
        string password;
        double receipt; 
        public int CustomerID
        {
            get { 
                return customerID;
            }
            set
            {
                customerID = value;
            }
        }
        public string Password
        {
            get { 
                return password; 
            }
            set
            {
                password = value;
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
        public Customer() : base() { 
            CustomerID = 0;
            password = "";
            Receipt = 0;
        }
        public Customer(int customerID, string password, double receipt, string name, int age, string email, string phone_number,string address) : base( name,  age,  email,  phone_number,address)
        {
            this.password = password;
            this.receipt = receipt;
            this.customerID = customerID;
            
        }

        
    }
}
