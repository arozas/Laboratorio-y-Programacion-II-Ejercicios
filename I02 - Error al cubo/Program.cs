using System;
/*ALEJANDRO ALBERTO MARTÍN ROZAS
 * Ejercicio I02 - Error al cubo.
 * Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
 * Se debe validar que el número sea mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
 * Tanto variables y lógica aplicada es para que el programa no rompa, independientemente de lo que ingresa el usuario. 
 */
namespace Introduccion_Ejercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            double numeroIngresado = new double();
            double numeroIngresadoCuadrado = new double();
            double numeroIngresadoCubo = new double();
            bool validacionNumeroIngresado = new bool();
            do
            {
                Console.WriteLine("Ingrese un numero a continuación:");
                numeroIngresadoString = Console.ReadLine();
                validacionNumeroIngresado = (!string.IsNullOrEmpty(numeroIngresadoString) && double.TryParse(numeroIngresadoString, out numeroIngresado)) && (numeroIngresado > 0);
                if (validacionNumeroIngresado == true)
                {
                    numeroIngresadoCuadrado = Math.Pow(numeroIngresado, 2);
                    numeroIngresadoCubo = Math.Pow(numeroIngresado, 3);
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            } while (validacionNumeroIngresado==false);

            Console.WriteLine($"El numero ingresado al cuadrado es: {numeroIngresadoCuadrado}");
            Console.WriteLine($"El numero ingresado al cubo es: {numeroIngresadoCubo}");
        }
    }
}
