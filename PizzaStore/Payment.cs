using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace PizzaStore
{
    public class Payment
    {
        private double _deliveryPrice;
        private double _vat;
        private double _totalPizzaPrice;
        private double _totalPrice;
        private Order _order;
        private Pizza _pizza;
  

        public Payment(Order order, Pizza pizza)
        {
            _order = order;
            _pizza = pizza;
            _deliveryPrice = 40;
            _vat = 0;
            _totalPrice = 0;
            _totalPizzaPrice= 0;    
        }

        public double Vat
        {
            get { return _vat = _totalPizzaPrice * 0.25; }
        }

        public double DeliveryPrice
        {
            get { return _deliveryPrice; }
            set { _deliveryPrice = value; }
        }

        public double TotalPizzaPrice
        {
            get { return _totalPizzaPrice = _order.Quantity * _pizza.Price; }
        }

        public double CalculateTotalPrice()
        {
            return _totalPrice = TotalPizzaPrice + _deliveryPrice;
        }


        public override string ToString()
        {
            return $"Deliveryprice: {_deliveryPrice} kr\nPizza total: {_totalPizzaPrice - Vat} kr\nVAT: {Vat} kr\n_____________________\n\nTotalprice: {_totalPrice} kr\n_____________________";
        }

    }
}
