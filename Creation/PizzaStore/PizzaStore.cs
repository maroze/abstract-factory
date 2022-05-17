using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(string pizzatype)
        {
            Pizza pizza;
            pizza = CreatePizza(pizzatype);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
        public abstract Pizza CreatePizza(string pizzatype);
    }
}
