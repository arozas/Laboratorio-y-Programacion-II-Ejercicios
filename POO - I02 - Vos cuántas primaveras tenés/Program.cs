using System;
using Biblioteca_UTN;

namespace POO___I02___Vos_cuántas_primaveras_tenés
{
    /*ALEJANDRO ALBERTO MARTÍN ROZAS
    * Ejercicio I02 - ¿Vos cuántas primaveras tenés?
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona[] personas = new Persona[3];
            personas[0] = new Persona(GeneradorDeDatos.GenerarNombreAleatorio(), GeneradorDeDatos.GenerarFechaAleatoria(), GeneradorDeDatos.GenerarDNIAleatorio());
            personas[1] = new Persona(GeneradorDeDatos.GenerarNombreAleatorio(), GeneradorDeDatos.GenerarFechaAleatoria(), GeneradorDeDatos.GenerarDNIAleatorio());
            personas[2] = new Persona(GeneradorDeDatos.GenerarNombreAleatorio(), GeneradorDeDatos.GenerarFechaAleatoria(), GeneradorDeDatos.GenerarDNIAleatorio());

            foreach (Persona persona in personas)
            {
                Console.WriteLine($"{persona.EsMayorDeEdad()}:");
                persona.Mostrar();
            }
        }

    }
}
