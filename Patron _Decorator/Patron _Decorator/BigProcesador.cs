using System;
using System.Collections.Generic;
using System.Text;

namespace Patron__Decorator
{
    class BigProcesador : Decorator
    {
        private Computer currentComputer;

        public BigProcesador(Computer computer)
        {
            this.currentComputer = computer;
        }
        public override decimal CalcularCosto()
        {
            return this.currentComputer.CalcularCosto() + 350.00M;

        }
    }
}
