using System;
using Biblioteca_UTN;

namespace Clases_y_Metodos___I01___Validador_de_rangos
{
    internal class Program
    {
        /*ALEJANDRO ALBERTO MARTÍN ROZAS
        * Ejercicio I01 - Validador de rangos
        * Realizar una clase llamada Validador que posea un método estático llamado Validar con la siguiente firma:
        *  bool Validar(int valor, int min, int max)
        *  valor: dato a validar.
        *  min: mínimo valor incluido.
        *  max: máximo valor incluido.
        *  Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
        *  Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
        *  IMPORTANTE:
        *  Utilizar variables escalares, NO utilizar vectores/arrays.
        */
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            int numeroMaximoIngresado = new();
            int numeroMinimoIngresado = new();
            bool banderaPrimerNumeroIngresado = false;
            int vueltasWhile=0;
            do
            {
                Console.WriteLine("\nIngrese un numero:");
                numeroIngresadoString = Console.ReadLine();
                int numeroIngresado;
                //validacionNumeroIngresado =  //(!string.IsNullOrEmpty(valorHoraIngresado) && int.TryParse(valorHoraIngresado, out valorHora)) && (valorHora > 0);
                if (Validador.EsNumero(numeroIngresadoString, out numeroIngresado) && Validador.Validar(numeroIngresado, -100, 100))
                {
                    if (banderaPrimerNumeroIngresado == false)
                    {
                        numeroMaximoIngresado = numeroIngresado;
                        numeroMinimoIngresado = numeroIngresado;
                        banderaPrimerNumeroIngresado = true;
                    }
                    else
                    {
                        if (numeroMaximoIngresado < numeroIngresado)
                        {
                            numeroMaximoIngresado = numeroIngresado;
                        }
                        else if (numeroMinimoIngresado > numeroIngresado)
                        {
                            numeroMinimoIngresado = numeroIngresado;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error. Debe ingresar un numero. Debe estar entre el Rango 100 y -100");
                }
                vueltasWhile++;
            } while (vueltasWhile<10);
            Console.WriteLine($"El numero máximo Ingresado es: {numeroMaximoIngresado}");
            Console.WriteLine($"El numero mínimo Ingresado es: {numeroMinimoIngresado}");
        }
    }
}
