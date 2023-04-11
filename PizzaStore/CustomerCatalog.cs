using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class CustomerCatalog
    {

        private List<Customer> _customerList;
 

        public CustomerCatalog()
        {
            _customerList = new List<Customer>();
        }
        public List<Customer> CustomerList
        {
            get { return _customerList; }
        }

        public void GenerateCustomerOnList(Customer customer)
        {
            _customerList.Add(customer);
        }

        public void PrintOutList()
        {
            foreach (Customer customer in _customerList)
            {
                Console.WriteLine($"Name: {customer.Name} Email: {customer.Email} Phone: {customer.Phone}");
            }

        }
        public void UpdateCustomerOnList(string name, string email, int phone)
        {
            foreach (var _customer in _customerList)
            {
                if (_customer.Name == _customer.Name && _customer.Email == _customer.Email)
                {
                    _customerList.Remove(_customer);
                    _customer.Name = name;
                    _customer.Email = email;
                    _customer.Phone = phone;
                    _customerList.Add(_customer);
                    return;
                }
            }
        }

        public void ClearCustomerList()
        {
            _customerList.Clear();  
        }
    }
}
