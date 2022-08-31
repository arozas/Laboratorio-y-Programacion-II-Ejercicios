using System;
using Geometria;

namespace POO___I05___Prueba_de_geometría
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRUEBA DE GEOMETRIA");
            Rectangulo rectanguloPrueba = new Rectangulo(10, 6, 4, 8);
            Console.WriteLine($"El perimetro del rectangulo es: {rectanguloPrueba.GetPerimetro()}");
            Console.WriteLine($"El área del rectangulo es: {rectanguloPrueba.GetArea()}");
        }
        public static void MostrarLadosRectangulo()
        {

        }
    }
   
}
