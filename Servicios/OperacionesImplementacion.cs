using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal class OperacionesImplementacion : OperacionesInterfaz
    {
        public void OperadorIgualdad()
        {
            int operadorUno;
            int operadorDos;

            Console.WriteLine("Introduzca un valor para el primer numero: ");
            operadorUno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca un valor para el segundo numero: ");
            operadorDos = Convert.ToInt32(Console.ReadLine());


            if (operadorUno==operadorDos)
            {
                Console.WriteLine("Los números introducidos son iguales");
            }

            else
            {
                Console.WriteLine("Los números introducidos no son iguales");
            }
        }
    }
}
