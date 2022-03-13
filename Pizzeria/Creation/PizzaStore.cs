using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class PizzaStore
    {
        SimplePizzaFactory factory;
        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
        }
        public Pizza orderPizza(string pizzatype)
        {
            Pizza pizza;
            pizza = factory.CreatePizza(pizzatype);
            return pizza;
        }
    }
}
