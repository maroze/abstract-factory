using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public ChicagoStyleCheesePizza (PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override string cut()
        {
            return "Разрезание пиццы на квадратные ломтики";
        }

        public override string prepare()
        {
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();

            return $"Готовится -{description}: {dough.Name}, {sauce.Name}, {cheese.Name}";
        }
    }
}
