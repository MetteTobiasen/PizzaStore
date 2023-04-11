using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class TestData

    {
        public void Dataset()
        {
            CustomerCatalog customerCatalog = new CustomerCatalog();
            Customer customer1 = new Customer("Mette Tobiasen", "tobiasen_1@hotmail.com", 30618320);
            Customer customer2 = new Customer("Søren Okholm", "soren@hotmail.com", 33884499);
            Customer customer3 = new Customer("Sune Stick", "sune@hotmail.com", 44220044);

            Pizza pizza1 = new Pizza("Margerita", 100);
            Pizza pizza2 = new Pizza("Napoli", 125);
            Pizza pizza3 = new Pizza("Hawaii", 100);

            Order order1 = new Order(1, 1, pizza1, customer1);
            Order order2 = new Order(2, 2, pizza2, customer2);
            Order order3 = new Order(3, 3, pizza3, customer3);

            Payment payment1 = new Payment(order1, pizza1);
            Payment payment2 = new Payment(order2, pizza2);
            Payment payment3 = new Payment(order3, pizza3);

            MenuCatalog menu = new MenuCatalog();

        


        }
        

    }
}
