using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore pizza = new PizzaStore(factory);

            string [] piz = new string[] { "Cheese", "Pepperoni", "Clam", "Veggie" };
            foreach (string i in piz)
            {                
                Console.WriteLine($"{pizza.orderPizza(i).description()}\n");
            }

            Console.ReadKey();
        }
    }
}
