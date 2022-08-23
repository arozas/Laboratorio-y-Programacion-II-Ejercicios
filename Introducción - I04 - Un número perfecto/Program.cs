using System;
/*ALEJANDRO ALBERTO MARTÍN ROZAS
 * Ejercicio I04 - Un número perfecto
 * Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.
 * El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
 * Escribir una aplicación que encuentre los 4 primeros números perfectos.
 * IMPORTANTE
 * Utilizar sentencias de iteración y selectivas.
 */
namespace Introduccion_Ejercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumuladorNumerosPerfectos=0;
            int i = 1;
            do
            {
                if (EsPerfecto(i))
                {
                    Console.WriteLine($"Numero Perfecto {i}");
                    acumuladorNumerosPerfectos++;
                }
                i++;
            }
            while(acumuladorNumerosPerfectos != 4);
        }
        static bool EsPerfecto(int numero)
        {   
            bool retorno = false;
            int divisores = 0;
            int i = 0;
            for (i = 1; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    divisores += i;
                }
            }
            if (numero == divisores)
            { 
                retorno = true;
            }
            return retorno;
        }
        static bool Confirmar(string pregunta)
        {
            bool retorno = false;
            ConsoleKeyInfo respuestaIngresada;
            do
            {
                Console.WriteLine($"\n{pregunta}");
                Console.WriteLine("<S/N>:");
                respuestaIngresada = Console.ReadKey();
                if (respuestaIngresada.Key == ConsoleKey.S)
                {
                    retorno = true;

                }
                else if (respuestaIngresada.Key == ConsoleKey.N)
                {
                    retorno = false;
                }
                else
                {
                    Console.WriteLine("\nERROR, DEBE INGRESAR UNA RESPUESTA <S/N>");
                }
            } while (respuestaIngresada.Key is not (ConsoleKey.S or ConsoleKey.N));

            return retorno;
        }
    }

}
