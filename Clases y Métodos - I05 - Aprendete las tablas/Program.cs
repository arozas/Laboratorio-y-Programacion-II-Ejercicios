using System;
using System.Text;
using Biblioteca_UTN;

namespace Clases_y_Métodos___I05___Aprendete_las_tablas
{
    /* ALEJANDRO ALBERTO MARTÍN ROZAS
        * Ejercicio I05 - Aprendete las tablas
        * Crear una aplicación de consola que permita al usuario ingresar un número entero.
        * Desarrollar un método estático que reciba un número y devuelva la tabla de multiplicación de ese número en formato string.
        * Se deberá utilizar la clase StringBuilder combinada con strings interpolados para armar el resultado.
        * Mostrar en la consola el resultado.
        * Por ejemplo, si se ingresa el número 2 la salida deberá ser:
        * Tabla de multiplicar del número 2:
          2 x 1 = 2
          2 x 2 = 4
          2 x 3 = 6
          2 x 4 = 8
          2 x 5 = 10
          2 x 6 = 12
          2 x 7 = 14
          2 x 8 = 16
          2 x 9 = 18
        */
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            int numeroIngresado = new();
            Console.WriteLine("APRENDETE LAS TABLAS" + "\n");
            Console.WriteLine("Ingrese la tabla que quiere ver:");
            numeroIngresadoString=Console.ReadLine();
            if (Validador.EsNumero(numeroIngresadoString, out numeroIngresado))
            {
                Calculadora.ApredeteLasTablas(numeroIngresado);
            }
            else
            {
                Console.WriteLine("Error. Debe ingresar un numero valido.");
            }
        }
    }
}
