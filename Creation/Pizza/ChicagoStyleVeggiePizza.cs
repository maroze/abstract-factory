using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class ChicagoStyleVeggiePizza: Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public ChicagoStyleVeggiePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override string prepare()
        {
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            veggies = ingredientFactory.createVeggies();

            return $"Готовится -{description}: {dough.Name}, {sauce.Name}, {veggies[0].Name}, {veggies[1].Name}, {veggies[2].Name}";
        }
    }
}
