using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    class ChicagoStylePepperoniPizza: Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public ChicagoStylePepperoniPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override string prepare()
        {
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            pepperoni = ingredientFactory.createPepperoni();

            return $"Готовится -{description}: {dough.Name}, {sauce.Name}, {pepperoni.Name}, {cheese.Name}";
        }
    }
}
