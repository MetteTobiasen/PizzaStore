using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class MenuCatalog
    {
        private List<Pizza> _pizzaList;
        private Pizza _pizza;
        private int _number = 1;


        public MenuCatalog() 
        { 
            _pizzaList= new List<Pizza>();
        }    

        public void CreatePizza(Pizza pizza)
        {
            _pizzaList.Add(pizza);
        }

        public void DeletePizza() 
        { 
            _pizzaList.Remove(_pizza);
        } 



        public void PrintMenu()
        {
            foreach(var pizza in _pizzaList) 
            {
                pizza.Id = _number;
                string menuLine1 = _number.ToString() + ": " + pizza.Name;
                string menuLine2 = pizza.Price.ToString() + " kr";
                menuLine1 = menuLine1.PadLeft(0);
                menuLine1 = menuLine1.PadRight(20);
                menuLine2 = menuLine2.PadLeft(20);
                menuLine2 = menuLine2.PadRight(40);
                if(_number == 1)
                {
                    Console.WriteLine("------------------------------------------");
                }
                Console.WriteLine(menuLine1 + menuLine2);
                if(_number <= _pizzaList.Count)
                {
                    Console.WriteLine("------------------------------------------");
                }
                _number++;
            }
        }




    }
}
