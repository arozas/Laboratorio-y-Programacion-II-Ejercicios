using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_UTN
{
    public class CalculadoraDeArea
    {
        /// <summary>
        /// Calcula el área de un cuadrado.
        /// </summary>
        /// <param name="longitudLado">Medida del lado del cuadrado.</param>
        /// <returns>Retorna el área del cuadrado</returns>
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double retorno = longitudLado * 2;
            return retorno;
        }
        /// <summary>
        /// Calcula el área de un triangulo equilátero.
        /// </summary>
        /// <param name="baseTriangulo">Medida de la base del triangulo.</param>
        /// <param name="alturaTriangulo">Medida de la altura del triangulo.</param>
        /// <returns>Retorna el área del triangulo.</returns>
        public static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
        {
            double retorno = (baseTriangulo*alturaTriangulo)/2;
            return retorno;
        }
        /// <summary>
        /// Calcula el área de un circulo.
        /// </summary>
        /// <param name="radioCirculo">Medida del radio del circulo.</param>
        /// <returns>Retorna el área del circulo.</returns>
        public static double CalcularAreaCirculo(double radioCirculo)
        {
            double retorno = (Math.PI*Math.Pow(radioCirculo,2));
            return retorno;
        }
    }
   


}
