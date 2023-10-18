using CalculadoraLogica.Servicios;

namespace CalculadoraLogica
{
    public static void Main (string[] args)
    {
        MenuInterfaz menuI = new MenuImplementacion();
        OperacionesInterfaz operacionI = new OperacionesImplementacion();


        int opcionSeleccion;
        bool cerrarMenu = false;

        while (!cerrarMenu)
        {

            opcionSeleccion = menuI.MostrarMenu();
            Console.WriteLine(opcionSeleccion);


            switch(opcionSeleccion)
            {
                case 0: Console.WriteLine("[INFO] Se cerrara la aplicación");
                    break;

                case 1: Console.WriteLine("");
                    break;

                case 2: Console.WriteLine("");
                    break;

               

            }       
        }
        


    }
}