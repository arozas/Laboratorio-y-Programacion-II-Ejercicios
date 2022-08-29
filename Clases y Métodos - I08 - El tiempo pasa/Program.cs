using System;
using System.Diagnostics;
using Biblioteca_UTN;

namespace Clases_y_Métodos___I08___El_tiempo_pasa
{
    /* ALEJANDRO ALBERTO MARTÍN ROZAS
     * Ejercicio I08 - El tiempo pasa...
     * Crear un método estático que reciba una fecha y calcule el número de días que pasaron desde esa fecha hasta la fecha actual. Tener en cuenta los años bisiestos.
     * Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y calcule el número de días vividos por esa persona hasta la fecha actual utilizando el método desarrollado anteriormente.
     * Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string fechaIngresadaString;
            DateTime fechaIngresada;
            int diasPasados;
            Console.WriteLine("");
            do
            {
                Console.WriteLine("Ingrese una fecha (dd/mm/aa):");
                fechaIngresadaString = Console.ReadLine();
                if (Validador.EsFecha(fechaIngresadaString, out fechaIngresada))
                {
                    diasPasados = Calculadora.CalcularDías(fechaIngresada);
                    Console.WriteLine($"Desde la fecha ingresada pasaron {diasPasados} días.");
                }
                else
                {
                    Salida.MensajeErrorFecha();
                }

            } while (Validador.ValidarRespuesta("¿Desea Continuar?"));



        }
    }
}
