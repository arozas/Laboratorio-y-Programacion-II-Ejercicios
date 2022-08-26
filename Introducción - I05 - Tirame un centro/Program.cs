using System;

namespace Introducción_I05_Tirame_un_centro
{
    /*ALEJANDRO ALBERTO MARTÍN ROZAS
    * Ejercicio I05 - Tirame un centro
    * Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en dos grupos de números, cuyas sumas son iguales.
    * El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
    * Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola. 
    * IMPORTANTE
    * Utilizar sentencias de iteración y selectivas.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            int numeroIngresado = new int();
            bool validacionNumeroIngresado = new bool();
            do
            {
                Console.WriteLine("\nIngrese un numero a continuación:");
                numeroIngresadoString = Console.ReadLine();
                validacionNumeroIngresado = (!string.IsNullOrEmpty(numeroIngresadoString) && int.TryParse(numeroIngresadoString, out numeroIngresado)) && (numeroIngresado > 0);
                if (validacionNumeroIngresado == true)
                {
                    EsCentroNumerico(numeroIngresado);
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            } while (Confirmar("¿Desea seguir?")); //No es parte del enunciado dejo esto asi por que se me hizo más facil probar rangos.
        }
        static void EsCentroNumerico(int numero)
        {
     
            int i;
            int contadorVueltas = 0;
            while (contadorVueltas < numero)
            {
                int sumaPrimeraParte = 0;
                int sumaSegundaParte = 0;
                contadorVueltas++;
                for (i = 1; i < contadorVueltas; i++)
                {
                    sumaPrimeraParte = sumaPrimeraParte + i;
                    //Console.WriteLine($"primera parte {i}"); Probando como llegar a la respuesta
                }
                for (int j = contadorVueltas+1; j <= sumaPrimeraParte; j++)
                {
                    if ((sumaPrimeraParte == sumaSegundaParte) || (sumaSegundaParte > sumaPrimeraParte))
                    {
                        break;
                    }
                    sumaSegundaParte = sumaSegundaParte + j;
                    //Console.WriteLine($"Segunda parte {j}");
                }
                if ((sumaPrimeraParte == sumaSegundaParte)&&contadorVueltas>1) //Ingreso que lógica para que no entre el uno como centro numerico.
                {
                    Console.WriteLine($"El numero {contadorVueltas}, es centro númerico");
                }
            }

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
