using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string pizzatype)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            switch (pizzatype)
            {
                case "Cheese":
                    {
                        pizza = new ChicagoStyleCheesePizza(ingredientFactory) { description = " Чикагская сырная пицца" };
                        break;
                    }
                case "Pepperoni":
                    {
                        pizza = new ChicagoStylePepperoniPizza(ingredientFactory) { description = " Чикагская пицца пепперони" };
                        break;
                    }
                case "Clam":
                    {
                        pizza = new ChicagoStyleClamPizza(ingredientFactory) { description = " Чикагская с морепродуктами" };
                        break;
                    }
                case "Veggie":
                    {
                        pizza = new ChicagoStyleVeggiePizza(ingredientFactory) { description = " Чикагская вегетарианская пицца" };
                        break;
                    }
            }
            return pizza;
        }
    }
}
