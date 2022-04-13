using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class ClamPizza : Pizza
    {
        public override string description()
        {
            return $"{"Пицца с моллюсками"}";
        }
    }
}
