using System;
using System.Collections.Generic;
using System.Text;

namespace Patron__Decorator
{
    public abstract class Computer
    {
        //esta funcion la voy a heredar a las clase a la cual le voy a añadir 
        //funcionalidades 
        public abstract decimal CalcularCosto();
    }
}
