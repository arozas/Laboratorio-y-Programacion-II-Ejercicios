using System;
/*ALEJANDRO ALBERTO MARTÍN ROZAS
 * Ejercicio I03 - Los primos
 * Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
 * Validar que el dato ingresado por el usuario sea un número.
 * Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
 * Si ingresa "salir", cerrar la consola.
 * Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.. 
 * IMPORTANTE:
 * Utilizar sentencias de iteración, selectivas y el operador módulo (%).
 */
namespace Clase_01___Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? numeroIngresadoString;
            double numeroIngresado = new double();
            bool validacionNumeroIngresado = new bool();
            int contadorPrimos=0;
            int i = 0;
            do
            {
                Console.WriteLine("\nIngrese un numero a continuación:");
                numeroIngresadoString = Console.ReadLine();
                validacionNumeroIngresado = (!string.IsNullOrEmpty(numeroIngresadoString) && double.TryParse(numeroIngresadoString, out numeroIngresado)) && (numeroIngresado > 0);
                if (validacionNumeroIngresado == true)
                {
                    for (i = 2; i < numeroIngresado; i++)
                    {
                        if (EsPrimo(i))
                        {
                            contadorPrimos++;
                            Console.WriteLine($"Numero Primo {contadorPrimos}: {i}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
                i = 2;
                contadorPrimos = 0;
            } while (Confirmar("¿Desea seguir?"));
        }
        static bool EsPrimo(int numero)
        {
            for (int i = 2; i < numero; i++)
            {
                if ((numero % i) == 0)
                {
                    return false;
                }
            }
            return true;
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
