using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int MostrarMenu()
        {
            int opcionSeleccionada;
            
                Console.WriteLine("################");
                Console.WriteLine("1.Cerrar");
                Console.WriteLine("2.Igualdad");
                Console.WriteLine("3.Desigualdad");                          
                Console.WriteLine("Seleccione una opción:");

            opcionSeleccionada = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());

            return opcionSeleccionada;
            
        }
    }
}
