using System;
using System.Collections.Generic;
using System.Text;

namespace Patron__Decorator
{
    public abstract class Decorator : Computer
    {
        public override abstract decimal CalcularCosto();
        
    }
}
