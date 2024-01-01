using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject
{
    internal class Person
    {
        string first_name;
        string second_name;
        int age;
        string address;
        string email;
        string phone_number;
        public string First_Name {
            get {
                return first_name; 
                } 
            set {
                first_name = value; 
                }
        }
        public string Second_Name
        {
            get { 
                return second_name;
            }
            set
            {
                second_name = value;
            }
        }
        public int Age
        {
            get { 
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        public string PhoneNumber
        {
            get
            {
                return phone_number;
            }
            set
            {
                phone_number = value;
            }
        }
        public Person() {
            first_name = "";
            second_name = "";
            age = 0;
            email = "";
            phone_number = "";
            address = "";
        } 
        public Person(string name, int age, string email, string phone_number,string address)
        {
            first_name = name; 
            second_name = name;
            this.age = age;
            this.email = email;
            this.phone_number = phone_number;
            this.address = address;
        }

    }
}
