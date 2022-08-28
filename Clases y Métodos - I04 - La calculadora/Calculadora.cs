﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_y_Métodos___I04___La_calculadora
{
    internal class Calculadora
    {
        /// <summary>
        /// Toma dos valores y devuelve un resultado según la operación ingresada.
        /// </summary>
        /// <param name="primerOperando">Primer valor para calcular</param>
        /// <param name="segundoOperando">Segundo Valor para calcular</param>
        /// <param name="operacionMatematica"></param>
        /// <returns>Retorna el valor de la operación, en caso de error retorna 0.</returns>
        public static int Calcular(int primerOperando, int segundoOperando, string operacionMatematica)
        {
            int resultado = new();
            switch (operacionMatematica)
            {
                case "+":
                    resultado = primerOperando + segundoOperando;
                    break;
                case "-":
                    resultado = primerOperando - segundoOperando;
                    break;
                case "*":
                    resultado = primerOperando * segundoOperando;
                    break;
                case "/":
                    if (Calculadora.Validar(segundoOperando))
                    {
                        resultado = primerOperando + segundoOperando;
                    }
                    else
                    {
                        Console.WriteLine("Error. El valor del dividendo debe ser mayor a 0, no se realizó la operación.");
                    }
                    break;
                default:
                    Console.WriteLine("Error. No ingreso un operador valido, no se realizó la operación.");
                    break;
            }
            return resultado;
        }
        /// <summary>
        /// Toma dos valores y devuelve un resultado según la operación ingresada.
        /// </summary>
        /// <param name="primerOperando">Primer valor para calcular</param>
        /// <param name="segundoOperando">Segundo Valor para calcular</param>
        /// <param name="operacionMatematica"></param>
        /// <returns>Retorna el valor de la operación, en caso de error retorna 0.</returns>
        public static float Calcular(float primerOperando, float segundoOperando, string operacionMatematica)
        {
            float resultado = new();
            switch (operacionMatematica)
            {
                case "+":
                    resultado = primerOperando + segundoOperando;
                    break;
                case "-":
                    resultado = primerOperando - segundoOperando;
                    break;
                case "*":
                    resultado = primerOperando * segundoOperando;
                    break;
                case "/":
                    if (Calculadora.Validar(segundoOperando))
                    {
                        resultado = primerOperando + segundoOperando;
                    }
                    else
                    {
                        Console.WriteLine("Error. El valor del dividendo debe ser mayor a 0, no se realizó la operación.");
                    }
                    break;
                default:
                    Console.WriteLine("Error. No ingreso un operador valido, no se realizó la operación.");
                    break;
            }
            return resultado;
        }
        /// <summary>
        ///  Valida que el valor del parametro sea mayor a 0 (cero).
        /// </summary>
        /// <param name="numero">Valor int a validar</param>
        /// <returns>retorna "true" si es mayor a 0 (cero) y false si no es mayor a 0 (cero)</returns>
        private static bool Validar(int numero)
        {
            bool retorno = false;
            if (numero > 0)
            { 
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        ///  Valida que el valor del parametro sea mayor a 0 (cero).
        /// </summary>
        /// <param name="numero">Valor float a validar</param>
        /// <returns>retorna "true" si es mayor a 0 (cero) y false si no es mayor a 0 (cero)</returns>
        private static bool Validar(float numero)
        {
            bool retorno = false;
            if (numero > 0)
            {
                retorno = true;
            }
            return retorno;
        }
        /// <summary>
        ///  Valida que el valor del parametro sea mayor a 0 (cero).
        /// </summary>
        /// <param name="numero">Valor double a validar</param>
        /// <returns>retorna "true" si es mayor a 0 (cero) y false si no es mayor a 0 (cero)</returns>
        private static bool Validar(double numero)
        {
            bool retorno = false;
            if (numero > 0)
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
