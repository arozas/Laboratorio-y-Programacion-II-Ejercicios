using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_UTN
{
    public class Estudiante
    {
        private string nombre;
        private string apellido;
        private string legajo;
        private int notaPrimerPacial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {

            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public int SetNotaPrimerPacial { set => notaPrimerPacial = value; }
        public int SetNotaSegundoParcial { set => notaSegundoParcial = value; }

        private float CalcularPromedio()
        {
            float promedio;
            promedio = (notaPrimerPacial + notaSegundoParcial) / 2;
            return promedio;
        }

        public double CalcularNotaFinal()
        {
            double notaFinal = new();
            if (notaPrimerPacial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 10);
            }
            else 
            {
                notaFinal = -1;
            }

            return notaFinal;
        
        }

        public string Mostrar()
        {
            //string mensajeMostrar = 
            //    "\nNOMBRE = 1" +
            //    "\nAPELLIDO: 2" +
            //    "\nLEGAJO: 3" +
            //    "\nNOTA PRIMER PARCIAL: 4" +
            //    "\nNOTA SEGUNDO PARICAL: 5"+
            //    "\nPROMEDIO: 6" +
            //    "\nNOTA FINAL: 7";
            StringBuilder retorno = new StringBuilder();
            retorno.Append($"\nNOMBRE: {nombre}");
            retorno.Append($"\nAPELLIDO: {apellido}");
            retorno.Append($"\nLEGAJO: {legajo}");
            retorno.Append($"\nNOTA PRIMER PARCIAL: {notaPrimerPacial}");
            retorno.Append($"\nNOTA SEGUNDO PARICAL: {notaSegundoParcial}");
            retorno.Append($"\nPROMEDIO: {CalcularPromedio()}");

            //retorno.Replace("1", $"{nombre}");
            //retorno.Replace("2", $"{apellido}");
            //retorno.Replace("3", $"{legajo}");
            //retorno.Replace("4", $"{notaPrimerPacial}");
            //retorno.Replace("5", $"{notaSegundoParcial}");
            //retorno.Replace("6", $"{CalcularPromedio()}");
            double notaFinal = CalcularNotaFinal();
            if (notaFinal != -1)
            {
                retorno.Append($"\nNOTA FINAL: {notaFinal}");
                //retorno.Replace("7", $"{notaFinal}");
            }
            else 
            {
                retorno.Append($"\nNOTA FINAL: Alumno desaprobado");
                //retorno.Replace("7", "Alumno desaprobado");
            }
            return retorno.ToString();
        }
    }
}
