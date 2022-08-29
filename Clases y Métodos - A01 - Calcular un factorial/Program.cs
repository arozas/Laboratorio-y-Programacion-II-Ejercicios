using System;
using Biblioteca_UTN;

namespace Clases_y_Métodos___A01___Calcular_un_factorial
{
    internal class Program
    {
        /*ALEJANDRO ALBERTO MARTÍN ROZAS
        * Ejercicio A01 - Calcular un factorial
        * El factorial de un número es una operación que consiste en multiplicar un numero “n” por todos los números enteros positivos que estén debajo de él, 
        * por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.
        * 
        * En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio I02 - ¿Desea continuar?");
            string numeroIngresadoString;
            do
            {
                Console.WriteLine("Ingrese un numero a sumar:");
                numeroIngresadoString = Console.ReadLine();
                long numeroIngresado;
                if (Validador.EsNumero(numeroIngresadoString, out numeroIngresado))
                {
                    if (numeroIngresado > 0)
                    {
                        long resultadoFactorial = Calculadora.CalcularFactorial(numeroIngresado);
                        Console.WriteLine($"El numero factorial de {numeroIngresado} es: {resultadoFactorial}");
                    }
                    else
                    {
                        Salida.MensajeErrorNumeroRango();
                    }
                    
                }
                else
                {
                    Salida.MensajeErrorNumero();
                }

            } while (Validador.ValidarRespuesta("¿Desea continuar? (S/N)?"));
        }
    }
}
