using System;
using Biblioteca_UTN;

namespace Clases_y_Métodos___I04___La_calculadora
{
    /* ALEJANDRO ALBERTO MARTÍN ROZAS
     * Ejercicio I04 - La calculadora
     * Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).
     * Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
     * Calcular (público): Recibirá tres parámetros, el primer operando, el segundo operando y la operación matemática. El método devolverá el resultado de la operación.
     * Validar (privado): Recibirá como parámetro el segundo operando. Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá true si el operando es distinto de cero.
     * Se le debe pedir al usuario que ingrese dos números y la operación que desea realizar (ingresando el caracter +, -, * o /).
     * El usuario decidirá cuándo finalizar el programa.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            float primerNumeroIngresado = new();
            float segundoNumeroIngresado = new();
            float resultadoOperacion = new();
            string operadorOperacion;
            do
            {
                Console.WriteLine("Ingrese el primer numero a operar:");
                numeroIngresadoString = Console.ReadLine();
                if (Validador.EsNumero(numeroIngresadoString, out primerNumeroIngresado))
                {
                    Console.WriteLine("Ingrese el primer numero a operar:");
                    numeroIngresadoString = Console.ReadLine();
                    if (Validador.EsNumero(numeroIngresadoString, out segundoNumeroIngresado))
                    {
                        Console.WriteLine("Ingrese el operador (+,-,*,/) de la operación a realizar:");
                        operadorOperacion = Console.ReadLine();
                        if (operadorOperacion == "+" || operadorOperacion == "-" || operadorOperacion == "*" || operadorOperacion == "/")
                        {
                            resultadoOperacion = Calculadora.Calcular(primerNumeroIngresado, segundoNumeroIngresado, operadorOperacion);
                            Console.WriteLine($"El resultado de la operación {operadorOperacion} es: {resultadoOperacion}");

                        }
                        else
                        {
                            Console.WriteLine("Error. Debe ingresar un operador valido (+,-,*,/).");
                        }
                    }
                    else { Console.WriteLine("Error. Debe ingresar un valor valido."); }
                }
                else { Console.WriteLine("Error. Debe ingresar un valor valido."); }

            } while (Validador.ValidarRespuesta("¿Desea Continuar? S/N"));
        }
    }
}
