using System;
using System.Security.Cryptography.X509Certificates;
using Biblioteca_UTN;

namespace POO___I01___Creo_que_necesito_un_préstamo
{
    /*ALEJANDRO ALBERTO MARTÍN ROZAS
     * Ejercicio I01 - Creo que necesito un préstamo
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            const int OPCIONES = 4;
            const int INTENTOS = 3;
            Cuenta nuevaCuenta = new("Cuenta Ejemplo", 0);
            int opcionIngresada;
            do
            {
                opcionIngresada = Entrada.MostrarMenu("SIMULADOR DE ATM",
                "\n1.DEPOSITAR DINERO" +
                "\n2.RETIRAR DINERO" +
                "\n3.MOSTRAR SALDO" +
                "\n4.SALIR",
                "\nINGRESE UNA OPCIÓN <1-4>:",
                "\nERROR. DEBE ELEGIR UNA OPCIÓN <1-4>:", OPCIONES, INTENTOS);
                switch (opcionIngresada)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Ingrese el monto a ingresar:");
                            string montoIngresadoString = Console.ReadLine();
                            decimal montoIngresado;
                            if (Validador.EsNumero(montoIngresadoString, out montoIngresado))
                            {
                                //Podia validar ingresado es mayor a cero antes de pasar el valor al método.
                                //pero decidí usar la validación del método para practicar, lo mismo para el retiro.
                                if (nuevaCuenta.Ingresar(montoIngresado))
                                {
                                    Console.WriteLine("La operación se realizó con exito.");
                                }
                                else
                                {
                                    Console.WriteLine("No se pudo realizar la operación.");
                                }
                                Console.WriteLine($"Su saldo ahora es de: {nuevaCuenta.GetCantidad():C2}");
                            }

                        } while (Validador.ValidarRespuesta("¿Desea hacer otro deposito?"));
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Ingrese el monto a extraer:");
                            string montoIngresadoString = Console.ReadLine();
                            decimal montoIngresado;
                            if (Validador.EsNumero(montoIngresadoString, out montoIngresado))
                            {
                                if (nuevaCuenta.Retirar(montoIngresado))
                                {
                                    Console.WriteLine("La operación se realizó con exito.");
                                }
                                else
                                {
                                    Console.WriteLine("No se pudo realizar la operación.");
                                }
                                Console.WriteLine($"Su saldo ahora es de: {nuevaCuenta.GetCantidad():C2}");
                            }

                        } while (Validador.ValidarRespuesta("¿Desea hacer otra extracción?"));
                        break;
                    case 3:
                        Console.WriteLine(nuevaCuenta.Mostrar());
                        break;
                    case 4:
                        Console.WriteLine("GRACIAS POR USAR NUESTRO SERVICIO");
                        break;
                }
            } while (opcionIngresada != OPCIONES);

            Salida.MensajeFinalizoPrograma();



        }
    }
}
