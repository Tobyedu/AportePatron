using System;
using System.Collections.Generic;
using System.Text;

namespace Patron__Decorator
{
    class DomyComputer:Computer
    {
        // esta es la clse que se va a decorar 
        
        private Computer currentComputer; //el current significa ahora 
        
        public DomyComputer(Computer computer)
        {
            this.currentComputer = computer;
        }
        //propiedades privadas de la clase ya que pueden accesar otras clases
        private decimal Procesador = 150.00M;
        private decimal DicoHDD = 50.00M;
        private decimal TarjetaGraphica = 80.00M;
        private decimal Ram = 60.00M;

        
        //este override significa que esta sobrescrito
        public override decimal CalcularCosto()
        {
            var costo = this.Procesador + this.DicoHDD + this.TarjetaGraphica + this.Ram;

            return costo+this.currentComputer.CalcularCosto();
        }
    }

}
