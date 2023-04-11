using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class UserDialog
    {
        private MenuCatalog _menuCatalog;
        private CustomerCatalog _customerCatalog;
        private Order _order;
        private Payment _payment;
        private Pizza _pizza;
        private int _numberInput;
        private int _quantityNumberInput;

        public UserDialog(MenuCatalog menuCatalog, CustomerCatalog customerCatalog, Order order, Payment payment, Pizza pizza)
        {
            _menuCatalog = menuCatalog;
            _customerCatalog = customerCatalog; 
            _order = order;
            _payment = payment;
            _pizza = pizza;
        }
        public int NumberInput
        {
            get { return _numberInput; }
            set { _numberInput = value; }   
        }

        public int ChoosePizzaFromMenu()
        {
            Console.WriteLine("Choose pizza number:");
            int _pizzaNumberInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Write Quantity");
            int _quantityNumberInput = Convert.ToInt32(Console.ReadLine());
            _order.Quantity = _quantityNumberInput;
            _pizza.Id = _pizzaNumberInput;

            return _pizzaNumberInput;
            
        }    
        
        public void RegisterCustomer()
        {

        }
                
        public void StartDialog()
        {

        }

        public void EndDialog()     
        { 

        }  
    }
}
