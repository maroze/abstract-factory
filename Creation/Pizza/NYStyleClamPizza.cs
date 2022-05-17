using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class NYStyleClamPizza: Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public NYStyleClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override string prepare()
        {
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
            clam = ingredientFactory.createClam();

            return $"Готовится -{description}: {dough.Name}, {sauce.Name}, {clam.Name}, {cheese.Name}";
        }
    }
}
