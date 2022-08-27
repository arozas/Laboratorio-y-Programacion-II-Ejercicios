using System;

namespace Introdución___I08___Dibujando_un_triángulo_rectángulo
{
    /*ALEJANDRO ALBERTO MARTÍN ROZAS
     * Ejercicio I08 - Dibujando un triángulo rectángulo
     * Escribir un programa que imprima por consola un triángulo como el siguiente:
     *   *
     *   ***
     *   *****
     *   *******
     *   *********
     *
     * El usuario indicará cuál será la altura del triángulo ingresando un número entero positivo. Para el ejemplo anterior, la altura ingresada fue de 5.
     * IMPORTANTE:
     * Utilizar sentencias de iteración y selectivas.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string alturaTrianfuloIngresado;
            int alturaTriangulo = new int();
            int vueltasWhile = 0;
            string rellenoTriangulo = "*";
            string nuevaLineaRelleno = "**";
            do
            {
                Console.WriteLine("\nIngrese el altura del triangulo:");
                alturaTrianfuloIngresado = Console.ReadLine();
                if (EsNumero(alturaTrianfuloIngresado, out alturaTriangulo) && alturaTriangulo >= 1)
                {
                    do
                    {
                        Console.WriteLine(rellenoTriangulo);
                        rellenoTriangulo += nuevaLineaRelleno;
                        vueltasWhile++;
                    } while (vueltasWhile < alturaTriangulo);
                }
                rellenoTriangulo = "*";
                vueltasWhile = 0;
            } while (Confirmar("¿Desea seguir?")) ;
        }
        static bool EsNumero(string valorString, out int valorInt)
        {
            int auxiliarInt = 0;
            bool retorno = !string.IsNullOrEmpty(valorString) && int.TryParse(valorString, out auxiliarInt);
            valorInt = auxiliarInt;
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