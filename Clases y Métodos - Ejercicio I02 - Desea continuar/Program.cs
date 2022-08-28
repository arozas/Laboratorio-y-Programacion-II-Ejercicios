using System;
using Biblioteca_UTN;

namespace Clases_y_Métodos___Ejercicio_I02___Desea_continuar
{
    internal class Program
    {
        /* ALEJANDRO ALBERTO MARTÍN ROZAS
         * Ejercicio I02 - ¿Desea continuar?
         * Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
         * Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
         * El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio I02 - ¿Desea continuar?");
            string numeroIngresadoString;
            float numeroIngresado = new();
            float sumaNumerosIngresados = new();
            do
            {
                Console.WriteLine("Ingrese un numero a sumar:");
                numeroIngresadoString = Console.ReadLine();
                if (Validador.EsNumero(numeroIngresadoString, out numeroIngresado))
                {
                    sumaNumerosIngresados += numeroIngresado;
                }

            } while (Validador.ValidarRespuesta("¿Desea continuar? (S/N)?"));

            Console.WriteLine($"La suma de los valores ingresados es: {sumaNumerosIngresados}");
            
            
            
        }
    }
}
