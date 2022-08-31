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
            MostrarRectangulo(rectanguloPrueba);


        }
        public static void MostrarRectangulo(Rectangulo rectangulo)
        {
            Console.WriteLine($"El perimetro del rectangulo es: {rectangulo.GetPerimetro()}");
            Console.WriteLine($"El área del rectangulo es: {rectangulo.GetArea()}");
        }
    }
   
}
