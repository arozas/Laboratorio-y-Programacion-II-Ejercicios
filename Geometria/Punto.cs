using System;

namespace Geometria
{
    internal class Punto
    {
        private int x;
        private int y;

        public Punto(int x, int y)
        {
            this.x= x;
            this.y= y;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }
    }
}
