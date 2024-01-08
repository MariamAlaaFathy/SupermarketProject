﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject
{
    public class Customer:Person
    {
        public static int customerNo = 0;
        int customerID;
        string password;
        double receipt = 0;

        public int CustomorID
        {
            get
            {
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
        }
        public Customer(string firstname, string lastname, int age, string email, string phone_number,string address, string password) : base( firstname, lastname, age,  email,  phone_number,address)
        {
            this.password = password;
            customerNo++;
            customerID = customerNo;
            
        }

        public double CalculateReceipt(double amount, double price)
        {
            receipt += amount*price;
            return receipt;
        }
    }
}
