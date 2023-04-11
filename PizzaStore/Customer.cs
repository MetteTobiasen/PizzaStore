using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Customer
    {
        private string _name;
        private string _email;
        private int _phone;
        private CustomerCatalog _catalog;
        
        public Customer(string name, string email, int phone)
        {
        _name = name;
        _email = email;
        _phone = phone;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }  
            set { _email = value; } 
        }

        public int Phone
        {
            get { return _phone; }  
            set { _phone = value; } 
        }

             

        public void UpdateCustomer(string name, string email, int phone)
        {
            _name = name;
            _email = email;
            _phone = phone;

            _catalog.UpdateCustomerOnList(name,email,phone);
        }

        public void CreateCustomer(string name, string email, int phone)
        {
            Customer _customer = new Customer(name, email, phone);
            _catalog.GenerateCustomerOnList(_customer);
        }

        public override string ToString()
        {
            return $"Name: {_name}\nEmail: {_email}\nPhonenumber: {_phone}";
        }
    }   
}
