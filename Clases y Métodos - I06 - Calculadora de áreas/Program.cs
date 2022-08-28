using System;
using Biblioteca_UTN;

namespace Clases_y_Métodos___I06___Calculadora_de_áreas
{
    /* ALEJANDRO ALBERTO MARTÍN ROZAS
     * Ejercicio I06 - Calculadora de áreas
     * Realizar una clase llamada CalculadoraDeArea que posea tres métodos de clase (estáticos) que realicen el cálculo del área que corresponda:
     * public double CalcularAreaCuadrado(double longitudLado) {}
     * public double CalcularAreaTriangulo(double base, double altura) {}
     * public double CalcularAreaCirculo(double radio) {}
     * El ingreso de los datos como la visualización se deberán realizar desde el método Main().
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            const int OPCIONES = 3;
            const int INTENTOS = 3;
            do 
            {
                string numeroIngresadoString;
                double resultadoOperacion = new();
                switch (Entrada.MostrarMenu("CALCULADOR DE ÁRES",
                    "\n 1. Calcular área de un cuadrado." +
                    "\n 2. Calcular área de un triangulo." +
                    "\n 3. Calcular área de un circulo.",
                    "Ingresar una opción <1-3>:",
                    "Error. debe ingresar una opción <1-3>:",
                    OPCIONES,
                    INTENTOS))
                {
                    case 1:
                        Console.WriteLine("Ingrese el la medida del lado del cuadrado en cm:");
                        numeroIngresadoString = Console.ReadLine();
                        double ladoDelCuadrado = new();
                        if (Validador.EsNumero(numeroIngresadoString, out ladoDelCuadrado))
                        {
                            resultadoOperacion = CalculadoraDeArea.CalcularAreaCuadrado(ladoDelCuadrado);
                            Console.WriteLine("El área del cuadrado es {0:N2} cm2", resultadoOperacion);
                        }
                        else
                        {
                            Salida.MensajeErrorNumero();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el la medida de la base del triangulo en cm:");
                        numeroIngresadoString= Console.ReadLine();
                        double baseTriangulo = new();
                        if (Validador.EsNumero(numeroIngresadoString, out baseTriangulo))
                        {
                            Console.WriteLine("Ingrese el la medida de la altura del triangulo en cm:");
                            numeroIngresadoString = Console.ReadLine();
                            double alturaTriangulo = new();
                            if (Validador.EsNumero(numeroIngresadoString, out alturaTriangulo))
                            {
                                resultadoOperacion = CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
                                Console.WriteLine("El área del triangulo es {0:N2} cm2", resultadoOperacion);

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
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el la medida del radio del circulo en cm:");
                        numeroIngresadoString = Console.ReadLine();
                        double radioCirculo = new();
                        if (Validador.EsNumero(numeroIngresadoString, out radioCirculo))
                        {
                            resultadoOperacion = CalculadoraDeArea.CalcularAreaCirculo(radioCirculo);
                            Console.WriteLine("El área del circulo es {0:N2} cm2", resultadoOperacion);
                        }
                        else
                        {
                            Salida.MensajeErrorNumero();
                        }
                        break;
                    default:
                        Salida.MensajeErrorOpcióonValida();
                        break;
                }
            } while (Validador.ValidarRespuesta("¿Desea Continuar? <S/N>:"));
            

        }
    }
}
