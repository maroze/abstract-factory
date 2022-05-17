using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public abstract class Pizza
    {
        public string description;
        public Dough dough;
        public Sauce sauce;
        public Veggies[] veggies;
        public Cheese cheese;
        public Pepperoni pepperoni;
        public Clams clam;

        public abstract string prepare();

        public virtual string bake()
        {
            return "Выпекать 25 минут при температуре 350 °C"; ;
        }
        
        public virtual string cut()
        {
            return "Разрезание пиццы на диагональные ломтики";
        }
        
        public virtual string box()
        {
            return "Поместите пиццу в официальную коробку магазина пиццы";
        }

        public string GetDescription()
        {
            return description;
        }

        public string display()
        {
            return $"{GetDescription()} \n{prepare()} \n{bake()} \n{cut()} \n{box()}";
        }
    }
}
