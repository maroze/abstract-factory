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
            PizzaStore nyStore = new NYStylePizzaStore();
            PizzaStore chicagoStore = new ChicagoStylePizzaStore();

            Pizza pizza = nyStore.orderPizza("Cheese");
            Console.WriteLine("Итан заказал:" + pizza.display()+"\n");

            pizza = chicagoStore.orderPizza("Cheese");
            Console.WriteLine("Джоэл заказал:"  + pizza.display()+ "\n");

            Console.ReadKey();
        }
    }
}
