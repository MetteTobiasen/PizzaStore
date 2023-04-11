using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class Pizza
    {
        #region
        private string _name;
        private int _id;
        private double _price;
        #endregion

        // The price that is set when the pizza i instanciated is inclusive vat
        public Pizza(string name, double price)
        {
            _id = 0;
            _name = name;
            _price = price;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public double Price
        {
            get { return _price; }  
            set { _price = value; } 
        }

        public override string ToString()
        {
            return $"Pizza: {_name}\nPrice excl. VAT: {_price * 0.75} kr";
        }
    }
}
