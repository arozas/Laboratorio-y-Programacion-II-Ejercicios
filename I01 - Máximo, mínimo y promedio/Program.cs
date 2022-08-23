using System;
/*ALEJANDRO ALBERTO MARTÍN ROZAS
 * EJERCICIO I01 - Máximo, mínimo y promedio.
 * 
 * Tanto variables y lógica aplicada es para que el programa no rompa, independientemente de lo que ingresa el usuario. 
 */
namespace Clase_01___Ejercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int VUELTAS_WHILE = 5;
            string? numeroIngresadoString;
            float numeroIngresado = new float();
            float numeroMaximoIngresado = new float();
            float numeroMinimoIngresado = new float();
            float numeroPromedioIngresado;
            float acumuladorNumerosIngresados = 0;
            int contadorIngresosCorrectos = 0;
            int contadorErrores = 0;
            int contadorVueltasWhile = 0;
            bool banderaPrimerNumero = false;
            bool validacionNumeroIngresado = new bool();
            do
            {
                Console.WriteLine("Ingrese un numero a continuación:");
                numeroIngresadoString = Console.ReadLine();
                validacionNumeroIngresado = !string.IsNullOrEmpty(numeroIngresadoString) && float.TryParse(numeroIngresadoString, out numeroIngresado);
                if (validacionNumeroIngresado)
                {
                    contadorIngresosCorrectos++;
                    acumuladorNumerosIngresados+=numeroIngresado;
                    if (banderaPrimerNumero == false)
                    {
                        numeroMaximoIngresado = numeroIngresado;
                        numeroMinimoIngresado = numeroIngresado;
                        banderaPrimerNumero = true;
                    }
                    else
                    {
                        if (numeroMaximoIngresado < numeroIngresado)
                        {
                            numeroMaximoIngresado = numeroIngresado;
                        }
                        else
                        {
                            if (numeroMinimoIngresado > numeroIngresado)
                            {
                                numeroMinimoIngresado = numeroIngresado;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error. Debe Ingresar un numero valido.");
                    contadorErrores++;
                }
                contadorVueltasWhile++;
            } while (contadorVueltasWhile < VUELTAS_WHILE);
            if (contadorErrores == VUELTAS_WHILE)
            {
                Console.WriteLine("ERROR, NO SE PUDO HACER LA OPERACIÓN, NO SE INGRESARON NUMEROS");
            }
            else
            {
                numeroPromedioIngresado = acumuladorNumerosIngresados / contadorIngresosCorrectos;
                Console.WriteLine($"El numero Maximo es: {numeroMaximoIngresado}");
                Console.WriteLine($"El numero Minimo es: {numeroMinimoIngresado}");
                Console.WriteLine($"El valor promedio ingresado es: {numeroPromedioIngresado}");
            }
        }
    }
}
