using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class OrderCatalog
    {
        private List<Order> _orderList;
        private Order _order;
        public OrderCatalog() 
        {
            _orderList = new List<Order>();
        }  

        public void CreateOrderToList(Order order)
        {
            _orderList.Add(order);
        }
        
        public void DeleteOrderFromList(int orderId)
        {
            _orderList.RemoveAt(_order.Id);
        }

        public void UpdatePizzaQuantityFromList(int orderId, int quantity)
        {
            foreach(Order order in _orderList) { 
                if(_order.Id == orderId)
                {
                    order.Quantity = quantity;
                    return;
                }
                return;
            }
        }

        public void PrintOrderList() 
        {
            foreach(Order order in _orderList) 
            { 
                Console.WriteLine(order.ToString());
            }
        }
    }
}
