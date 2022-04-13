using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string pizzatype)
        {
            Pizza pizza = null;

            switch (pizzatype)
            {
                case "Cheese":
                    {
                        pizza = new CheesePizza();
                        break;
                    }
                case "Pepperoni":
                    {
                        pizza = new PepperoniPizza();
                        break;
                    }
                case "Clam":
                    {
                        pizza = new ClamPizza();
                        break;
                    }
                case "Veggie":
                    {
                        pizza = new VeggiePizza();
                        break;
                    }
            }
            return pizza;
        }
    }
}
