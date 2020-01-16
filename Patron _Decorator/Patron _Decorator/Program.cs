
using System;

namespace Patron__Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            //en el patron decorador vamos a añadir funcionalidades de ese objeto sin modificar su codigo
            //como tal estamos usuando una sola instancia
            //el objeto esta llamando a las clases que he creado
            // ya que heredan de mi clase abstaracta
            //que fue sobreescrito

            Computer gamerPc = new BaseComputador();

            gamerPc = new ComputerSSD(gamerPc);
            gamerPc = new BigProcesador(gamerPc);
            gamerPc = new DomyComputer(gamerPc);
            var cost = gamerPc.CalcularCosto();

          
            //aqui muestro el valor de los valores adicionados

            Console.WriteLine(string.Format ("El costo de esta pc Modificada es de: {0}" ,cost));
           

        }
    }
}
