using System;
using System.Runtime.Intrinsics.Arm;

namespace Introducción___I07___Recibo_de_sueldo
{
    /*ALEJANDRO ALBERTO MARTÍN ROZAS
    * Ejercicio I07 - Recibo de sueldo
    * Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas en el mes de N cantidad de empleados de una fábrica.
    * Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
    * hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones restarle el 13% en concepto de descuentos.
    * Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar neto de todos los empleados ingresados.
    * IMPORTANTE
    * Utilizar sentencias de iteración y selectivas.
    * No es necesario ni se deben utilizar vectores/arrays.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string valorHoraIngresado;
            decimal valorHora = new decimal();
            string nombreIngresado;
            string añosIngresados;
            int años;
            string horasTrabajadasMes;
            decimal horasTrabajadas;
            decimal valorAntiguedad = 150;
            do
            {
                Console.WriteLine("\nIngrese el valor de la hora:");
                valorHoraIngresado = Console.ReadLine();
                //validacionNumeroIngresado =  //(!string.IsNullOrEmpty(valorHoraIngresado) && int.TryParse(valorHoraIngresado, out valorHora)) && (valorHora > 0);
                if (EsNumero(valorHoraIngresado,out valorHora) && valorHora>=1)
                {

                    Console.WriteLine("\nIngrese el nombre del empleado:");
                    nombreIngresado = Console.ReadLine();
                    if (!string.IsNullOrEmpty(nombreIngresado))
                    {
                        Console.WriteLine("\nIngrese la cantidad de años trabajados:");
                        añosIngresados = Console.ReadLine();
                        if (EsNumero(añosIngresados,out años)&& años >=0)
                        {
                            Console.WriteLine("\nIngrese la cantidad de horas trabajadas en el mes:");
                            horasTrabajadasMes = Console.ReadLine();
                            if (EsNumero(horasTrabajadasMes, out horasTrabajadas))
                            {
                                decimal sueldoBase = horasTrabajadas * valorHora;
                                decimal plusAntiguedad = años * valorAntiguedad;
                                decimal sueldoBruto = sueldoBase + plusAntiguedad;
                                float deducciones = (float)sueldoBruto * 0.13f;
                                decimal sueldoNeto = sueldoBruto - (decimal)deducciones;
                                Console.WriteLine($"Nombre: {nombreIngresado}");
                                Console.WriteLine($"Antiguedad: {años}");
                                Console.WriteLine($"Valor hora: {valorHora:C2}");
                                Console.WriteLine($"Sueldo Bruto: {sueldoBruto:C2} ");
                                Console.WriteLine($"Sueldo Neto: {sueldoNeto:C2}");
                            }
                            else
                            {
                                Console.WriteLine("Error. Debe Ingresar un una cantidad de horas valida, no puede dejar el campo vacío");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Error. Debe Ingresar un año valido, no puede dejar el campo vacío");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error. Debe Ingresar un nombre, no puede dejar el campo vacío");
                    }
                }
                else
                {
                    Console.WriteLine("Error. Debe Ingresar un valor de hora valido, no puede ser menor a  0");
                }

            } while (Confirmar("¿Desea seguir?")); 
        }
        static bool EsNumero(string valorString, out int valorInt)
        {
            int auxiliarInt = 0;
            bool retorno = !string.IsNullOrEmpty(valorString) && int.TryParse(valorString, out auxiliarInt);
            valorInt = auxiliarInt;
            return retorno;
        }
        static bool EsNumero(string valorString, out float valorInt)
        {
            float auxiliarFloat = 0;
            bool retorno = !string.IsNullOrEmpty(valorString) && float.TryParse(valorString, out auxiliarFloat);
            valorInt = auxiliarFloat;
            return retorno;
        }
        static bool EsNumero(string valorString, out decimal valorInt)
        {
            decimal auxiliarDecimal = 0;
            bool retorno = !string.IsNullOrEmpty(valorString) && decimal.TryParse(valorString, out auxiliarDecimal);
            valorInt = auxiliarDecimal;
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