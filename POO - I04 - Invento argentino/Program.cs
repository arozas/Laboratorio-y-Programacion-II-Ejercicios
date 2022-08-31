using System;
using Biblioteca_UTN;

namespace POO___I04___Invento_argentino
{
    internal class Program
    {
        /*ALEJANDRO ALBERTO MARTÍN ROZAS
         * Ejercicio I04 - Invento argentino
         */
        static void Main(string[] args)
        {

            const int OPCIONES = 3;
            const int INTENTOS = 3;
            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red, 50);
            int[] opcionIngresada = new int[3];
            do
            {
                opcionIngresada[0] = Entrada.MostrarMenu("SELECCIONE UN BOLIGRAFO DIGITAL",
                "\n1.BOLIGRAFO AZUL" +
                "\n2.BOLIGRAFO ROJO" +
                "\n3.SALIR",
                "\nINGRESE UNA OPCIÓN <1-3>:",
                "\nERROR. DEBE ELEGIR UNA OPCIÓN <1-3>:", OPCIONES, INTENTOS);
                switch (opcionIngresada[0])
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            opcionIngresada[1] = Entrada.MostrarMenu("BOLIGRAFO AZUL",
                            "\n1.DIBUJAR ASTERICOS" +
                            "\n2.ESCRIBIR UN MENSAJE" +
                            "\n3.RECARGAR",
                            "\nINGRESE UNA OPCIÓN <1-3>:",
                            "\nERROR. DEBE ELEGIR UNA OPCIÓN <1-3>:", OPCIONES, INTENTOS);
                            switch (opcionIngresada[1])
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Ingrese la cantidad de astericos a dibujar");
                                    string numerosDeAstericosADibujar = Console.ReadLine();
                                    string asteriscosDibujados;
                                    int numerosDeAstericos;
                                    if (Validador.EsNumero(numerosDeAstericosADibujar, out numerosDeAstericos))
                                    {
                                        numerosDeAstericos *= -1;
                                        if (boligrafoAzul.Pintar((short)numerosDeAstericos, out asteriscosDibujados))
                                        {
                                            Console.WriteLine(asteriscosDibujados);
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    }
                                    if (boligrafoAzul.GetTinta == 0)
                                    {
                                        Console.WriteLine("¡El boligrafo se quedo sin tinta!");
                                    }
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Escriba el mensaje:");
                                    string mensajeEscrito = Console.ReadLine();
                                    int gastoDeTinta = mensajeEscrito.Length;
                                    gastoDeTinta *= -1;
                                    if (boligrafoAzul.Pintar((short)gastoDeTinta, mensajeEscrito, out asteriscosDibujados))
                                    {
                                        Console.WriteLine(asteriscosDibujados);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    if (boligrafoAzul.GetTinta == 0)
                                    {
                                        Console.WriteLine("¡El boligrafo se quedo sin tinta!");
                                    }
                                    break;
                                case 3:
                                    Console.Clear();
                                    boligrafoAzul.Recargar();
                                    Console.WriteLine("¡El boligrafo se recargó!");
                                    break;

                            }
                        } while (Validador.ValidarRespuesta("¿Desea seguir usando el boligrafo?"));
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            opcionIngresada[2] = Entrada.MostrarMenu("BOLIGRAFO ROJO",
                            "\n1.DIBUJAR ASTERICOS" +
                            "\n2.ESCRIBIR UN MENSAJE" +
                            "\n3.RECARGAR",
                            "\nINGRESE UNA OPCIÓN <1-3>:",
                            "\nERROR. DEBE ELEGIR UNA OPCIÓN <1-3>:", OPCIONES, INTENTOS);
                            switch (opcionIngresada[2])
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Ingrese la cantidad de astericos a dibujar");
                                    string numerosDeAstericosADibujar = Console.ReadLine();
                                    string asteriscosDibujados;
                                    int numerosDeAstericos;
                                    if (Validador.EsNumero(numerosDeAstericosADibujar, out numerosDeAstericos))
                                    {
                                        numerosDeAstericos *= -1;
                                        if (boligrafoRojo.Pintar((short)numerosDeAstericos, out asteriscosDibujados))
                                        {
                                            Console.WriteLine(asteriscosDibujados);
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    }
                                    if (boligrafoRojo.GetTinta == 0)
                                    {
                                        Console.WriteLine("¡El boligrafo se quedo sin tinta!");
                                    }
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.WriteLine("Escriba el mensaje:");
                                    string mensajeEscrito = Console.ReadLine();
                                    string mensajeDevuelto;
                                    int gastoDeTinta = mensajeEscrito.Length;
                                    gastoDeTinta *= -1;
                                    if (boligrafoRojo.Pintar((short)gastoDeTinta, mensajeEscrito, out mensajeDevuelto))
                                    {
                                        Console.WriteLine(mensajeDevuelto);
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    if (boligrafoRojo.GetTinta == 0)
                                    {
                                        Console.WriteLine("¡El boligrafo se quedo sin tinta!");
                                    }
                                    break;
                                case 3:
                                    Console.Clear();
                                    boligrafoRojo.Recargar();
                                    Console.WriteLine("¡El boligrafo se recargó!");
                                    break;

                            }
                        } while (Validador.ValidarRespuesta("¿Desea seguir usando el boligrafo?"));
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("GRACIAS POR ESCRIBIR CON NUESTRA MARCA");
                        break;
                }
            } while (opcionIngresada[0] != OPCIONES);

            Salida.MensajeFinalizoPrograma();
        }
    }
}
