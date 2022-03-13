using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    public class VeggiePizza : Pizza
    {
        public override string description()
        {
            return $"{"Вегетарианская пицца"}";
        }
    }
}
