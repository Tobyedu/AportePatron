using System;
using System.Collections.Generic;
using System.Text;

namespace Patron__Decorator
{
    class ComputerSSD : Decorator
    {

        //esto se esta agregando el precio segun la caractersiticas de una computadora
        //
        private Computer currentComputer; 
        //el current significa el cvalor actual que tiene mi metodo calcular 
        //costo es decir se almacena 
        //y le agrego mas valor dependiendo del componente 
        
        
        
        public ComputerSSD(Computer computador)
        {
            this.currentComputer = computador;
        }
        public override decimal CalcularCosto()
        {
            //agrego un costo adicional del disco solido

            return this.currentComputer.CalcularCosto() + 300.00M;

           
        }
    }
}
