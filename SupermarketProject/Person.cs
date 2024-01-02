using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject
{
    class Person
    {
        string first_name;
        string last_name;
        int age;
        string address;
        string email;
        string phone_number;
        public string First_Name {
            get {
                return first_name; 
                }
        }
        public string Last_Name
        {
            get { 
                return last_name;
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

        public Person(string firstname, string lastname, int age, string email, string phone_number,string address)
        {
            first_name = firstname; 
            last_name = lastname;
            this.age = age;
            this.email = email;
            this.phone_number = phone_number;
            this.address = address;
        }

    }
}
