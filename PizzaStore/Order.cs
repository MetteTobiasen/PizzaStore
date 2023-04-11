namespace PizzaStore
{

    public class Order
    {
        #region instance 
        private int _id;
        private int _quantity;
        private Pizza _pizza;
        private Customer _customer;
        //private List<Order> _orders;
        //private bool _statusOnOrder;

        #endregion

        #region constructor
        public Order(int id, int quantity, Pizza pizza, Customer customer)
        {
            _id = id;
            _quantity = quantity;
            _pizza = pizza;
            _customer = customer;
        }
        #endregion

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }


        public override string ToString()
        {
            return $"Ordernumber: {_id}\nQuantity: {_quantity}\n";
        }
    }
}
