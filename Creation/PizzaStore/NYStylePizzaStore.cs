using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class NYStylePizzaStore: PizzaStore
    {
        public override Pizza CreatePizza(string pizzatype)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            switch (pizzatype)
            {
                case "Cheese":
                    {
                        pizza = new NYStyleCheesePizza(ingredientFactory) { description = " Нью - Йоркская сырная пицца"};
                        break;
                    }
                case "Pepperoni":
                    {
                        pizza = new NYStylePepperoniPizza(ingredientFactory) { description = " Нью - Йоркская пицца пепперони" };
                        break;
                    }
                case "Clam":
                    {
                        pizza = new NYStyleClamPizza(ingredientFactory) { description = " Нью - Йоркская пицца с морепродуктами" };
                        break;
                    }
                case "Veggie":
                    {
                        pizza = new NYStyleVeggiePizza(ingredientFactory) { description = " Нью - Йоркская вегетарианская пицца" };
                        break;
                    }
            }
            return pizza;
        }
    }
}

