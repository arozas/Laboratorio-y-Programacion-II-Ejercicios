using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_UTN
{
    public class Entrada
    {
        public static int MostrarMenu(string titulo, string menu, string mensaje, string mensajeError, int opciones, int intentos)
        {
            int rtn = -1;
            if (titulo != null && menu != null && mensaje != null && opciones > 0 && intentos > 0)
            {
                Console.WriteLine("\n" + titulo);
                Console.WriteLine(menu);
                string opcionIngresadaString;
                int opcionesIngresada;
                do
                {
                    Console.WriteLine(mensaje);
                    opcionIngresadaString = Console.ReadLine();
                    if ((Validador.EsNumero(opcionIngresadaString, out opcionesIngresada) == false)
                        || opcionesIngresada < 1
                        || opcionesIngresada > opciones)
                    {
                        Console.WriteLine(mensajeError);
                    }
                    else
                    {
                        rtn = opcionesIngresada;
                    }
                    intentos--;
                } while ((Validador.EsNumero(opcionIngresadaString, out opcionesIngresada) == false
                          && (opcionesIngresada < 1 || opcionesIngresada > opciones))
                         && intentos > 0);
            }
            if (rtn == -1)
            {
                Console.WriteLine("ERROR, AGOTÓ LOS INTENTOS");
            }
            return rtn;
        }
    }
}
