using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public abstract class Pizza
    {
        public abstract string description();
        public string prepare()
        {
            return "готовится ->";
        }
        public string bake()
        {
            return "в печи ->"; ;
        }
        public string cut()
        {
            return "мы уже режем пиццу ->";
        }
        public string box()
        {
            return "ура, пицца в коробке";
        }
    }
}
