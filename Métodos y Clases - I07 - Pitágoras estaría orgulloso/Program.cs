using System;
using Biblioteca_UTN;

namespace Métodos_y_Clases___I07___Pitágoras_estaría_orgulloso
{
    /* ALEJANDRO ALBERTO MARTÍN ROZAS
     * Ejercicio I07 - Pitágoras estaría orgulloso
     * Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.
     * El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y
     * Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.
     * Mostrar el resultado en la consola.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroIngresadoString;
            double resultadoOperacion = new();
            Console.WriteLine("");
            do
            {
                Console.WriteLine("Ingrese el la medida de la base del triangulo en cm:");
                numeroIngresadoString = Console.ReadLine();
                double baseTriangulo = new();
                if (Validador.EsNumero(numeroIngresadoString, out baseTriangulo))
                {
                    Console.WriteLine("Ingrese el la medida de la altura del triangulo en cm:");
                    numeroIngresadoString = Console.ReadLine();
                    double alturaTriangulo = new();
                    if (Validador.EsNumero(numeroIngresadoString, out alturaTriangulo))
                    {
                        //Por la precisión  del tipo Double y las caracteristicas del enunciado no se puede hacer la comprobación.
                        resultadoOperacion = CalculadoraDeArea.CalcularLongitudHipotenusa(baseTriangulo, alturaTriangulo);
                        Console.WriteLine("La longitud de la hipotenusa es:{0:N2} cm", resultadoOperacion);

                    }
                    else
                    {
                        Salida.MensajeErrorNumero();
                    }
                }
                else
                {
                    Salida.MensajeErrorNumero();
                }

            } while(Validador.ValidarRespuesta("¿Desea Continuar?"));
           
        }
    }
}
