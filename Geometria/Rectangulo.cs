using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        //Atributos
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        //Constructor
        public Rectangulo(int vertice1x, int vertice1y, int vertice3x, int vertice3y)
        {
            vertice1 = new Punto(vertice1x, vertice1y);
            vertice2 = vertice1;
            vertice3 = new Punto(vertice3x, vertice3y);
            vertice4 = vertice2;
        }
        //Propiedades
        public float GetArea()
        {
            if (this.area == 0)
            {
                float baseRectangulo = Math.Abs(vertice1.GetX() - vertice3.GetX());
                float alturaRectangulo = Math.Abs(vertice1.GetY() - vertice3.GetY());
                return (baseRectangulo + alturaRectangulo)/2;
            }
            else
            {
                return area;
            }
        }

        public float GetPerimetro()
        {
            if (this.perimetro == 0)
            {
                float baseRectangulo = Math.Abs(vertice1.GetX() - vertice3.GetX());
                float alturaRectangulo = Math.Abs(vertice1.GetY() - vertice3.GetY());
                return baseRectangulo*alturaRectangulo;
            }
            else
            {
                return perimetro;
            }
        }
    }
}
