using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_UTN
{
    public class Entrada
    {
        /// <summary>
        /// Genera un menú de opciones numericas que se muestra por consola y toma la elección del usuario.
        /// </summary>
        /// <param name="titulo">Titulo del menú.</param>
        /// <param name="menu">Lista de opciones del menú.</param>
        /// <param name="mensaje">Mensaje para el usuario.</param>
        /// <param name="mensajeError">Mensaje de error en el caso de no ingresar una opcion dentro del rango</param>
        /// <param name="opciones">Cantidad de opciones del menú.</param>
        /// <param name="intentos">Intentos de ingreso de opcion antes de devolver error.</param>
        /// <returns>Devueleve la opción ingresada en formato entero.</returns>
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
