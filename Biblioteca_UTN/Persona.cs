using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_UTN
{
    public class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private int dni;

        /// <summary>
        /// Constructor de la clase Persona.
        /// </summary>
        /// <param name="nombre">Establece el valor del atributo nombre</param>
        /// <param name="fechaNacimiento">Establece el valor del atributo fechaNacimiento</param>
        /// <param name="dni">"Establece el valor del atributo dni"</param>
        public Persona(string nombre, DateTime fechaNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Dni { get => dni; set => dni = value; }

        /// <summary>
        /// Calcula la edad de la clase persona.
        /// </summary>
        /// <returns>Devuelve la edad en formato int</returns>
        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad;
            if (fechaActual.Day >= fechaNacimiento.Day && fechaActual.Month >= fechaNacimiento.Month)
            {
                edad = fechaActual.Year - fechaNacimiento.Year;
            }
            else
            {
                edad = fechaActual.Year - fechaNacimiento.Year -1;
            }
            return edad;
        }
        /// <summary>
        /// Imprime en consola la información del objeto persona.
        /// </summary>
        public void Mostrar()
        {
            Console.WriteLine($"NOMBRE: {nombre}");
            Console.WriteLine($"FECHA DE NACIMIENTO: {fechaNacimiento.ToShortDateString()}");
            Console.WriteLine($"DNI: {dni}");
            Console.WriteLine($"Edad: {CalcularEdad()}");
        }
        /// <summary>
        /// Calcula según la edad si el objeto persona es mayot de edad.
        /// </summary>
        /// <returns>Devuelve un valor string.</returns>
        public string EsMayorDeEdad()
        {
            string retorno;
            if (CalcularEdad() > 17)
            {
                retorno = "Es mayor de edad";
            }
            else
            {
                retorno = "Es menor de edad";
            }
            return retorno;
        }
    }
}
