using System;
using System.Collections.Generic;
using System.Text;

namespace Patron__Decorator
{
    class BaseComputador : Computer
    {
        //este se inicializa en 0
        public override decimal CalcularCosto()
        {
            return 0M;
        }
    }
}
